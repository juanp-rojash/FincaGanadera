using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    public class Finca
    {
        private List<Potrero> establo;
        private int ganadoinicial;

        public Finca()
        {
            Establo = new List<Potrero>();
            Ganadoinicial = 250;
        }

        public List<Potrero> Establo
        {
            get
            {
                return establo;
            }
            set
            {
                if (value == null) throw new Exception("Revise la lista de las reses");
                else establo = value;
            }
        }
        public int Ganadoinicial
        {
            get
            {
                return ganadoinicial;
            }
            set
            {
                if (value <= 0) throw new Exception("Revise la cantidad del ganado inicial");
                else ganadoinicial = value;
            }
        }
    }
}
