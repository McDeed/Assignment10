using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensors = new[] {
                new {SensorType = "Pressure",
                Units = "Atmosphere",Range_Lower = -10, Range_Upper = 100,
                No_of_Nodes = 1},
                new {SensorType = "Temperature",
                Units = "Celsius",Range_Lower = -40, Range_Upper = 100,
                No_of_Nodes = 4},
                new {SensorType = "CO2 Concentration",
                Units = "PPM",Range_Lower = 0, Range_Upper = 20000,
                No_of_Nodes = 2},
                new {SensorType = "Relative Humidity",
                Units = "Percentage",Range_Lower = 0, Range_Upper = 100,
                No_of_Nodes = 3},
                new {SensorType = "Air Flow meter",
                Units = "Grams per second",Range_Lower = 0, Range_Upper = 200,
                No_of_Nodes = 1},
                new {SensorType = "AC Current Sensor",
                Units = "Ampere",Range_Lower = -100, Range_Upper = 100,
                No_of_Nodes = 2}};


            var vendor_address = new[]
            {
                new {SensorType = "Pressure",
                Vendor_Name = "ABC",City = "Tromsoe", Country = "Norway"
                },
                new {SensorType = "Temperature",
                Vendor_Name = "KPAX",City = "San Francisco", Country = "USA",
                },
                new {SensorType = "CO2 Concentration",
                Vendor_Name = "MacroNet",City = "New York City", Country = "USA",
                },
                new {SensorType = "Relative Humidity",
                Vendor_Name = "Alpha Tech",City = "London", Country = "UK",
               },
                new {SensorType = "Air Flow meter",
                Vendor_Name = "Milano Tech",City = "Milan", Country = "Italy",
                },
                new {SensorType = "AC Current Sensor",
                Vendor_Name = "Advanced Solutions",City = "Helsinki", Country = "Finland",
                }
            };


            var join = from sens in sensors
                       join vendor in vendor_address on sens.SensorType equals vendor.SensorType
                       select new { sens.SensorType, sens.Units, vendor.Country, vendor.Vendor_Name};


            join = join.OrderBy(sname => sname.Country);
            foreach (var a in join) Console.WriteLine("Name:{0}, Units:{1}, Vendor:{2}, Country:{3}" ,a.SensorType, a.Units, a.Vendor_Name, a.Country);

            Console.ReadKey();


        }
    }
}
