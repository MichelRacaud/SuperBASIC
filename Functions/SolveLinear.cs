using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class SolveLinear : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
		{
            float a = arguments[0];
            float b = arguments[1];
            float y = arguments[2];
            if (a == 0)
            {
                return float.NaN;
            } else
            {
                return (y - b) / a;
            }
		}
	}
}
