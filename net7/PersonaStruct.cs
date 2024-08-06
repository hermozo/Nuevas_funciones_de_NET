using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net7
{
    public struct PersonaStruct
    {
        public Guid Id;
        public string Name;
        public PersonaStruct()
        {
            Id = Guid.NewGuid();
        }
    }
}
