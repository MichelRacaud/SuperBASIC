using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC
{
	public interface IFunction
	{
		public float Apply(List<BasicNumber> arguments);
	}
}
