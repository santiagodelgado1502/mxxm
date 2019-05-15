using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3A.clases
{
    public abstract class animalcs
    {
        public abstract String hacerruido();
        public virtual void comer()
        {
            
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int peso;

        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public animalcs(String nombre, int peso, int edad)
        {
            Nombre = nombre;
            Peso = peso;
            Edad = edad;
        }
    }
}
