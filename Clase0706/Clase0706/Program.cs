using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0706
{
    class Program
    {
        static void Main(string[] args)
        {
            ComboUnoCajitaFelizBuilder builderComboUno = new ComboUnoCajitaFelizBuilder();
            ComboDosCajitaFelizBuilder builderComboDos = new ComboDosCajitaFelizBuilder();
            Director director = new Director(builderComboUno);
            director.Construct();
            CajitaFeliz cajitaFelizUno = builderComboUno.GetProduct();
            director.Builder = builderComboDos;
            CajitaFeliz cajitaFelizDos = builderComboDos.GetProduct();
        }
    }
}
