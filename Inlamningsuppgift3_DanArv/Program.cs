using Microsoft.Azure.Devices.Client;
using SharedLibrary.Models;
using SharedLibrary.Services;
using System;

namespace Inlamningsuppgift3_DanArv
{
    class Program
    {
        private static readonly string _conn = "HostName=ec-win20-danarv.azure-devices.net;DeviceId=consoleApp;SharedAccessKey=TBEL/rmoCXi04vvrsMhHzgcjuZe4cx2PZGes3BaHEdo=";
        


        private static readonly DeviceClient deviceClient = 
            DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);

        static void Main(string[] args)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();

            Console.ReadKey();
        }
    }
}
