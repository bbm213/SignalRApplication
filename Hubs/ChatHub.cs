﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApplication.Hubs
{
    public class ChatHub: Hub
    {
        public async Task SendMessage(string fromUser, string message) 
        {
            await Clients.All.SendAsync("ReceiveMessage", fromUser, message);
        }
    }
}
