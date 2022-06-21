using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class SphereVol : IFunction
    {
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)(4 * Math.PI * arguments[0] * arguments[0] * arguments[0] / 3);
		}
	}
}
