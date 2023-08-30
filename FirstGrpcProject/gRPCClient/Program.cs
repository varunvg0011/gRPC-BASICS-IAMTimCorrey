using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gRPCClient;
using GrpcServer;

namespace gRPCClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var input = new HelloRequest { Name = "Varun" };
            var channel = GrpcChannel.ForAddress("https://localhost:7214");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(input);//the response we get

            Console.WriteLine(reply.Message);
            Console.ReadLine();

        }
    }
}
