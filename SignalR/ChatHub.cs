using System;
using System.Threading.Tasks;
using steelAuth.SignalR;
using Microsoft.AspNetCore.SignalR;

namespace steelAuth.SignalR
{
    public class ChatHub: Hub
    {
        public ChatHub()
        {
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        //public override async Task OnConnectedAsync()
        //{
        //    await Clients.All.SendAsync("Notify", $"{Context.ConnectionId} присоединился чат");
        //    await base.OnConnectedAsync();
        //}

        //public override async Task OnDisconnectedAsync(Exception exception)
        //{
        //    await Clients.All.SendAsync("Notify", $"{Context.ConnectionId} покинул чат");
        //    await base.OnDisconnectedAsync(exception);
        //} 

        //public Task ImageMessage(ImageMessage file)
        //{
        //    return Clients.All.SendAsync("ImageMessage", file);
        //}

    }
}
