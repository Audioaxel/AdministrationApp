using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalR.ChatHubs;

public class ChatHub : Hub
{
    public Task SendMessage(string user, string message)
    {
        return Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}