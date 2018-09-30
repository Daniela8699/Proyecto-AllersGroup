using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllersGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //listo
            Controlador controlador = new Controlador();
            controlador.CargarDatos();


            controlador.generarAsociaciones();

            Console.Read();

        }
    }
}
