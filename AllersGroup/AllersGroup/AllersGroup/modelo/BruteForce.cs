using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllersGroup.modelo
{
    class BruteForce
    {
        public BruteForce()
        {
            combinacionesPorTamano = new List<List<List<int>>>();
            respuestasPorTamano = new List<List<int>>();
            suportPorTamano = new List<List<double>>();
            ConfianzaPorTamano = new List<List<double>>();

        }

        private String reporte;
        public string Reporte { get => reporte; set => reporte = value; }
        private List<List<List<int>>> combinacionesPorTamano;
        public List<List<List<int>>> CombinacionesPorTamano { get => combinacionesPorTamano; set => combinacionesPorTamano = value; }
        private List<List<int>> respuestasPorTamano;
        public List<List<int>> RespuestasPorTamano { get => respuestasPorTamano; set => respuestasPorTamano = value; }
        private List<List<double>> suportPorTamano;
        public List<List<double>> SuportPorTamano { get => suportPorTamano; set => suportPorTamano = value; }
        private List<List<double>> confianzaPorTamano;
        public List<List<double>> ConfianzaPorTamano { get => confianzaPorTamano; set => confianzaPorTamano = value; }

        public void generarAsociaciones(int tamanho, int[] darItemCode, List<Venta> ventas, double minSuport, double minConf)
        {
            int numVentas = ventas.GroupBy(n => n.DocNum).Count();
            for (int i = 0; i < tamanho; i++)
            {
                List<List<int>> combinacion = new List<List<int>>();
                combinacionesPorTamano.Add(CombinacionHasta7(i + 1, darItemCode));
            }



            foreach (var a in combinacionesPorTamano)
            {
                List<int> respuestasTamano = RepeticionEnVentas(a, ventas);
                respuestasPorTamano.Add(respuestasTamano);
            }



            //Generar soporte
            int loop = 0;
            foreach (var a in combinacionesPorTamano)
            {
                List<double> respuestasTamano = soporteAsociaciones(a, loop,numVentas);
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


            imprimirPorCriterio(minSuport, minConf, CombinacionesPorTamano);


        }
        public void imprimirPorCriterio(double suport, double confianza, List<List<List<int>>> asociaciones)
        {
            reporte += "Las asociaciones que cumplen con ambos criterios serian : \n \n";
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
                    reporte += "Para combinaciones de " + (loop + 1) + " elementos \n \n";
                    int loop1 = 0;
                    foreach (var e in a)
                    {
                        //ImprimirCombinaciones(e);

                        double resSuport = suportPorTamano.ElementAt(loop).ElementAt(loop1);
                        double resConfianza = confianzaPorTamano.ElementAt(loop).ElementAt(loop1);
                        //Console.WriteLine(resConfianza);

                        if (resSuport >= suport)
                        {
                            reporte += ImprimirCombinaciones(e);
                            reporte += "Con un Support: " + (resSuport * 100) + "% \nCon una Confianza: " + (resConfianza * 100) + "% \n \n";
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
                    reporte += "---------------------------------------------------------------------------------------------------------------------- \n";
                    reporte += "El maximo para combinaciones de " + (loop + 1) + " elementos es: \n";
                    if (maxId1 != -1 && maxId2 != -1)
                    {
                        reporte += ImprimirCombinaciones(combinacionesPorTamano.ElementAt(maxId1).ElementAt(maxId2));
                        reporte += "Con un Support: " + (maxS * 100) + "% \nCon una Confianza: " + (maxC * 100) + "% \n \n";
                        reporte += "---------------------------------------------------------------------------------------------------------------------  \n";
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
        public List<double> soporteAsociaciones(List<List<int>> todo, int indice, int numVentas)
        {
            List<double> resultados = new List<double>();
            int loop = 0;
            foreach (var combinaciones in todo)
            {
                double respuesta = (double)(respuestasPorTamano.ElementAt(indice).ElementAt(loop)) / (numVentas);
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


        public List<int> RepeticionEnVentas(List<List<int>> todo, List<Venta> ventas)
        {
            List<int> resultados = new List<int>();
            foreach (var combinaciones in todo)
            {
                resultados.Add(RepeticionEnVentasUnitario(combinaciones,ventas));
            }
            return resultados;
        }
        public int RepeticionEnVentasUnitario(List<int> todo, List<Venta> ventas)
        {
            int countaux = 0;
            int count = 0;
            int tamanho = todo.Count();
            var x = ventas.GroupBy(n => n.DocNum);

            foreach (var m in x)
            {
                if (m.Count() >= tamanho)
                {
                    countaux = 0;
                    foreach (var k in m)
                    {
                        if (todo.Contains(Convert.ToInt32(k.ItemCode)))
                        {
                            countaux++;
                        }
                    }
                    if (countaux == tamanho)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        //Método supremamente extenso.
        public List<List<int>> CombinacionHasta7(int tamanhoGrupo, int[] code)
        {
            List<List<int>> resultado = new List<List<int>>();
            if (tamanhoGrupo <= 0 || code.Length < tamanhoGrupo)
            {
                reporte += "No se puede realizar esta operación";
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

    }
}
