using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0706
{
    public class ComboUnoCajitaFelizBuilder : CajitaFelizBuilder
    {
        private CajitaFeliz product;

        public ComboUnoCajitaFelizBuilder()
        {
            this.product = new CajitaFeliz();
        }

        public override void BuildBebida()
        {
            this.product.Bebida = Bebida.FANTA;
        }

        public override void BuildComida()
        {
            this.product.Comida = Comida.HAMBURGUESA;
        }

        public override void BuildJuguete()
        {
            this.product.Juguete = Juguete.AUTITO;
        }

        public CajitaFeliz GetProduct()
        {
            return this.product;
        }

    }
}
