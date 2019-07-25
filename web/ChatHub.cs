using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class ChatHub : Hub
{
    public async Task SendToAll(string name, string message)
    {
         await  Clients.All.SendAsync("sendToAll", name, message);
    }
} 