using Grpc.Core;

namespace Sample.gRPC.GrpcGreeter.Services;

public class GoodbyeService : Goodbye.GoodbyeBase
{
    private readonly ILogger<GoodbyeService> _logger;

    public GoodbyeService(ILogger<GoodbyeService> logger)
    {
        _logger = logger;
    }

    public override Task<GoodbyeReply> SayGoodbye(GoodbyeRequest request, ServerCallContext context)
    {
        return Task.FromResult(new GoodbyeReply
        {
            Message = "Goodbye " + request.Name
        });
    }
}