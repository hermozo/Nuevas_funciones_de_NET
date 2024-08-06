using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net7
{
    public class RequeridosEnClase
    {
        public required string Name { get; set; }
        public required string Descripcion { get; set; }

        [SetsRequiredMembers]
        public RequeridosEnClase(string Name, string Descripcion)
        {
            this.Name = Name;
            this.Descripcion = Descripcion;
        }
    }
}
