using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    class Estandar : Potrero
    {
        private int r1;
        private int r2;

        public Estandar() : base()
        {
            R1 = 0;
            R2 = 0;
            Ganado = null;
        }
        public Estandar(short capacidad, int r1, int r2) : base(capacidad)
        {
            R1 = r1;
            R2 = r2;
            Ganado = new List<Res>();
        }

        public int R1
        {
            get
            {
                return r1;
            }
            set
            {
                if (value >= 0 && value <= 6) throw new Exception("Revise la raza del potrero");
                else r1 = value;
            }
        }
        public int R2
        {
            get
            {
                return r2;
            }
            set
            {
                if (value >= 0 && value <= 6) throw new Exception("Revise la raza del potrero");
                else r2 = value;
            }
        }

        public List<Res> añadir_res(int numreses,string raza)
        {
            List<Res> nuevoganado = new List<Res>();

            Random rId = new Random();
            int id = 0;
            Random rPeso = new Random();
            float peso = 0.0f;
            Random rValor = new Random();
            float valor = 0.0f;
            string idres = "";

            for (int i=0; i<numreses; i++)
            {
                id = rId.Next(1, 1501);
                peso = rPeso.Next(800, 1201);
                valor = rValor.Next(3000000, 4000000);

                idres = raza + "-" + id.ToString(); 

                Res nueva = new Res(raza, peso, idres, valor);
                nuevoganado.Add(nueva);
            }

            return nuevoganado;
        }
        public void cambiar_potrero(Res ganado, Estandar establo)
        {

            if(establo.R1 == 0)
            {
                establo.R1 = Int16.Parse(ganado.Raza);
            }
            else if(establo.R2 == 0)
            {
                establo.R2 = Int16.Parse(ganado.Raza);
            }

            if (establo.R1 == Int16.Parse(ganado.Raza) || establo.R2 == Int16.Parse(ganado.Raza))
            {
                Ganado.Remove(ganado);
                establo.Ganado.Add(ganado);
            }
        }
    }
}
