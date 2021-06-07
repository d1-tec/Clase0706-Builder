using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0706
{
    public enum Bebida
    {
        FANTA,
        COCA,
        SPRITE,
        SIN_BEBIDA
    }

    public enum Comida
    {
        HAMBURGUESA,
        NUGGETS,
        PILDORITAS
    }

    public enum Juguete
    {
        AUTITO,
        LEGO,
        PUZZLE
    }

    public class CajitaFeliz
    {
        public Bebida Bebida { get; set; } = Bebida.SIN_BEBIDA;
        public Comida Comida { get; set; }
        public Juguete Juguete { get; set; }
    }
}
