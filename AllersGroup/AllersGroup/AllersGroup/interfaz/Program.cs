using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AllersGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //listo
            Console.WriteLine("Introduzca el support mínimo");
            double minSup = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la confianza mínima");
            double minConf = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el tamaño de agrupaciones de productos [1;7]");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el numero de articulos frecuentes que desea");
            int numArticulos = Convert.ToInt32(Console.ReadLine());
            Controlador controlador = new Controlador(minConf, minSup);
            controlador.CargarDatos();
            controlador.estrategiaFP();
            */
            //Console.WriteLine("---------------------------------------------------------------------------------------------------------------------  \n");
            
            //Console.Read();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InterfazPrincipal());


        }
    }
}
