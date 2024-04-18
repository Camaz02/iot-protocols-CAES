using NetCoreClient.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetCoreClient.Sensors
{
    internal class VirtualPositionSensor : IPositionSensorInterface, ISensorInterface
    {
        private readonly Random Random;

        public VirtualPositionSensor()
        {
            Random = new Random();
        }

        public string Position()
        {
            //41°24'12.2"N 2°10'26.5"E
            return new Position(Random.Next(59) + "°" + Random.Next(59) + "'" + Random.Next(59) + "\"N " + Random.Next(59) + "°" + Random.Next(59) + "'" + Random.Next(59) + "\"E").Value;
        }
        public string ToJson()
        {
            return JsonSerializer.Serialize(Position());
        }
    }
}
