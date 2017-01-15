using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr5Killer.TextParsing
{
    public static class RetrieveEncryptedText
    {
       
        public static List<string> EncryptedStrings(string textFileLocation)
        {
            List<string> l1 = new List<string>();
            int counter = 0;
            string line;
            using (StreamReader file = new StreamReader(textFileLocation))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("\""))
                    {
                        
                         l1.Add(line);
                    }
                    counter++;
                }
            }
            l1.RemoveAt(l1.Count - 1);
           return l1;
        }
    }
}
