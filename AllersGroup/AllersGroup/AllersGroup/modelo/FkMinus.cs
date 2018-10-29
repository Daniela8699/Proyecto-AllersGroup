using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllersGroup.modelo
{
    class FkMinus
    {
        private String reporte;
        private double minSuport;
        private double minCon;
        public string Reporte { get => reporte; set => reporte = value; }

        public FkMinus(double minSup, double minCon)
        {
            this.minSuport = minSup;
            this.minCon = minCon;
        }
        public void FkMinus1XF1(int tamanho, int[] F1, List<Venta> ventas)
        {
            reporte += "---------------------------------------------------------------------------------------------\n";
            reporte += "Método F(k-1) X F1\n";
            int numVentas = ventas.GroupBy(n => n.DocNum).Count();
            int supCount = (int)(minSuport * numVentas);
            F1 = F1Check(F1, supCount,ventas);
            reporte += "supCount: " + supCount + "\n";
            List<List<int>> temp = new List<List<int>>();
            List<List<int>> temp2 = new List<List<int>>();
            List<List<int>> resultado = new List<List<int>>();
            if (tamanho >= 2)
            {
                List<List<int>> combinaciones = CombinacionHasta7(tamanho - 1, F1);
                foreach (var n in combinaciones)
                {
                    int count = RepeticionEnVentasUnitario(n,ventas);
                    if (count >= supCount)
                    {
                        temp2.Add(n);
                    }
                }

                if (temp2.Count() != 0)
                {
                    foreach (var s in temp2)
                    {
                        for (int m = 0; m < F1.Length; m++)
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
                if (temp.Count != 0)
                {
                    foreach (var n in temp)
                    {
                        int count = RepeticionEnVentasUnitario(n,ventas);
                        if (count >= supCount)
                        {
                            List<int> orden = n.OrderBy(l => l).ToList();
                            if (resultado.Count != 0)
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
                for (int i = 0; i < F1.Length; i++)
                {
                    List<int> uno = new List<int>();
                    uno.Add(F1[i]);
                    int count = RepeticionEnVentasUnitario(uno, ventas);
                    if (count >= supCount)
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
            foreach (var m in resultado)
            {
                foreach (var n in m)
                {
                    if (orden.Contains(n))
                    {
                        count++;
                    }
                }
                if (count == tamanho)
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

        public int[] F1Check(int[] masFrecuentes, int supCount, List<Venta> ventas)
        {
            List<int> resultado = new List<int>();
            for (int i = 0; i < masFrecuentes.Length; i++)
            {
                List<int> uno = new List<int>();
                uno.Add(masFrecuentes[i]);
                int count = RepeticionEnVentasUnitario(uno, ventas);
                if (count >= supCount) resultado.Add(masFrecuentes[i]);
            }
            return resultado.ToArray();
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

        // FIN APLIACION ESTRATEGIA F(k-1)XF1   *****************
    }
}
