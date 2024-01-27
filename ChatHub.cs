using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFrameworkSignalRDemo
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}