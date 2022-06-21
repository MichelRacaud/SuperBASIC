using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Accumulate : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float a = arguments[0];
            float b = arguments[1];
            short inta;
            short intb;
            if ((!Int16.TryParse(a.ToString(), out inta)) || (!Int16.TryParse(b.ToString(), out intb)) || (b < a))
            {
                return float.NaN;
            }
            else
            {
                float result = 0;
                for(var i = inta; i<=intb; i++)
                {
                    result += Memory.MemoryGet(i);
                }

                return result;
            }
        }
    }
}
