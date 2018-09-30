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
            Console.WriteLine("Introduzca el support mínimo");
            double minSup = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la confianza mínima");
            double minConf = Convert.ToDouble(Console.ReadLine());
            Controlador controlador = new Controlador(minSup,minConf);
            controlador.CargarDatosPrueba();


            controlador.generarAsociaciones();

            Console.Read();

        }
    }
}
