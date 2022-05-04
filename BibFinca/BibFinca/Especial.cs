using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    public class Especial : Potrero
    {
        private List<Camion> carro; 
        public Especial():base()
        {
            Ganado = null;
            Capacidad = 0;
            Carro = null;
            Nombre = "";
        }

        public Especial(short capacidad, string nombre) : base(capacidad, nombre)
        {
            Ganado = new List<Res>();
            Capacidad = capacidad;
            Carro = new List<Camion>();
            Nombre = nombre;
        }

        public List<Camion> Carro { get => carro; set => carro = value; }

        public void cantidad_camiones()
        {
            float peso = 0.0f;
            List<Res> R = new List<Res>();
            int contador = 0;
            int c0 = 0;

            if (Ganado.Count <= 5)
            {
                foreach (Res i in Ganado)
                {
                    peso += i.Peso;
                    R.Add(i);                    
                }
                Camion c = new Camion(6000f, peso);
                c.Ganado = R;
                Carro.Add(c);
            }
            else
            {
                Camion c;
                foreach(Res i in Ganado)
                {
                    peso += i.Peso;
                    R.Add(i);
                    contador++;
                    c0++;

                    if (contador == 5)
                    {
                        c = new Camion(6000.0f, peso);
                        c.Ganado = R;
                        this.carro.Add(c);

                        peso = 0.0f;
                        R.Clear();
                        contador = 0;
                    }
                    else if((Ganado.Count - c0) <= 4)
                    {
                        if((Ganado.Count - c0) == 0)
                        {
                            c = new Camion(6000f, peso);
                            c.Ganado = Ganado;
                            this.carro.Add(c);

                            peso = 0.0f;
                            R.Clear();
                        }                     
                    }
                } 
            }
        }
        public void cargar_camion()
        {
            this.Carro.Clear();
            float peso = 1f;
            Camion c = new Camion(6000f, peso);
            c.Ganado = this.Ganado;
            this.carro.Add(c);
        }
    }
}
