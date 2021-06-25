using System;
using blazorchat.Shared;
using Microsoft.AspNetCore.SignalR;

namespace blazorchat.Server.Hub
{
    public class Chat : Microsoft.AspNetCore.SignalR.Hub
    {
        public void SendMessage(ClientMessage message)
        {
            Clients.All.SendAsync("clientMessage", message);
        }
    }
}