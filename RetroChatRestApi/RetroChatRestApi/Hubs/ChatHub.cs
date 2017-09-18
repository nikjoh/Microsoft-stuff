using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RetroChatRestApi.Hubs
{
    
    public class ChatHub : Hub
    {
        
        public void BroadCastMessage(ChatMessage message)
        {
           
            Clients.All.MessageReciever(JsonConvert.SerializeObject(message));
        }

        // TODO: add private messages between users
    }
}
