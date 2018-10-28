using System;
using AllersGroup;
using System.Collections.Generic;
using System.Linq;

public class Arbol
    {
        public Nodo raiz;
        public int minSupportCount;

        public Arbol(int minSupportCount)
        {
            raiz = new Nodo();
            raiz.Count = 0;
            raiz.item = null;

            this.minSupportCount = minSupportCount;
        }


        public void crearArbol( List<string> elementos)
        {
            if (raiz.item == null)
            {
                Nodo aux = raiz;
                foreach (string element in elementos)
                {
                    Nodo Nodo = new Nodo();

                    Nodo.Count = 1;

                    aux.item = new Dictionary<string, Nodo>();
                    aux.item[element] = Nodo;
                    aux = Nodo;
                }

            }
            else
            {
                Nodo aux = raiz;
                if (aux.item != null)
                {
                    foreach (string element in elementos)
                    {
                        if (aux.item.ContainsKey(element))
                        {
                            Nodo Nodo = aux.item[element];
                            Nodo.Count = Nodo.Count + 1;
                            aux.item[element] = Nodo;
                            aux = Nodo;
                        }
                        else
                        {
                            Nodo Nodo = new Nodo();
                            Nodo.Count = 1;
                            aux.item.Add(element, Nodo);
                            aux = Nodo;
                        }
                    }
                }


            }
        }
        public List<string> generarItemsSetsFrecuentes(Nodo raiz, List<string> podaFrecuente)
        {
            foreach (KeyValuePair<string, Nodo> item in raiz.item)
            {
                if (!item.Value.Visited && item.Value.Count > minSupportCount)
                {
                    item.Value.Visited = true;
                    podaFrecuente.Add(item.Key);
                    generarItemsSetsFrecuentes(item.Value, podaFrecuente);
                }
            }
            return podaFrecuente;
        }
    }

