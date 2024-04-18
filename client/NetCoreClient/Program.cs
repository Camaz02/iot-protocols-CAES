using NetCoreClient.Sensors;
using NetCoreClient.Protocols;

// define sensors
List<ISensorInterface> sensors = new();
sensors.Add(new VirtualSpeedSensor());
sensors.Add(new VirtualFuelSensor());
sensors.Add(new VirtualPositionSensor());

// define protocol
ProtocolInterface protocol = new Http("https://20ca-185-122-225-105.ngrok-free.app/cars/1");

// send data to server
while (true)
{
    foreach (ISensorInterface sensor in sensors)
    {

        var sensorValue = sensor.ToJson();

        protocol.Send(sensorValue);

        Console.WriteLine("Data sent: " + sensorValue);

        Thread.Sleep(1000);
    }

}