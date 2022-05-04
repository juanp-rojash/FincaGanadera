using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFincaGanadera
{
    public class Res
    {
        private string raza;
        private bool vacuna;
        private float peso;
        private string id;
        private float valor;

        public Res()
        {
            this.raza = "";
            Vacuna = false;
            this.peso = 0;
            Id = "";
            Valor = 0;
        }
        public Res(string raza, float peso, string id, float valor)
        {
            this.raza = raza;
            Vacuna = false;
            this.peso = peso;
            Id = id;
            Valor = valor;
        }

        public string Raza
        {
            get
            {
                return raza;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new Exception("Revise la raza de la res");
                else raza = value;
            }
        }
        public bool Vacuna
        {
            get
            {
                return vacuna;
            }
            set
            {
                if (value == false) throw new Exception("Revise la vacunacion del res");
                else vacuna = value;
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
                if (value <= 0.0f) throw new Exception("Revise el peso de la res");
                else peso = value;
            }
        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new Exception("Revise el id de la res");
                else id = value;
            }
        }
        public float Valor
        {
            get
            {
                return valor;
            }
            set
            {
                if (value <= 0.0f) throw new Exception("Revise el valor de la res");
                else valor = value;
            }
        }

        public void vacunar(Res res)
        {
            res.Id = "V-" + res.Id;
        }
    }
}
