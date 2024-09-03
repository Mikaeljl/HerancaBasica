using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HerancaBasica { 
//classe derivada
    public class cachorro : Animal
    {
    public void Latir()
        {
            Console.WriteLine($"Esta {Nome} latindo");
        }
    }
}
