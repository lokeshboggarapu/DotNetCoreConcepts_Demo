using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class IntermediateClass:BaseClass
    {
        public override string baseclass()
        {
            return "this is Intermediate class";
            
        }

        public new virtual string demo()
        {
            return "this is demoi";
        }
    }
}
