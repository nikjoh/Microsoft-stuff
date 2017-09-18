using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        private const int appVersion = 1;

        private TcpClient client;
        private string userName;

        public Form1()
        {
            InitializeComponent();
            SetChatPanelVisibile(false);
        }

        private void SetChatPanelVisibile(bool visible)
        {
            chatPanel.Visible = visible;
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            string command = "quit";
            string text = messageTextBox.Text;
            if (messageTextBox.Text != "quit")
            {
                command = "send";
            }
            Message message = new Message(command, userName, text, appVersion);
            Send(message);

        }
            
        private void joinChatButton_Click(object sender, EventArgs e)
        {
            userName = nameTextBox.Text;
            Thread clientThread = new Thread(Start);
            clientThread.Start();
            SetChatPanelVisibile(true);
        }

        private void Start()
        {
            client = new TcpClient("192.168.1.69", 5000);

            Thread senderThread = new Thread(Listen);
            senderThread.Start();
            senderThread.Join();
        }

        private void Listen()
        {
            string message = "";

            try
            {
                while (true)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    chatListBox.Items.Add(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Send(Message message)
        {

            try
            {
                NetworkStream n = client.GetStream();
                BinaryWriter w = new BinaryWriter(n);
                w.Write(JsonConvert.SerializeObject(message));
                w.Flush();
                chatListBox.Items.Add($"{message.User}: {message.Text}");
                if (message.Command.Equals("quit"))
                {
                    client.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
