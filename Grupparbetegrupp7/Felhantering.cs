using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Grupparbetegrupp7
{
    class Felhantering
    {
        public void ExceptionMethod(string fileName,string functionName,string content)
        {
            StreamWriter sw = null;
            StringBuilder sb = null;
            string directory = "C:\\temp\\LogErrors";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            string path = Path.Combine(directory, fileName + ".log");
            sb = new StringBuilder("Log : ");
            sb.Append(functionName + " | ");
            sb.Append(content);
            sw = new StreamWriter(path, true);
            sw.Write(sb);
            sw.Close();
        }
    }
}
