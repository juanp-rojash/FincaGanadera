using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    class Feria
    {
        private Venta ganancias;
        private List<Camion> carro;
        private int cantidadR;

        public Feria()
        {
            Ganancias = null;
            CantidadR = 0;
            Carro = null;
        }
        public Feria(Venta ganancias, int cantidadR)
        {
            Ganancias = ganancias;
            CantidadR = cantidadR;
            Carro = new List<Camion>();
        }

        public int CantidadR
        {
            get
            {
                return cantidadR;
            }
            set
            {
                if (value <= 0) throw new Exception("Revise la cantidad de reses en la feria");
                else cantidadR = value;
            }
        }
        public Venta Ganancias
        {
            get
            {
                return ganancias;
            }
            set
            {
                if (value == null) throw new Exception("Revise la venta");
                else ganancias = value;
            }
        }

        internal List<Camion> Carro
        {
            get
            {
                return carro;
            }
            set
            {
                if (value == null) throw new Exception("Revise la lista de los camiones");
                else carro = value;
            }
        }

        public float venta_res()
        {
            float valor = 0;
            int cantidadR = 0;

            foreach(Camion i in carro)
            {
                foreach(Res j in i.Ganado)
                {
                    valor = valor + j.Valor;
                    cantidadR++;
                }
            }

            Ganancias = new Venta(cantidadR, valor);
            CantidadR = cantidadR;

            return valor;
        }
    }
}
