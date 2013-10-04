using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Microsoft.AspNet.SignalR.Samples.SignalR_ChatSample
{
    public class ChatHub : Hub
    {
        public override Task OnConnected()
        {
            Clients.Caller.logMessage("Connected");
            return base.OnConnected();
        }

        public override Task OnDisconnected()
        {
            Clients.Caller.logMessage("Disconnected");
            return base.OnDisconnected();
        }

        public override Task OnReconnected()
        {
            Clients.Caller.logMessage("Reconnected");
            return base.OnReconnected();
        }
    }
}