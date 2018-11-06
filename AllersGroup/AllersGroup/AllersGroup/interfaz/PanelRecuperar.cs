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
    public partial class PanelRecuperar : Form
    {
        private InterfazPrincipal conexion;
        public PanelRecuperar(InterfazPrincipal conexion)
        {
            this.conexion = conexion;
            InitializeComponent();
        }

        private void PanelRecuperar_Load(object sender, EventArgs e)
        {
            List<String> clientes= conexion.modelo.darClientesRecuperar();

            foreach (var a in clientes)
            {
                listBox1.Items.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String seleccionado = (String)listBox1.SelectedItem;
            richTextBox1.Text=conexion.modelo.ItemsRecuperar(seleccionado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String seleccionado = (String)listBox1.SelectedItem;
            richTextBox1.Text = conexion.modelo.ItemsRecuperar(seleccionado);
        }
    }
}
