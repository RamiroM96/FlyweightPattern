using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace FlyweightPattern
{
    class CFlyweightFactory
    {
        //lista que guarda objetos que implementan la interfaz IFlyweight
        private List<IFlyweight> flyweights = new List<IFlyweight>();
        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int Adiciona(string Nombre)
        {
            //compruebo si ya existe la instancia de un determinado objeto.

            bool existe = false;
            foreach (IFlyweight f in flyweights)
            {
                if (f.ObtenerNombre() == Nombre)
                    existe = true;
            }

            if (existe)
            {
                Console.WriteLine("El objeto ya existe, no se ha agregado");
                return -1;
            }
            //caso contrario se agrega.
            else
            {
                CReceta miReceta = new CReceta();
                miReceta.ColocarNombre(Nombre);
                flyweights.Add(miReceta);
                conteo = flyweights.Count;
                return conteo - 1;
            }
        }

        public IFlyweight this[int index]
        {
            get { return flyweights[index]; }
        }
    }
}