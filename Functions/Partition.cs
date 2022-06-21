using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Partition : IFunction
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
                float valeur_pivot = Memory.MemoryGet((short)((intb - inta) / 2));
                short i = inta;
                short j = intb;
                while (i < j)
                {
                    if ((Memory.MemoryGet(i) == Memory.MemoryGet(j)) && (Memory.MemoryGet(i) == valeur_pivot)) {
                        return j;
                    }
                    while (Memory.MemoryGet(i) < valeur_pivot)
                    {
                        i++;
                    }

                    while (Memory.MemoryGet(j) > valeur_pivot)
                    {
                        j--;
                    }

                    if (i >= j) return j;

                    float temp = Memory.MemoryGet(i);
                    Memory.MemorySet(i, Memory.MemoryGet(j));
                    Memory.MemorySet(j, temp);
                }
                return j;
            }
        }
    }
}
