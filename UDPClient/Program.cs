using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UDPClient
{
    class Program
    {

        private static UdpClient client;
        
        static void Main(string[] args)
        {

            client = new UdpClient("127.0.0.1", 9999);
            Console.WriteLine("Client connection");

            while (true)
            {
                Console.Write(">> ");
                String message = Console.ReadLine();
                send(message);
            }

        }

        private static void send(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            client.Send(data, data.Length);
        }
    }
}
