using System;
using System.Linq;
using System.Threading.Tasks;
using Alisson.MonitorAgua;
using MQTTnet;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using MQTTnet.Client.Receiving;
using MQTTnet.Extensions.ManagedClient;
using Newtonsoft.Json;
using Serilog;

namespace MQTTFirstLook.Client
{
    class Program
    {
        private static int intervalo = 10000;
        private static int? portaBroker = 5011;
        private static string clientName = "Alisson.MonitorAgua.Client";

        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            MqttClientOptionsBuilder builder = new MqttClientOptionsBuilder()
                                        .WithClientId(clientName)
                                        .WithTcpServer("localhost", portaBroker);

            ManagedMqttClientOptions options = new ManagedMqttClientOptionsBuilder()
                                    .WithAutoReconnectDelay(TimeSpan.FromSeconds(60))
                                    .WithClientOptions(builder.Build())
                                    .Build();

            IManagedMqttClient _mqttClient = new MqttFactory().CreateManagedMqttClient();

            _mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(OnConnected);
            _mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(OnDisconnected);
            _mqttClient.ConnectingFailedHandler = new ConnectingFailedHandlerDelegate(OnConnectingFailed);

            _mqttClient.ApplicationMessageReceivedHandler = new MqttApplicationMessageReceivedHandlerDelegate(a =>
            {
                Log.Logger.Information("Message recieved: {payload}", a.ApplicationMessage);
            });

            _mqttClient.StartAsync(options).GetAwaiter().GetResult();
            
            bool avisei = false;
            int dataAviso = -1;

            while (true)
            {

                var contexto = new AppDBContext();

                
                var valorConfigurado = contexto.Regras
                    .OrderBy(v => v.Id)
                    .Select(v => v.Valor).LastOrDefault();

                var dataConfiguracao = contexto.Regras
                    .OrderBy(v => v.Id)
                    .Select(v => v.TimeStamp).LastOrDefault();

                var valorConfiguradoDecimal = Decimal.Parse(valorConfigurado);
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"O valor configurado para a advertência é: [ {valorConfiguradoDecimal} ]");


                var valorMaximoDoDia = (from d in contexto.Datas
                                           join s in contexto.Sensors
                                           on d.SensorId equals s.Id
                                           where d.TimeStamp.DayOfYear == DateTime.Now.DayOfYear
                                           select s.Value).Max();
                
                var valorMaximoDoDiaDecimal = Decimal.Parse(valorMaximoDoDia);
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"O valor máximo recebido no dia é: [ {valorMaximoDoDiaDecimal} ]");

                if (valorMaximoDoDiaDecimal > valorConfiguradoDecimal && !avisei)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\t\t\t\t\t### Enviando Advertência ###\n\n");
                    
                    if(DateTime.Now.DayOfYear > dataAviso)
                    {
                        dataAviso = DateTime.Now.DayOfYear;
                        avisei = true;
                    }
                    string json = JsonConvert.SerializeObject(new { acionarSirene = true, dataEnvio = DateTime.Now });

                    _mqttClient.PublishAsync("monitorAgua/advertencia", json);
                }
                Task.Delay(intervalo).GetAwaiter().GetResult();
            }

        }

        public static void OnConnected(MqttClientConnectedEventArgs obj)
        {
            Log.Logger.Information("Successfully connected.");
        }

        public static void OnConnectingFailed(ManagedProcessFailedEventArgs obj)
        {
            Log.Logger.Warning("Couldn't connect to broker.");
        }

        public static void OnDisconnected(MqttClientDisconnectedEventArgs obj)
        {
            Log.Logger.Information("Successfully disconnected.");
        }
    }
}

