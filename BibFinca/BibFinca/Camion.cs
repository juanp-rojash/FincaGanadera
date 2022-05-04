using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    public class Camion
    {
        private List<Res> ganado;
        private float pesolimite;
        private float peso;

        public Camion()
        {
            Pesolimite = 0.0f;
            Peso = 0.0f;
            ganado = null;
        }

        public Camion(float pesolimite, float peso)
        {
            Pesolimite = pesolimite;
            Peso = peso;
            ganado = new List<Res>();
        }

        public float Pesolimite
        {
            get
            {
                return pesolimite;
            }
            set
            {
                if (value <= 0) throw new Exception("Revise el peso limite de la camioneta");
                else pesolimite = value;
            }
        }
        public float Peso
        {
            get
            {
                return peso;
            }
            set
            {
                /*if (value > 0 && value <= 6000) throw new Exception("Revise el peso de la camioneta");
                else */pesolimite = value;
            }
        }
        
        public List<Res> Ganado
        {
            get
            {
                return ganado;
            }
            set
            {
                if (value == null) throw new Exception("Revise la lista de ganado del camion");
                else ganado = value;
            }
        }
    }
}
