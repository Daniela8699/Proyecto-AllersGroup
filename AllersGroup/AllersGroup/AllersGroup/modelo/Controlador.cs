﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AllersGroup
{
    public class Controlador
    {
        public String reporte = "";

        public const String rutaArticulos = "../../Data/Articulos.csv";
        public const String rutaClientes = "../../Data/Clientes.csv";
        public const String rutaVentas = "../../Data/Ventas.csv";

        public const String rutaArticulosPrueba = "../../DatosPrueba/Articulos.csv";
        public const String rutaClientesPrueba = "../../DatosPrueba/Clientes.csv";
        public const String rutaVentasPrueba = "../../DatosPrueba/Ventas.csv";


        private List<Articulo> articulos;
        private List<Cliente> clientes;
        private List<Venta> ventas;
        public double minSuport = 0;
        public double minCon = 0;



        List<List<Articulo>> combinaciones;

        public List<Articulo> Articulos { get => articulos; set => articulos = value; }
        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public List<Venta> Ventas { get => ventas; set => ventas = value; }

        public Controlador(double minConf, double minSup)
        {
            articulos = new List<Articulo>();
            clientes = new List<Cliente>();
            ventas = new List<Venta>();
            combinaciones = new List<List<Articulo>>();
            combinacionesPorTamano = new List<List<List<int>>>();
            respuestasPorTamano = new List<List<int>>();
            suportPorTamano = new List<List<double>>();
            ConfianzaPorTamano = new List<List<double>>();
            minCon = minConf;
            minSuport = minSup;

        }

        public void CargarDatos()
        {
            CargarArticulos();
            CargarClientes();
            CargarVentas(rutaVentas);
        }

        public void CargarDatosPrueba()
        {
            CargarArticulos();
            CargarClientes();
            CargarVentas(rutaVentasPrueba);
        }
        public int getNumVentas()
        {
            return ventas.GroupBy(a => a.DocNum).Count();
        }
        public int getNumArticulos()
        {
            return articulos.Count();
        }

        public void CargarArticulos()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(rutaArticulos);
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    String[] todo = line.Split(';');
                    if (todo.Length == 3 && !todo.ToList().Any(r => r.Equals("")))
                    {
                        int itemCode = Int16.Parse(todo[0]);
                        String itemName = todo[1];
                        String itemClasification = todo[2];
                        articulos.Add(new Articulo(itemCode, itemName, itemClasification));
                    }

                }
                sr.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al cargar los articulos");
            }
        }
        public void CargarClientes()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(rutaClientes);
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    String[] todo = line.Split(';');
                    if (todo.Length == 5 && !todo.ToList().Any(r => r.Equals("")))
                    {
                        String cardCode = todo[0];
                        String groupName = todo[1];
                        String city = todo[2];
                        String department = todo[3];
                        String paymentGroup = todo[4];
                        clientes.Add(new Cliente(cardCode, groupName, city, department, paymentGroup));
                    }
                }
                sr.Close();
            }
            catch
            {
                throw new Exception("Error al cargar los Clientes");
            }
        }
        public void CargarVentas(String ruta)
        {
            String line;
            string uno = "";
            string dos = "";
            string tres = "";
            try
            {

                StreamReader sr = new StreamReader(ruta);
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    String[] todo = line.Split(';');
                    if (todo.Length == 8 && !todo.ToList().Any(r => r.Equals("")))
                    {
                        String cardCode = todo[0];
                        String docNum = todo[1];
                        String[] tiempo = todo[2].Split('/');
                        int ano = Convert.ToInt32(tiempo[2]);
                        int mes = Convert.ToInt32(tiempo[1]);
                        int dia = Convert.ToInt32(tiempo[0]);
                        DateTime docDate = new DateTime(ano, mes, dia);

                        String docTotal = todo[3];
                        String itemCode = todo[4];
                        uno = todo[5];
                        dos = todo[6];
                        tres = todo[7];
                        int cantidad = Convert.ToInt32(todo[5]);
                        int precio = Convert.ToInt32(todo[6]);
                        double totalVenta = Convert.ToInt64(todo[7]);
                        ventas.Add(new Venta(cardCode, docNum, docDate, docTotal, itemCode, cantidad, precio, totalVenta));
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al cargar las Ventas");
            }
        }
        public String ImprimirCombinaciones(List<int> n)
        {
            String mensaje = "";
            String temp = "";
            int tamanho = n.Count();
            for (int i = 0; i < tamanho; i++)
            {

                int x = n.ElementAt(i);
                //if (x == 1) temp = "Bread";
                //else if (x == 2) temp = "Milk";
                //else if (x == 3) temp = "Diapers";
                //else if (x == 4) temp = "Beer";
                //else if (x == 5) temp = "Eggs";
                //else if (x == 6) temp = "Cola";
                temp += x;
                mensaje += (i + 1) + ". " + temp + "\n";
                temp = "";
                if (i == tamanho - 1)
                {
                    mensaje += "\n";
                }
            }
            return mensaje;

        }
        //Método supremamente extenso.
        public List<List<int>> CombinacionHasta7(int tamanhoGrupo, int[] code)
        {
            List<List<int>> resultado = new List<List<int>>();
            if (tamanhoGrupo <= 0 || code.Length < tamanhoGrupo)
            {
               reporte+="No se puede realizar esta operación";
            }
            else
            {
                bool c2 = false;
                bool c3 = false;
                bool c4 = false;
                bool c5 = false;
                bool c6 = false;
                bool c7 = false;
                if (tamanhoGrupo == 2)
                {
                    c2 = true;
                }
                else if (tamanhoGrupo == 3)
                {
                    c2 = true;
                    c3 = true;
                }
                else if (tamanhoGrupo == 4)
                {
                    c2 = true;
                    c3 = true;
                    c4 = true;
                }
                else if (tamanhoGrupo == 5)
                {
                    c2 = true;
                    c3 = true;
                    c4 = true;
                    c5 = true;
                }
                else if (tamanhoGrupo == 6)
                {
                    c2 = true;
                    c3 = true;
                    c4 = true;
                    c5 = true;
                    c6 = true;
                }
                else if (tamanhoGrupo == 7)
                {
                    c2 = true;
                    c3 = true;
                    c4 = true;
                    c5 = true;
                    c6 = true;
                    c7 = true;

                }
                for (int i = 0; i < code.Length; i++)
                {
                    if (c2 == false)
                    {
                        List<int> combinacion = new List<int>();
                        combinacion.Add(code[i]);
                        resultado.Add(combinacion);
                    }
                    for (int j = i + 1; j < code.Length && c2; j++)
                    {
                        if (c3 == false)
                        {
                            List<int> combinacion = new List<int>();
                            combinacion.Add(code[i]);
                            combinacion.Add(code[j]);
                            resultado.Add(combinacion);
                        }
                        for (int k = j + 1; k < code.Length && c3; k++)
                        {
                            if (c4 == false)
                            {
                                List<int> combinacion = new List<int>();
                                combinacion.Add(code[i]);
                                combinacion.Add(code[j]);
                                combinacion.Add(code[k]);
                                resultado.Add(combinacion);
                            }
                            for (int l = k + 1; l < code.Length && c4; l++)
                            {
                                if (c5 == false)
                                {
                                    List<int> combinacion = new List<int>();
                                    combinacion.Add(code[i]);
                                    combinacion.Add(code[j]);
                                    combinacion.Add(code[k]);
                                    combinacion.Add(code[l]);
                                    resultado.Add(combinacion);
                                }
                                for (int m = l + 1; m < code.Length && c5; m++)
                                {
                                    if (c6 == false)
                                    {
                                        List<int> combinacion = new List<int>();
                                        combinacion.Add(code[i]);
                                        combinacion.Add(code[j]);
                                        combinacion.Add(code[k]);
                                        combinacion.Add(code[l]);
                                        combinacion.Add(code[m]);
                                        resultado.Add(combinacion);
                                    }
                                    for (int n = m + 1; n < code.Length && c6; n++)
                                    {
                                        if (c7 == false)
                                        {
                                            List<int> combinacion = new List<int>();
                                            combinacion.Add(code[i]);
                                            combinacion.Add(code[j]);
                                            combinacion.Add(code[k]);
                                            combinacion.Add(code[l]);
                                            combinacion.Add(code[m]);
                                            combinacion.Add(code[n]);
                                            resultado.Add(combinacion);
                                        }
                                        for (int o = n + 1; o < code.Length && c7; o++)
                                        {
                                            List<int> combinacion = new List<int>();
                                            combinacion.Add(code[i]);
                                            combinacion.Add(code[j]);
                                            combinacion.Add(code[k]);
                                            combinacion.Add(code[l]);
                                            combinacion.Add(code[m]);
                                            combinacion.Add(code[n]);
                                            combinacion.Add(code[o]);
                                            resultado.Add(combinacion);
                                        }

                                    }

                                }

                            }

                        }

                    }
                }

            }

            return resultado;
        }


        public int[] masFrecuentesMetodo(int num)
        {
            int[] respuesta = new int[num];
            Dictionary<string, int> apariciones = new Dictionary<string, int>();
            foreach (var a in ventas)
            {
                if (!apariciones.ContainsKey(a.ItemCode))
                {
                    apariciones.Add(a.ItemCode, 0);
                }
                else
                {
                    apariciones[a.ItemCode] = apariciones[a.ItemCode] + 1;
                }

            }
            int[] respuestas = apariciones.Values.ToArray();
            Organizar(respuestas);
            for (int i = 0; i < num; i++)
            {
                String Key = apariciones.FirstOrDefault(x => x.Value == respuestas[i]).Key;
                respuesta[i] = Convert.ToInt32(Key);
                apariciones[Key] = -1;
            }
            return respuesta;
        }

        public void Organizar(int[] A)
        {
            QuickSort(A, 0, A.Length - 1);
        }

        public void QuickSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(A, p, r);
                QuickSort(A, p, q - 1);
                QuickSort(A, q + 1, r);
            }
        }

        private int Partition(int[] A, int p, int r)
        {
            int x = A[r];
            int temp;

            int i = p;
            for (int j = p; j < r; j++)
            {
                if (A[j] >= x)
                {
                    temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;
                    i++;
                }
            }

            A[r] = A[i];
            A[i] = x;
            return i;
        }

        //APLICACIÓN DE ESTRATEGIA DE FUERZA BRUTA***************


        private List<List<List<int>>> combinacionesPorTamano;
        public List<List<List<int>>> CombinacionesPorTamano { get => combinacionesPorTamano; set => combinacionesPorTamano = value; }
        private List<List<int>> respuestasPorTamano;
        public List<List<int>> RespuestasPorTamano { get => respuestasPorTamano; set => respuestasPorTamano = value; }
        private List<List<double>> suportPorTamano;
        public List<List<double>> SuportPorTamano { get => suportPorTamano; set => suportPorTamano = value; }
        private List<List<double>> confianzaPorTamano;
        public List<List<double>> ConfianzaPorTamano { get => confianzaPorTamano; set => confianzaPorTamano = value; }



        public void generarAsociaciones(int tamanho, int numArti)
        {
            //int numArticulos = getNumArticulos();
           
            //List<int> darItemCode = new List<int>();
            //articulos.ForEach(a=> darItemCode.Add(a.ItemCode));


            int[] darItemCode = masFrecuentesMetodo(numArti);
           

            for (int i = 0; i < tamanho; i++)
            {
                List<List<int>> combinacion = new List<List<int>>();
                combinacionesPorTamano.Add(CombinacionHasta7(i + 1, darItemCode));
            }

            foreach (var a in combinacionesPorTamano)
            {
                List<int> respuestasTamano = RepeticionEnVentas(a);
                respuestasPorTamano.Add(respuestasTamano);
            }



            //Generar soporte
            int loop = 0;
            foreach (var a in combinacionesPorTamano)
            {
                List<double> respuestasTamano = soporteAsociaciones(a, loop);
                SuportPorTamano.Add(respuestasTamano);
                loop++;
            }


            //Generar confianza
            int loop2 = 0;
            foreach (var a in combinacionesPorTamano)
            {
                List<double> respuestasTamano = new List<double>();
                if (loop2 != 0)
                {
                    respuestasTamano = confianzaAsociaciones(a, loop2);
                }
                confianzaPorTamano.Add(respuestasTamano);
                loop2++;
            }

            //Imprimir asociaciones que cumplen con el minimo


            imprimirPorCriterio(minSuport, minCon, CombinacionesPorTamano);


        }
        public void imprimirPorCriterio(double suport, double confianza, List<List<List<int>>> asociaciones)
        {
            reporte+= "Las asociaciones que cumplen con ambos criterios serian : \n \n";
            int loop = 0;
            double maxS = -1;
            double maxC = -1;
            int maxId1 = -1;
            int maxId2 = -1;
            List<List<int>> cumplen = new List<List<int>>();

            foreach (var a in combinacionesPorTamano)
            {
                if (loop != 0)
                {
                    reporte+= "Para combinaciones de " + (loop + 1) + " elementos \n \n";
                    int loop1 = 0;
                    foreach (var e in a)
                    {
                        //ImprimirCombinaciones(e);

                        double resSuport = suportPorTamano.ElementAt(loop).ElementAt(loop1);
                        double resConfianza = confianzaPorTamano.ElementAt(loop).ElementAt(loop1);
                        //Console.WriteLine(resConfianza);

                        if (resSuport >= suport)
                        {
                            reporte+= ImprimirCombinaciones(e);
                            reporte+= "Con un Support: " + (resSuport * 100) + "% \nCon una Confianza: " + (resConfianza * 100) + "% \n \n";
                            if (maxS < resSuport && maxC < resConfianza)
                            {
                                maxS = resSuport;
                                maxC = resConfianza;
                                maxId1 = loop;
                                maxId2 = loop1;
                            }
                        }
                        loop1++;
                    }
                    reporte+= "---------------------------------------------------------------------------------------------------------------------- \n";
                    reporte+= "El maximo para combinaciones de " + (loop + 1) + " elementos es: \n";
                    if (maxId1 != -1 && maxId2 != -1)
                    {
                        reporte += ImprimirCombinaciones(combinacionesPorTamano.ElementAt(maxId1).ElementAt(maxId2));
                        reporte+= "Con un Support: " + (maxS * 100) + "% \nCon una Confianza: " + (maxC * 100) + "% \n \n";
                        reporte+="---------------------------------------------------------------------------------------------------------------------  \n";
                        maxS = -1;
                        maxC = -1;
                        maxId1 = -1;
                        maxId2 = -1;
                        //0iujmpim
                    }

                }
                loop++;
            }

        }
        public List<double> soporteAsociaciones(List<List<int>> todo, int indice)
        {
            List<double> resultados = new List<double>();
            int loop = 0;
            foreach (var combinaciones in todo)
            {

                //ImprimirCombinaciones(combinaciones);
                //Console.WriteLine(respuestasPorTamano.ElementAt(indice).ElementAt(loop));
                //Console.WriteLine(RepeticionEnVentasUnitario(combinaciones));
                double respuesta = (double)(respuestasPorTamano.ElementAt(indice).ElementAt(loop)) / (getNumVentas());
                resultados.Add(respuesta);
                //Console.WriteLine(respuesta);

                loop++;
            }
            return resultados;
        }

        public List<double> confianzaAsociaciones(List<List<int>> todo, int indice)
        {
            List<double> resultados = new List<double>();
            int loop = 0;
            foreach (var combinaciones in todo)
            {
                //ImprimirCombinaciones(combinaciones);
                List<int> ayuda = new List<int>();
                for (int i = 0; i < combinaciones.Count() - 1; i++)
                {
                    ayuda.Add(combinaciones.ElementAt(i));
                }

                double respuestaGrande = suportPorTamano.ElementAt(indice).ElementAt(loop);
                //Console.WriteLine(respuestaGrande);
                double respuestaPeque = suportPorTamano.ElementAt(indice - 1).ElementAt(buscarIndiceRespuesta(indice - 1, ayuda));
                double respuesta = 0;
                //Console.WriteLine(respuestaPeque);
                if (respuestaPeque != 0)
                {
                    respuesta = (double)(respuestaGrande) / (respuestaPeque);
                }
                resultados.Add(respuesta);
                //Console.WriteLine(respuesta);
                loop++;
            }
            return resultados;
        }

        public int buscarIndiceRespuesta(int indice, List<int> relacion)

        {
            //ImprimirCombinaciones(relacion);
            int tamanho = combinacionesPorTamano.ElementAt(indice).Count();
            int loop = -1;
            bool control = false;
            for (int i = 0; i < tamanho && !control; i++)
            {
                List<int> temp = combinacionesPorTamano.ElementAt(indice).ElementAt(i);
                // ImprimirCombinaciones(temp);
                int count = 0;
                for (int j = 0; j < temp.Count() && !control; j++)
                {
                    if (relacion.ElementAt(j) == temp.ElementAt(j))
                    {

                        count++;
                    }
                }
                if (count == temp.Count())
                {
                    //Console.WriteLine(true);
                    //Console.WriteLine(i);
                    loop = i;
                    control = true;
                }
            }

            return loop;

        }


        public List<int> RepeticionEnVentas(List<List<int>> todo)
        {
            List<int> resultados = new List<int>();
            foreach (var combinaciones in todo)
            {
                resultados.Add(RepeticionEnVentasUnitario(combinaciones));
            }
            return resultados;
        }
        public List<string> darCardCodes()
        {
            List<string> resul = new List<string>();

            for (int i = 0; i < ventas.Count; i++)
            {
                if (!resul.Contains(ventas[i].CardCode))
                {
                    resul.Add(ventas[i].CardCode);
                }
            }

            return resul;
        }
        public int RepeticionEnVentasUnitario(List<int> todo)
        {
            int countaux = 0;
            int count = 0;
            int tamanho = todo.Count();
            var x = ventas.GroupBy(n => n.DocNum);
            
            foreach (var m in x)
            {
                if(m.Count() >= tamanho)
                {
                    countaux = 0;
                    foreach (var k in m)
                    {
                        if (todo.Contains(Convert.ToInt32(k.ItemCode)))
                        {
                            countaux++;
                        }
                    }
                    if(countaux == tamanho)
                    {
                        count++;
                    }
                }
            }
            return count;
       

        }
        //FIN APLICACION ESTRATEGIA DE FUERZA BRUTA *************

        // APLICACIÓN ESTRATEGIA A-PRIORI *****************
        public void Apriori(int tamanho, int numArti)
        {
            reporte+= "Tamaño =  " + tamanho + "\n";
            int supCount = (int) (minSuport * getNumVentas());
            reporte+= "Num Ventas = " + getNumVentas() + "\n";
            reporte+= "SupCount = " + supCount + "\n \n";
            int i = 1;
            List<List<int>> temp = new List<List<int>>();

            int[] darItemCode = masFrecuentesMetodo(numArti);
            int[] poda = darItemCode;
            while (i <= tamanho)
            {
               List<List<int>> combinacion = CombinacionHasta7(i, poda);
               List<int> repeticiones = RepeticionEnVentas(combinacion);
                int temp2 = repeticiones.Count();
                for (int x = 0; x < temp2; x++)
                {
                    if(repeticiones.ElementAt(x) >= supCount)
                    {
                        temp.Add(combinacion.ElementAt(x));
                    }
                }
                if(tamanho == i)
                {
                    break;
                }
                else
                {
                    poda = refrescarItemCodes(temp);
                    temp = new List<List<int>>();
                    i++;

                }
            }
            reporte+= "Utilizando el método apriori \n \nLas combinaciones de " + tamanho + " elementos que cumplen con el Support Count definido son: \n";
            temp.ForEach(n => reporte += ImprimirCombinaciones(n));

            reporte+="Generación de reglas: \n";
            List<List<List<int>>> reglas = new List<List<List<int>>>();
            foreach (var n in temp)
            {
                List<List<int>> combinacion = AprioriGenRules(n);
                if(combinacion == null)
                {
                    reporte += "No se pueden generar reglas no triviales con grupos de 1 elemento \n";
                }
                else if(combinacion.Count() != 0)
                {
                    reglas.Add(combinacion);
                }
                
            }

            if(reglas.Count() == 0)
            {
               reporte += "No existe ninguna regla que cumpla con el criterio de confianza\n";
            }
            else
            {
                reglas.ForEach(s => ImprimirAsociaciones(s));
            }


            

        }
        public int[] refrescarItemCodes(List<List<int>> combinaciones)
        {
            List<int> codigo = new List<int>();
            foreach (var n in combinaciones)
            {
                foreach(var x in n)
                {
                    if (!codigo.Contains(x))
                    {
                        codigo.Add(x);
                    }
                }

            }
            return codigo.OrderBy(n => n).ToArray();
        }

        public List<List<int>> AprioriGenRules(List<int> combinacion)
        {
            int[] indices = combinacion.ToArray();
            List<List<int>> respuestas = new List<List<int>>();
            if(indices.Length >= 2)
            {
                for (int i = 0; i < indices.Length; i++)
                {
                    List<int> temp = new List<int>();
                    for (int j = 0; j < indices.Length; j++)
                    {
                        if (i != j)
                        {
                            temp.Add(indices[j]);
                        }
                    }
                    temp = RecursionAprioriGenRules(temp, indices[i]);
                    if(temp != null)
                    {

                        respuestas.Add(temp);
                    }

               }
                return respuestas;
            }
            return null;

        }
        public List<int> RecursionAprioriGenRules(List<int> temporal, int generar)
        {
            double countPequeña = (double) RepeticionEnVentasUnitario(temporal) / getNumVentas();
            temporal.Add(generar);
            double countGrande = (double) RepeticionEnVentasUnitario(temporal) / getNumVentas(); 

            double conf = countGrande / countPequeña;
            if(conf >= minCon)
            {
                return temporal;
            }
            else { 
                return null;
            }

        }
        public void ImprimirAsociaciones (List<List<int>> asociaciones)
        {
            String mensaje = "---------------------------------------------------------------------------------- \n";
            List<int> izquierdo = new List<int>();
            List<int> temp = new List<int>();
            List<int> derecho = new List<int>();
            asociaciones.ElementAt(0).ForEach(n => temp.Add(n));
            if(asociaciones.Count == temp.Count)
            {
                mensaje += "Completa \n " + AsociacionCompleta(temp) + "\n";
            }
            else
            {
                foreach (var n in asociaciones)
                {
                    derecho.Add(n.Last());
                }
                foreach (var n in temp)
                {
                    if (!derecho.Contains(n))
                    {
                        izquierdo.Add(n);
                    }
                }
                foreach (var n in izquierdo)
                {
                    mensaje += n + " ";

                }
                mensaje += "=> ";

                foreach(var n in derecho)
                {
                    mensaje += n + " ";
                }
            }
            reporte += mensaje + "\n";

        }
        public String AsociacionCompleta(List<int> todas)
        {
            int[] indices = todas.ToArray();
            String mensaje = "";
            String inicio = "";
            String retorno = "";
            for (int i = 0; i < indices.Length; i++)
            {
                inicio = indices[i] + " ==> ";
                for(int j = 0; j < indices.Length; j++)
                {
                    if( i != j)
                    {
                        mensaje += indices[j] + " ";
                    }
                }
                inicio += mensaje + "\n";
                retorno += inicio;
                mensaje = "";
            }

            return retorno;
        }



        // FIN APLICACIÓN ESTRATEGIA A-PRIORI *******************

        // APLICACIÓN ESTRATEGIA F(k-1)XF1   *****************

       public void FkMinus1XF1(int tamanho,int numArticulos)
        {
            reporte += "---------------------------------------------------------------------------------------------\n";
            reporte += "Método F(k-1) X F1\n";
            int[] F1 = masFrecuentesMetodo(numArticulos);
            int supCount = (int) (minSuport * getNumVentas());
            F1 = F1Check(F1, supCount);
            reporte += "supCount: " + supCount + "\n";
            List<List<int>> temp = new List<List<int>>();
            List<List<int>> temp2 = new List<List<int>>();
            List<List<int>> resultado = new List<List<int>>();
            if (tamanho >= 2)
            {
                List<List<int>> combinaciones = CombinacionHasta7(tamanho - 1, F1);
                foreach(var n in combinaciones)
                {
                    int count = RepeticionEnVentasUnitario(n);
                    if(count >= supCount)
                    {
                        temp2.Add(n);
                    }
                }

               if(temp2.Count() != 0)
                {
                    foreach (var s in temp2)
                    {
                        for(int m = 0; m < F1.Length; m++)
                        {
                            List<int> amp = new List<int>();
                            s.ForEach(c => amp.Add(c));
                            if (!s.Contains(F1[m]))
                            {
                                amp.Add(F1[m]);
                                temp.Add(amp);
                            }
                        }
                    }
                }
               if(temp.Count != 0)
                {
                    foreach (var n in temp)
                    {
                        int count = RepeticionEnVentasUnitario(n);
                        if (count >= supCount)
                        {
                            List<int> orden = n.OrderBy(l => l).ToList();
                            if(resultado.Count != 0)
                            {
                                bool repetido = CombinacionRepetida(resultado, orden);
                                if (!repetido)
                                {
                                    resultado.Add(orden);
                                }
                            }
                            else
                            {
                                resultado.Add(orden);
                            }


                        }
                    }
                }
                reporte += "Los frequent itemsets que cumplen con el support necesario son:\n";
                resultado.ForEach(t => reporte += ImprimirCombinaciones(t));

            }
            else
            {
                reporte += "Los frequent itemsets que cumplen con el support necesario son:\n";
                for(int i = 0; i < F1.Length; i++)
                {
                    List<int> uno = new List<int>();
                    uno.Add(F1[i]);
                    int count = RepeticionEnVentasUnitario(uno);
                    if(count >= supCount)
                    {
                        resultado.Add(uno);
                    }

                }

                resultado.ForEach(t => reporte += ImprimirCombinaciones(t));
            }
        }
        public bool CombinacionRepetida(List<List<int>> resultado, List<int> orden)
        {
            bool repetido = false;
            int count = 0;
            int tamanho = orden.Count();
            foreach(var m in resultado)
            {
                foreach(var n in m)
                {
                    if (orden.Contains(n)){
                        count++;
                    }
                }
                if(count == tamanho)
                {
                    repetido = true;
                    break;
                }
                else
                {
                    count = 0;
                }
                
            }
            return repetido;

        }

        public int[] F1Check(int[] masFrecuentes, int supCount)
        {
            List<int> resultado = new List<int>();
            for (int i = 0; i < masFrecuentes.Length; i++)
            {
                List < int > uno = new List<int>();
                uno.Add(masFrecuentes[i]);
                int count = RepeticionEnVentasUnitario(uno);
                if (count >= supCount) resultado.Add(masFrecuentes[i]);
            }
            return resultado.ToArray();
        }
        

        //---------------------------------------------------------------------------------------------------------------------------------------------
        //Método para UnitTest


        public int RepeticionEnVentasP(List<int> combinaciones)
        {
            int tamanho = combinaciones.Count();
            int count = 0;
            int count2 = 0;
            String mensaje = "";
            for (int i = 0; i < tamanho; i++)
            {
                mensaje += combinaciones.ElementAt(i) + " ";
            }
            var x = ventas.GroupBy(n => n.CardCode);
            foreach (var m in x)
            {
                if (m.Count() >= 7)
                {
                    count2 = 0;
                    foreach (var s in m)
                    {
                        if (combinaciones.Contains(Convert.ToInt32(s.ItemCode)))
                        {
                            count2++;
                        }
                    }
                    if (count2 == 7)
                    {
                        count++;

                    }

                }
            }
            Console.WriteLine(mensaje + "\n" + count);
            return count;
        }

        public List<List<int>> AprioriP(int tamanho, int numArti)
        {
            Console.WriteLine("Tamaño =  " + tamanho);
            int supCount = (int)(minSuport * getNumVentas());
            Console.WriteLine("Num Ventas = " + getNumVentas());
            Console.WriteLine("SupCount = " + supCount + "\n");
            int i = 1;
            List<List<int>> temp = new List<List<int>>();

            int[] darItemCode = masFrecuentesMetodo(numArti);
            int[] poda = darItemCode;
            while (i <= tamanho)
            {
                List<List<int>> combinacion = CombinacionHasta7(i, poda);
                List<int> repeticiones = RepeticionEnVentas(combinacion);
                int temp2 = repeticiones.Count();
                for (int x = 0; x < temp2; x++)
                {
                    if (repeticiones.ElementAt(x) >= supCount)
                    {
                        temp.Add(combinacion.ElementAt(x));
                    }
                }
                if (tamanho == i)
                {
                    break;
                }
                else
                {
                    poda = refrescarItemCodes(temp);
                    temp = new List<List<int>>();
                    i++;

                }
            }
            Console.WriteLine("Utilizando el método apriori \nLas combinaciones de " + tamanho + " elementos que cumplen con el Support Count definido son: \n ");
            temp.ForEach(n => ImprimirCombinaciones(n));
            return temp;
        }
        

        //------------------------------------------------------------------------------------------------------------------------------------------

       
    }
}