using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    public class Venta
    {
        private long cantidadR_Vendidas;
        private float valor_total;
        public string id;
        private static int referencia;

        public Venta(long cantidadR_Vendidas, float valor_total)
        {
            CantidadR_Vendidas = cantidadR_Vendidas;
            Valor_total = valor_total;
            Id = (Referencia + 1).ToString();
            Referencia++;
        }

        public long CantidadR_Vendidas
        {
            get
            {
                return cantidadR_Vendidas;
            }
            set
            {
                /*if (value <= 0) throw new Exception("Revise la cantidad de reses vendidas");
                else */cantidadR_Vendidas = value;
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
                /*if (value <= 0.0f) throw new Exception("Revise el valor total");
                else */valor_total = value;
            }
        }

        public string Id { get => id; set => id = value; }
        public static int Referencia { get => referencia; set => referencia = value; }
    }
}
