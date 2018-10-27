using System;
using AllersGroup;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FP
    {
        private int minSupportCount;

        public int MinSupportCount { get => minSupportCount; set => minSupportCount = value; }

        public FP(int minSupportCount)
        {
            this.minSupportCount = minSupportCount;
        }

        public List<List<Object>> repeticionesUnitarias(List<Venta> ventas)
        {
            List<List<Object>> itemSets = new List<List<Object>>();

            var x = ventas.GroupBy(n => n.CardCode);
            foreach (var m in x)
            {
                String[] transItems = new String[m.Count()];
                int contador = 0;
                foreach (var s in m)
                {
                    transItems[contador] = s.ItemCode;
                    contador++;
                }

                int count = 0;
                foreach (String itemName in transItems)
                {
                    string itemNameTemp = itemName.Trim();
                    Boolean agregado = false;
                    for (int i = 0; i < itemSets.Count; i++)
                    {
                        if (itemSets[i][0].ToString() == itemNameTemp)
                        {
                            int contadorDos = Convert.ToInt32(itemSets[i][1]);
                            itemSets[i][1] = ++contadorDos;
                            agregado = true;
                        }
                    }
                    if (agregado == false)
                    {
                        List<Object> nuevo = new List<Object>();
                        nuevo.Add(itemNameTemp);
                        nuevo.Add(1);
                        itemSets.Add(nuevo);
                    }
                    count++;
                }
            }
            return itemSets;
        }
        public List<List<Object>> objetosCumplen(List<List<Object>> repeticiones)
        {
            List<List<Object>> objetosCumplen = new List<List<Object>>();
            for (int count = 0; count < repeticiones.Count; count++)
            {
                if (Convert.ToInt32(repeticiones[count][1]) > minSupportCount)
                {
                    objetosCumplen.Add(repeticiones[count]);
                }
            }
            return objetosCumplen;
        }
    public void ordenarMayorMenor(List<List<Object>> poda)
    {
        List<List<Object>> ordenarMayorMenor = new List<List<Object>>();
        for (int i = 0; i < poda.Count; i++)
            for (int j = 0; j < poda.Count - 1; j++)
            {
                if (Convert.ToInt32(poda[j][1]) < Convert.ToInt32(poda[j + 1][1]))
                {
                    List<Object> temp = new List<Object>();
                    temp = poda[j];
                    poda[j] = poda[j + 1];
                    poda[j + 1] = temp;
                }
            }
        }
    }



