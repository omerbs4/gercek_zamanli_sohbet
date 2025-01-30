using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{

    public async Task SendMessage(string user, string message,string imageBase64)
    {
        await Clients.All.SendAsync("ReceiveMessage",user,message,imageBase64);
    }

}
// #2d2a4a;