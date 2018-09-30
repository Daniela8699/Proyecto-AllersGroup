using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_Allers_Group
{
    class Program
    {
        static void Main(string[] args)
        {

            //listo
            Controlador controlador = new Controlador();
            controlador.CargarDatosPrueba();


            controlador.generarAsociaciones();

            Console.Read();


        }
    }
}
