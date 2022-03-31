using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisson.MonitorAgua
{
    public class Sensor
    {
        public int Id { get; set; }
        public string NameSensor { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
    }
}
