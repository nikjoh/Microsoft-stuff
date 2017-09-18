using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    class Message
    {
        public string Command { get; set; }
        public string User { get; set; }
        public int Version { get; set; }
        public string Text { get; set; }

        public Message(string command, string user, string text, int version)
        {
            Command = command;
            User = user;
            Text = text;
            Version = version;
        }
    }
}
