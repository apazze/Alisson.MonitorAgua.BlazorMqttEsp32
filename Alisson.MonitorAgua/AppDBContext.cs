using Microsoft.EntityFrameworkCore;

namespace Alisson.MonitorAgua
{
    public class AppDBContext : DbContext
    {
        #region CONFIGURATIONS
        public AppDBContext()
        {
        }
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MonitoramentoAgua");
                optionsBuilder.UseSqlServer(@"Server=monitoragua.database.windows.net;Database=MonitorAgua;User ID=alisson.pazze;Password=Qwerty@2020;Trusted_Connection=False;Encrypt=True");
            ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seedando as tabelas
            SeedEntity(SensorSeed());
            SeedEntity(DataSeed());
            SeedEntity(RegraSeed());

            // Métodos auxiliares via template + internal methods
            void SeedEntity<T>(T[] seedData) where T : class
                => modelBuilder.Entity<T>().HasData(seedData);

            Sensor[] SensorSeed()
            {
                Sensor[] sensorsSeed = new Sensor[]
                {
                    new Sensor
                    {
                        Id = 1,
                        NameSensor = "Temperatura",
                        Type = "DHT11",
                        Unit = "C",
                        Value = "23.05"
                    },
                    new Sensor
                    {
                        Id = 2,
                        NameSensor = "Temperatura",
                        Type = "DHT11",
                        Unit = "C",
                        Value = "27.3"
                    }
                };

                return sensorsSeed;
            }

            Data[] DataSeed()
            {
                Data[] datasSeed = new Data[]
                {
                    new Data
                    {
                        Id = 1,
                        MessageId = 1,
                        Payload = "payload seed 1",
                        QoS = "qos seed 1",
                        RetainFlag = true,
                        Topic = "topic seed 1",
                        ClientId = "clientId seed 1",
                        TimeStamp = System.DateTime.Now
                    },
                    new Data
                    {
                        Id = 2,
                        MessageId = 2,
                        Payload = "payload seed 2",
                        QoS = "qos seed 2",
                        RetainFlag = true,
                        Topic = "topic seed 2",
                        ClientId = "clientId seed 2",
                        TimeStamp = System.DateTime.Now
                    }
                };
                return datasSeed;
            }
            
            Regra[] RegraSeed()
            {
                Regra[] regrasSeed = new Regra[]
                {
                    new Regra
                    {
                        Id = 1,
                        Valor = "150",
                        TimeStamp = System.DateTime.Now
                    },
                    new Regra
                    {
                        Id = 2,
                        Valor = "170",
                        TimeStamp = System.DateTime.Now
                    },
                };
                return regrasSeed;
            }
        }

        #endregion

        #region ENTITIES

        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<Data> Datas { get; set; }
        public DbSet<Regra> Regras { get; set; }


        #endregion
    }
}
