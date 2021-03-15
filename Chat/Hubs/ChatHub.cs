using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string usuario, string mensaje, DateTime hora)
        {
            await Clients.All.SendAsync("ReceiveMessage", usuario, mensaje, hora);
        }
    }
}
