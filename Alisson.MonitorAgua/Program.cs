// See https://aka.ms/new-console-template for more information
using Alisson.MonitorAgua;
using MQTTnet;
using MQTTnet.Server;
using Newtonsoft.Json;
using Serilog;
using System.Text;


namespace Alisson.MonitorAgua
{
    internal class Program
    {
        private static int MessageCounter = 0;
        static int portServiceMQTT = 5011;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .Enrich.FromLogContext()
                            .WriteTo.Console()
                            .CreateLogger();

            MqttServerOptionsBuilder options = new MqttServerOptionsBuilder()
                .WithDefaultEndpoint()
                .WithDefaultEndpointPort(portServiceMQTT)
                .WithConnectionValidator(OnNewConnection)
                .WithApplicationMessageInterceptor(OnNewMessage);


            IMqttServer mqttServer = new MqttFactory().CreateMqttServer();

            mqttServer.StartAsync(options.Build()).GetAwaiter().GetResult();
            Console.ReadLine();
        }


        static void OnNewConnection(MqttConnectionValidatorContext context)
        {
            Log.Logger.Information(
                    "New connection: ClientId = {clientId}, Endpoint = {endpoint}, CleanSession = {cleanSession}",
                    context.ClientId,
                    context.Endpoint,
                    context.CleanSession);
        }

        static void OnNewMessage(MqttApplicationMessageInterceptorContext context)
        {
            
            AppDBContext contexto = new AppDBContext();
            var payload = context.ApplicationMessage?.Payload == null ? null : Encoding.UTF8.GetString(context.ApplicationMessage?.Payload);

            MessageCounter++;

            Log.Logger.Information(
                "MessageId: {MessageCounter} - TimeStamp: {TimeStamp} -- Message: ClientId = {clientId}, Topic = {topic}, Payload = {payload}, QoS = {qos}, Retain-Flag = {retainFlag}",
                MessageCounter,
                DateTime.Now,
                context.ClientId,
                context.ApplicationMessage?.Topic,
                payload,
                context.ApplicationMessage?.QualityOfServiceLevel,
                context.ApplicationMessage?.Retain);

            if(context.ApplicationMessage?.Topic == "monitorAgua/vazao")
            {
                Sensor convertJson2Class = JsonConvert.DeserializeObject<Sensor>(payload);
                Console.WriteLine("");

                contexto.Sensors.Add(convertJson2Class);
                contexto.SaveChanges();

                Data data = new Data()
                {
                    MessageId = MessageCounter,
                    TimeStamp = DateTime.Now,
                    ClientId = context.ClientId,
                    Topic = context.ApplicationMessage?.Topic,
                    QoS = context.ApplicationMessage?.QualityOfServiceLevel.ToString(),
                    Payload = payload,
                    RetainFlag = (bool)context.ApplicationMessage?.Retain,
                    Sensor = convertJson2Class
                };
                contexto.Datas.Add(data);
                contexto.SaveChanges();
            }


        }
    }
}


