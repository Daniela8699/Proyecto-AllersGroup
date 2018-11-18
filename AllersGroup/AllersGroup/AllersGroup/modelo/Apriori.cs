using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllersGroup.modelo
{
    class Apriori
    {
        private String reporte;
        private double minCon;
        private double minSup;
        private String asociaciones;
        private List<List<int>> implicantes;
        private List<List<int>> implicados;
        private List<List<int>> completas;
        public string Reporte { get => reporte; set => reporte = value; }
        public double MinCon { get => minCon; set => minCon = value; }
        public double MinSup { get => minSup; set => minSup = value; }
        public string Asociaciones { get => asociaciones; set => asociaciones = value; }
        public List<List<int>> Implicantes { get => implicantes; set => implicantes = value; }
        public List<List<int>> Implicados { get => implicados; set => implicados = value; }
        public List<List<int>> Completas { get => completas; set => completas = value; }

        public Apriori(double minCon, double minSup)
        {
            this.minCon = minCon;
            this.minSup = minSup;
            implicantes = new List<List<int>>();
            implicados = new List<List<int>>();
            completas = new List<List<int>>();
        }

        public void Generar(int tamanho, List<Venta> ventas, int[] darItemCode)
        {
            int numVentas = ventas.GroupBy(n => n.DocNum).Count();
            reporte += "Tamaño =  " + tamanho + "\n";
            int supCount = (int)(minSup * numVentas);
            reporte += "Num Ventas = " + numVentas + "\n";
            reporte += "SupCount = " + supCount + "\n \n";
            int i = 1;
            List<List<int>> temp = new List<List<int>>();

            int[] poda = darItemCode;
            while (i <= tamanho)
            {
                List<List<int>> combinacion = CombinacionHasta7(i, poda);
                List<int> repeticiones = RepeticionEnVentas(combinacion, ventas);
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
            reporte += "Utilizando el método apriori \n \nLas combinaciones de " + tamanho + " elementos que cumplen con el Support Count definido son: \n";
            temp.ForEach(n => reporte += ImprimirCombinaciones(n));

            reporte += "Generación de reglas: \n";
            List<List<List<int>>> reglas = new List<List<List<int>>>();
            foreach (var n in temp)
            {
                List<List<int>> combinacion = AprioriGenRules(n, ventas, numVentas);
                if (combinacion == null)
                {
                    reporte += "No se pueden generar reglas no triviales con grupos de 1 elemento \n";
                }
                else if (combinacion.Count() != 0)
                {
                    reglas.Add(combinacion);
                }

            }

            if (reglas.Count() == 0)
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
                foreach (var x in n)
                {
                    if (!codigo.Contains(x))
                    {
                        codigo.Add(x);
                    }
                }

            }
            return codigo.OrderBy(n => n).ToArray();
        }

        public List<List<int>> AprioriGenRules(List<int> combinacion, List<Venta> ventas, int numVentas)
        {
            int[] indices = combinacion.ToArray();
            List<List<int>> respuestas = new List<List<int>>();
            if (indices.Length >= 2)
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
                    temp = RecursionAprioriGenRules(temp, indices[i], ventas, numVentas);
                    if (temp != null)
                    {

                        respuestas.Add(temp);
                    }

                }
                return respuestas;
            }
            return null;

        }
        public List<int> RecursionAprioriGenRules(List<int> temporal, int generar, List<Venta> ventas, int numVentas)
        {
            double countPequeña = (double)RepeticionEnVentasUnitario(temporal, ventas) / numVentas;
            temporal.Add(generar);
            double countGrande = (double)RepeticionEnVentasUnitario(temporal, ventas) / numVentas;

            double conf = countGrande / countPequeña;
            if (conf >= minCon)
            {
                return temporal;
            }
            else
            {
                return null;
            }

        }
        public void ImprimirAsociaciones(List<List<int>> asociaciones)
        {
            String mensaje = "---------------------------------------------------------------------------------- \n";
            List<int> izquierdo = new List<int>();
            List<int> temp = new List<int>();
            List<int> derecho = new List<int>();
            asociaciones.ElementAt(0).ForEach(n => temp.Add(n));
            if (asociaciones.Count == temp.Count)
            {
                mensaje += "Completa \n " + AsociacionCompleta(temp) + "\n";
                completas.Add(temp);
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

                foreach (var n in derecho)
                {
                    mensaje += n + " ";
                }
            }
            implicantes.Add(izquierdo);
            implicados.Add(derecho);

            reporte += mensaje + "\n";
            Asociaciones = mensaje + "\n";
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
                for (int j = 0; j < indices.Length; j++)
                {
                    if (i != j)
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

        public List<int> RepeticionEnVentas(List<List<int>> todo, List<Venta> ventas)
        {
            List<int> resultados = new List<int>();
            foreach (var combinaciones in todo)
            {
                resultados.Add(RepeticionEnVentasUnitario(combinaciones, ventas));
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
    }
}
