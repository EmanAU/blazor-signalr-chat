using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {

        private static int _userCount = 0;
        public async Task SendMessage(string User, string Message)
        {
            await Clients.All.SendAsync("ReceiveMessage", User, Message);
        }

        public override async Task OnConnectedAsync()
        {
            _userCount++;
            await Clients.All.SendAsync("UpdateUserCount", _userCount);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            _userCount--;
            await Clients.All.SendAsync("UpdateUserCount", _userCount);
            await base.OnDisconnectedAsync(exception);
        }
    }
}
