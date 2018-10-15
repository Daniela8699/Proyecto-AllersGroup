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
            ////listo
            //Console.WriteLine("Introduzca el support mínimo");
            //double minSup = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Introduzca la confianza mínima");
            //double minConf = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Introduzca el tamaño de agrupaciones de productos [1;7]");
            //int tamanho = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduzca el numero de articulos frecuentes que desea");
            //int numArticulos = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("---------------------------------------------------------------------------------------------------------------------  \n");

            Console.WriteLine("Empezo...");
            for (int i = 2; i < 6; i++)
            {
                StreamWriter sw = new StreamWriter("../../Data/tiempoAprioriVS"+i+".csv");
                StreamWriter sw2 = new StreamWriter("../../Data/tiempoFKVS" + i + ".csv");
                int numArticulos = 5;
                double minConf = 0.5;
                double minSup = 0.003;
                List<int> agregados = new List<int>();
                for (int a = 0; a < 50; a++)
                {
                    Controlador controlador = new Controlador(minConf, minSup);
                    controlador.CargarDatos();
                    controlador.Ventas.RemoveAll(r => agregados.Contains(Convert.ToInt32(r.ItemCode)));
                    int[] repetidos = controlador.masFrecuentesMetodo(5);
                    repetidos.ToList().ForEach(w=>agregados.Add(w));

                    Stopwatch t = Stopwatch.StartNew();
                    controlador.Apriori(i, numArticulos);
                    sw.WriteLine(t.Elapsed.TotalMilliseconds);
                    t = Stopwatch.StartNew();
                    controlador.FkMinus1XF1(i, numArticulos);
                    sw2.WriteLine(t.Elapsed.TotalMilliseconds);
                    Console.WriteLine("termino"+ a);
                }
                sw.Close();
                sw2.Close();
            }


            Console.Read();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new InterfazPrincipal());


        }
    }
}
