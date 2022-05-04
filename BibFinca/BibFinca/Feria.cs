using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    public class Feria
    {
        private List<Venta> ganancias;
        private List<Camion> carro;
        private int cantidadR;
        

        public Feria()
        {
            Ganancias = new List<Venta>();
            CantidadR = 0;
            Carro = new List<Camion>();
        }
        public Feria(int cantidadR)
        {
            Ganancias = new List<Venta>();
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
                cantidadR = value;
            }
        }

        public List<Camion> Carro
        {
            get
            {
                return carro;
            }
            set
            {
                carro = value;
            }
        }

        public List<Venta> Ganancias { get => ganancias; set => ganancias = value; }

        public void venta_res()
        {
            float valor = 0;
            int cantidadR = 0;

            foreach(Camion i in this.carro)
            {
                cantidadR += i.Ganado.Count;

                foreach(Res j in i.Ganado)
                {
                    valor += j.Valor;
                }
            }
            
            Venta V = new Venta(cantidadR, valor);
            Ganancias.Add(V);
            //CantidadR = cantidadR;
        }
    }
}
