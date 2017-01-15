using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cmr5Killer.Reflection
{
    abstract public class BaseReflection
    {
        protected Assembly _LoadAssembly;
        protected Type _GetType;
        protected object _CreateInstance;

        public BaseReflection(string fileLocation,string typeClass)
        {
            _LoadAssembly   = Assembly.LoadFrom(fileLocation);
            _GetType        = _LoadAssembly.GetType(typeClass);
            _CreateInstance = Activator.CreateInstance(_GetType);
        }


        public object GetFieldString(string fieldName)
        {
            var gfsObject = _GetType.GetField(fieldName, BindingFlags.NonPublic |
                        BindingFlags.Instance);

            return gfsObject.GetValue(_CreateInstance);
        }
       
    }
}
