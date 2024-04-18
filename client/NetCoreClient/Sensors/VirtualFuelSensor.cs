using NetCoreClient.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetCoreClient.Sensors
{
    internal class VirtualFuelSensor : IFuelSensorInterface, ISensorInterface
    {
        private readonly Random Random;

        public VirtualFuelSensor()
        {
            Random = new Random();
        }

        public int Fuel()
        {
            return new Fuel(Random.Next(70)).Value; // Max is the fuel capacity of the car
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Fuel());
        }
    }
}
