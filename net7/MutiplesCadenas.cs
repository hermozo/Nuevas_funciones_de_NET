using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net7
{
    public class MutiplesCadenas
    {
        public MutiplesCadenas()
        {
            var mensaje = """
                    Interpolacion de cadenas
                """;
            Console.WriteLine(mensaje);

            var mensajedos = $""" esta es la verion del  framework {AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName} """;

            Console.WriteLine(mensajedos);
        }
    }
}
