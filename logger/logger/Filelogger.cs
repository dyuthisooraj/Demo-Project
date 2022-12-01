using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
    internal class Filelogger:Ilogger
    {
        public void Info(string message)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\log.txt";

            using (StreamWriter sw = File.AppendText(docPath))
            {
                sw.WriteLine(message);
            }

            using (StreamReader rd = new StreamReader(docPath))
            {
                Console.WriteLine(rd.ReadToEnd());
            }
        }
    }
}
