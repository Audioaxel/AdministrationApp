using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;
using SignalR.ChatHubs;

namespace SignalRLib.Module;

public static class ModuleExtensions
{
    public static void RegisterSignalRLibServices(this IServiceCollection services)
    {
        services.AddResponseCompression(options => 
        {
            options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                new[] { "application/octet-stream"});
        });
    }

    public static void ConfigureSignalRLib(this WebApplication app)
    {
        app.MapHub<ChatHub>("/chathub");
    }
}