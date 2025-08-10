using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_nro1
{
    internal class Telefono
    {
        //Constructor
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        //Fin construcotr

        //Atributos
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;
        //Fin atributos

        //Propiedades
        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value >= 1 && value <= 3)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }
        //Fin propiedades

        //Metodos
        public string Llamar()
        {
            return "Realizando llamada...";
        }
        //Sobrecarga de metodo
        public string Llamar(string contacto)
        {
            return "Realizando llamada a " + contacto + " ...";
        }
        //Fin metodos
    }
}
