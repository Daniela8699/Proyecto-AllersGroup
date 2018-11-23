using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace AllersGroup.interfaz
{
    public partial class PanelRecuperar : Form
    {
        private InterfazPrincipal conexion;
        public PanelRecuperar(InterfazPrincipal p)
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

           // List<String> clientes = conexion.modelo.darClientesRecuperar(dias);
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

        private void txtDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void butInfoCantidadDias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En la siguiente sección se encontrará los diferentes clientes que puedes recuperar, primero tienes que poner un numero de dias que consideres que ya has perdido un cliente, para darte los clientes que puedes recuperar.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De este lado se encuentran los productos apartir de las ventas de los clientes similares al que seleccionasete, los cuales son las posibles compras a ofrecer a tu cliente perdido.En caso de que selecciones un cliente y no apararezca ningun articulo, significa que no tiene clientes similares a el, o no hay suficientes ventas para estimar una compra.");
        }

        private void flowClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInfoArti_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(conexion, "Left", -10);
            Visible = false;
            conexion.Show();
            t.run();
        }

        private void info_Click(object sender, EventArgs e)
        {
            conexion.info_Click(sender, e);
        }

        private void recom_Click(object sender, EventArgs e)
        {
            conexion.recom_Click(sender, e);
        }

     

        private void graf_Click(object sender, EventArgs e)
        {
            conexion.graf_Click(sender, e);
        }
    }
}
