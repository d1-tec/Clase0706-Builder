using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0706
{
    public class Director
    {

        public CajitaFelizBuilder Builder { get; set; }

        public Director(CajitaFelizBuilder cajitaFelizBuilder)
        {
            this.Builder = cajitaFelizBuilder;
        }

        public void Construct()
        {
            this.Builder.BuildBebida();
            this.Builder.BuildComida();
            this.Builder.BuildJuguete();
        }
    }
}
