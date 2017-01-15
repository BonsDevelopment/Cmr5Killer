using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr5Killer.TextParsing
{
    public class ExtractMSIL
    {
        private static string tempFilePath = Path.GetTempPath() + "ExtractedCode.il";

        static public void ExtractMSILCodeAsString(string msilFile)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "ildasm.exe";
            startInfo.Arguments = msilFile + " /output:" + tempFilePath;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            Process.Start(startInfo);
        }

        static public string GetExecFunction()
        {
            System.Threading.Thread.Sleep(2000);
           
            if (!File.Exists(tempFilePath)) { return null; }

            string msilFileText = File.ReadAllText(tempFilePath);


            File.WriteAllText(Path.GetTempPath() + "text.txt", CleanStrings.CleanString(msilFileText, "MyApp.cookiework::tickk", "Cookie Muncher R5 has received").Replace("\"CommandLine\"",""));

            return Path.GetTempPath() + "text.txt";
                
        }
    }
}
