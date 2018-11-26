using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllersGroup.modelo
{
   
    class PosicionCiudad
    {
        private string nombre;
        private double x;
        private double y;
       public PosicionCiudad(string nombre, double x, double y)
        {
            this.nombre = nombre;
            this.x = x;
            this.y = y;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

    }
}
