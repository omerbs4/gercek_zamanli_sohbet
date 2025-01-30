using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{

    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage",user,message);
    }

}
// #2d2a4a;