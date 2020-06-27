using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace FlyweightPattern
{

    interface IFlyweight
    {
        void ColocarNombre(string Nombre);
        void CalcularCosto();
        void Mostrar();
        string ObtenerNombre();
    }
}
