using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    partial class Auto
    {
        public override string ToString()
        {
            return (String.Format(name+" "+maxSpeed+" "+serialNo+" "+weight+" "+type));
        }
    }
}
