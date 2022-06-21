using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Rem : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float a = arguments[0];
            float b = arguments[1];
            int inta;
            int intb;
            if ((! Int32.TryParse(a.ToString(), out inta)) || (!Int32.TryParse(b.ToString(), out intb)) || (b == 0))
            {
                return float.NaN;
            }
            else
            {
                return (float)(inta / intb);
            }
        }
    }
}
