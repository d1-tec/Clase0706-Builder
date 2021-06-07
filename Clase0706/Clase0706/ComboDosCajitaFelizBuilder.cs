using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0706
{
    public class ComboDosCajitaFelizBuilder : CajitaFelizBuilder
    {
        private CajitaFeliz product;

        public ComboDosCajitaFelizBuilder()
        {
            this.product = new CajitaFeliz();
        }

        public override void BuildComida()
        {
            this.product.Comida = Comida.PILDORITAS;
        }

        public override void BuildJuguete()
        {
            this.product.Juguete = Juguete.LEGO;
        }

        public CajitaFeliz GetProduct()
        {
            return this.product;
        }
    }
}
