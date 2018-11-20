using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllersGroup.interfaz
{
    public partial class Prueba : Form
    {
        private InterfazPrincipal conexion;
        public Prueba(InterfazPrincipal p)
        {
            conexion = p;
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDias_Click(object sender, EventArgs e)
        {

            int dias = Convert.ToInt32(txtDias.Text);

            //List<String> clientes = conexion.modelo.darClientesRecuperar(dias);
            List<String> clientes = new List<string>();
            clientes.Add("CN9657");
            clientes.Add("CN4173");

            for (int i = 0; i < clientes.Count(); i++)
            {
                ControlCliente nuevo = new ControlCliente(clientes[i], conexion);
                flowClientes.Controls.Add(nuevo);
            }
            
        }
        public void mostrarArticulos(List<String> lista)
        {
            for (int i = 0; i < lista.Count(); i++)
            {
                ControlArticulo nuevo = new ControlArticulo(conexion, lista[i]);
                flowArticulos.Controls.Add(nuevo);
            }
        }
    }
}
