using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace net7
{
    public class FuncionesGenericas
    {
        public FuncionesGenericas()
        {
            var r = suma<int>(4, 5);
            Console.WriteLine(r);

            var d = suma<decimal>(5.12m, 80.7m);
            Console.WriteLine(d);

        }
        private static T suma<T>(T a, T b) where T : INumber<T>
        {
            return a + b;
        }
    }
}
