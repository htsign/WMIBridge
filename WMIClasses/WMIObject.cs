using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMIBridge.WMIClasses
{
    public abstract class WMIObject
    {
        public static IEnumerable<T> GetInstances<T>()
            where T : WMIObject, new()
        {

        }
    }
}
