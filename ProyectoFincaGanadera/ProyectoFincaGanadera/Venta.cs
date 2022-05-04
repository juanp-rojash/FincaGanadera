using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    class Venta
    {
        private int cantidadR_Vendidas;
        private float valor_total;

        public Venta(int cantidadR_Vendidas, float valor_total)
        {
            CantidadR_Vendidas = cantidadR_Vendidas;
            Valor_total = valor_total;
        }

        public int CantidadR_Vendidas
        {
            get
            {
                return cantidadR_Vendidas;
            }
            set
            {
                if (value <= 0) throw new Exception("Revise la cantidad de reses vendidas");
                else cantidadR_Vendidas = value;
            }
        }
        public float Valor_total
        {
            get
            {
                return valor_total; 
            }
            set
            {
                if (value <= 0.0f) throw new Exception("Revise el valor total");
                else valor_total = value;
            }
        }
    }
}
