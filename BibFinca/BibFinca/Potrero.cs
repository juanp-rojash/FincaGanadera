using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    public abstract class Potrero
    {
        List<Res> ganado;
        private short capacidad;
        public string nombre;
        private static int numero;

        public Potrero()
        {
            Ganado = null;
            Capacidad = 0;
            nombre = "";
        }
        public Potrero(short capacidad, string nombre)
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
                /*if (value == null) throw new Exception("Revise la lista del ganado");
                else*/ ganado = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new Exception("Revise la lista del ganado");
                else nombre = value;
            }
        }
        public static int Numero { get => numero; set => numero = value; }
    }
}
