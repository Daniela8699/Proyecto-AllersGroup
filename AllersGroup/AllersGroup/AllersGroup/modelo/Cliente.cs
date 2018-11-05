using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllersGroup
{
    public class Cliente
    {
        private String cardCode;
        private String groupName;
        private String city;
        private String department;
        private String paymentGroup;
        private int pos;
        private List<int> comprados;
        private List<Cliente> similares;


        public Cliente(string cardCode, string groupName, string city, string department, string paymentGroup, int pos)
        {
            this.cardCode = cardCode;
            this.groupName = groupName;
            this.city = city;
            this.department = department;
            this.paymentGroup = paymentGroup;
            comprados = new List<int>();
            similares = new List<Cliente>();
            this.pos = pos;
        }

        public string CardCode { get => cardCode; set => cardCode = value; }
        public string GroupName { get => groupName; set => groupName = value; }
        public string City { get => city; set => city = value; }
        public string Department { get => department; set => department = value; }
        public string PaymentGroup { get => paymentGroup; set => paymentGroup = value; }
        public List<int> Comprados { get => comprados; set => comprados = value; }
        public int Pos { get => pos; set => pos = value; }
        public List<Cliente> Similares { get => similares; set => similares = value; }

        public bool esCliente(String c1)
        {
            return CardCode.Equals(c1);
        }
        public bool ArticuloRepetido(int i1)
        {
            bool retorno = false;
            foreach (var x in comprados)
            {
                if (x == i1)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public int RelacionConCliente(double porcentaje, Cliente comparar)
        {
            if (CompararConArticulos(comprados, comparar.Comprados, porcentaje))
            {
                return 1;
            }
            return 0;
        }
        public bool CompararConArticulos(List<int> a1, List<int> a2, double porcentaje)
        {
            int max = 0;
            if(a1.Count>= a2.Count)
            {
                max = a1.Count;
                
            }
            else
            {
                max = a2.Count;
            }
        if(max != 0)
            {
            int count = 0;
           foreach(var x in a1)
            {
                if (a2.Contains(x))
                {
                    count++;
                }
            }
                double result = (Double) count / max;
                return result >= porcentaje;
            }
            return false;
        }

        public String ImprimirClienteCompro()
        {
            return "Cliente #" + pos + " compro los siguientes items: " + ImprimirItems();
        }
        public String ImprimirInfoCliente()
        {
            return "Cliente #" + pos + " CardCode: " + cardCode + "GroupName: " + groupName;
        }
        public String ImprimirClientesSimilares()
        {
            String mensaje = "Los clientes similares al cliente: " + CardCode + " Index: " + Pos + "\n";
            Similares.ForEach(n => mensaje+= n.ImprimirInfoCliente() + "\n");
            return mensaje;
        }
        public String ImprimirItems()
        {
            String mensaje = "";
            comprados.ForEach(n => mensaje += n + " ");
            return mensaje;
        }
    }
}
