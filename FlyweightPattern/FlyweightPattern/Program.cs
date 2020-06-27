using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            List<int> Argentina = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Pastas = new List<int>();

            List<int> Rapida = new List<int>();

            CFlyweightFactory flywf = new CFlyweightFactory();

            i = flywf.Adiciona("Choripan");
            Argentina.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Locro");
            Argentina.Add(i);
            Pastas.Add(i);

            i = flywf.Adiciona("Puchero");
            Argentina.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Lasagna");
            Italiana.Add(i);
            Pastas.Add(i);

            i = flywf.Adiciona("spaghetti alla bolognese");
            Italiana.Add(i);
            Pastas.Add(i);

            i = flywf.Adiciona("Tacos");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Tamales");
            Mexicana.Add(i);
            Carnes.Add(i);

            i = flywf.Adiciona("Enchiladas");
            Mexicana.Add(i);
            Carnes.Add(i);

            i = flywf.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);

            // Mostramos y llevamos a cabo proceso en la comida rapida

            foreach (int n in Rapida)
            {
                CReceta receta = (CReceta)flywf[n];
                receta.CalcularCosto();
                receta.Mostrar();

            }

            Console.WriteLine("------");



            //Muestro comida argentina
            foreach (int n in Argentina)
            {
                CReceta receta = (CReceta)flywf[n];
                //receta.CalcularCosto();
                receta.Mostrar();


            }
            /*
            Console.WriteLine("------");
            
            //intento adicionar uno ya existente. 
            i = flywf.Adiciona("Pizza");
            Console.WriteLine("------");
            // muestro pastas 
            foreach(int n in Pastas)
            {
                CReceta receta = (CReceta)flywf[n];
                receta.CalcularCosto();
                receta.Mostrar();
            }
            Console.WriteLine("------");
            //muestro todas las recetas
            int m = 0; 
            for(m=0;m<flywf.Conteo;m++)
            {
                CReceta receta = (CReceta)flywf[m];
                receta.Mostrar();
            }
        */
        }
    }
}
