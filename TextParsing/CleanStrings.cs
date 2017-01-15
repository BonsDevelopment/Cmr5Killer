using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmr5Killer.TextParsing
{
    public static class CleanStrings
    {

        public static string CleanString(string origString, string startCut, string endCut, int indexValue = 0)
        {
            int Start = origString.IndexOf(startCut, indexValue) + startCut.Length;
            int End = origString.IndexOf(endCut, Start);
            return origString.Substring(Start, End - Start);
        }
    }
}
