using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RetroChatServer.Utils
{
    public class CoolUtil
    {

        public static string GetBase64ImageFromDisk(string filePath)
        {
            // TODO: try catch
            string image = "data:image/png;base64,";
            image += Convert.ToBase64String(File.ReadAllBytes(filePath));
            return image;
        }
    }
}
