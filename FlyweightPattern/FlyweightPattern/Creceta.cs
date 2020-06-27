using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace FlyweightPattern
{
    class CReceta : IFlyweight
    {
        private string nombre;  //estado intrinseco 
        private double costo;
        private double venta;   // estado extrinseco


        public void ColocarNombre(string Nombre)
        {
            nombre = Nombre;
        }

        public void CalcularCosto()
        {
            //a modo de ejemplo el calculo de costo surge de la suma de el codigo ASCII de cada una de las letras del nombre * un valor determinado.
            foreach (char letra in nombre)
                costo += (int)letra;

            venta = costo * 0.05;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} cuesta {1}", nombre, venta);
        }

        public string ObtenerNombre()
        {
            return nombre;
        }



    }
}