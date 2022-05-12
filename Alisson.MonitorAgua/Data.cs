using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisson.MonitorAgua
{
    public class Data
    {
        public int Id { get; set; }
        public int SensorId { get; set; }
        public Sensor Sensor { get; set; }
        public int MessageId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ClientId { get; set; }
        public string Topic { get; set; }
        public string Payload { get; set; }
        public string QoS { get; set; }
        public bool RetainFlag { get; set; }
    }
}
