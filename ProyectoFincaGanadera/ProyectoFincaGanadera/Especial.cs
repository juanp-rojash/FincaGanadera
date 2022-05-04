using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    class Especial : Potrero
    {
        private List<Camion> carro; 
        public Especial():base()
        {
            Ganado = null;
            Capacidad = 0;
            Carro = null;
        }

        public Especial(short capacidad) : base(capacidad)
        {
            Ganado = new List<Res>();
            Capacidad = capacidad;
            Carro = new List<Camion>();
        }

        public List<Camion> Carro { get => carro; set => carro = value; }

        public void cantidad_camiones()
        {
            float peso = 0.0f;

            foreach(Res i in Ganado)
            {
                peso = peso + i.Peso;

                if(peso >= 5800)
                {
                    Camion c = new Camion(6000.0f, peso);
                    Carro.Add(c);
                    peso = 0.0f;
                }
            }
        }
    }
}
