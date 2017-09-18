using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RetroChatAPI.Utils
{
    public class Logger
    {
        //private const string logErrorFileDir = "/software/retro-chat/log/log-error";
        private const string logErrorFileDir = @"C:\Users\Administrator\Source\Repos\RetroChatAPI\RetroChatAPI";


        public static void LogError(string className, string errorMessage)
        {
            DateTime date = DateTime.Now;

            string text = date + " - Class: " + className + " - Error: " + errorMessage + "\n";
            File.AppendAllText(logErrorFileDir, text);
        }

        // TODO: methods for logging info/warning
    }
}

