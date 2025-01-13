using Grpc.Net.Client;
using GrpcGreeterClient;

using var channel = GrpcChannel.ForAddress("https://localhost:7277");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });

Console.WriteLine("Greeting: " + reply.Message);

var goodbyeClient = new Goodbye.GoodbyeClient(channel);
var goodbyeReply = await goodbyeClient.SayGoodbyeAsync(new GoodbyeRequest { Name = "GreeterClient" });

Console.WriteLine("Goodbye: " + reply.Message);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();