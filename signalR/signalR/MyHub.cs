using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace signalR.signalR
{
    [HubName("chatHub")]

    public class chatHub : Hub
    {

        public void send(string message)
        {

            Clients.Others.addMessage(message);

        }

    }
}