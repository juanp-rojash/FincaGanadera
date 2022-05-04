using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    public abstract class Potrero
    {
        List<Res> ganado;
        private short capacidad;

        public Potrero()
        {
            Ganado = null;
            Capacidad = 0;
        }
        public Potrero(short capacidad)
        {
            Ganado = new List<Res>();
            Capacidad = capacidad;
        }

        public short Capacidad { get => capacidad; set => capacidad = value; }
        public List<Res> Ganado
        {
            get
            {
                return ganado;
            }
            set
            {
                if (value == null) throw new Exception("Revise la lista del ganado");
                else ganado = value;
            }
        }
    }
}
