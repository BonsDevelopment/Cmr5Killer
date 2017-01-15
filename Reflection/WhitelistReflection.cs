using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cmr5Killer.Reflection
{
    public class WhitelistReflection : BaseReflection
    {

        public WhitelistReflection(string fileLocation, string typeClass)
            : base(fileLocation, typeClass) { }
       

        public string DecryptString(object hwidKey, string encString)
        {
            
            MethodInfo info = _GetType.GetMethod("init");
            info.Invoke(_CreateInstance, new object[] { });

            info = _GetType.GetMethod("init2");
            info.Invoke(_CreateInstance, new object[] { hwidKey});

            info = _GetType.GetMethod("decryptstring");
            return (string)info.Invoke(_CreateInstance, new object[] { encString });
        }
    }
}
