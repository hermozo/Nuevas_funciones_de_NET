using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Json_NET_App
{
    public class Contact
    {
        public string Name { get; set; }
        public Adress Adress { get; set; }
        public List<Phone> Phones { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
