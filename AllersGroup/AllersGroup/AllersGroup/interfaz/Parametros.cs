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
    public partial class Parametros : Form
    {

        private InterfazPrincipal conexion;

        public Parametros(InterfazPrincipal conexion)
        {

            this.conexion = conexion;
            InitializeComponent();
        }

        private void butIniciarProgram_Click(object sender, EventArgs e)
        {

            if (txtSoporte==null || txtConfianza == null || txtNumArticulos ==null || txtTamAgrupaciones ==null)
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
            else
            {
                double support = Double.Parse(txtSoporte.Text);
                double confianza = Double.Parse(txtConfianza.Text);
                int NumArticulos = Convert.ToInt32(txtNumArticulos.Text);
                int TamAgrupaciones = Convert.ToInt32(txtTamAgrupaciones.Text);

              
                conexion.cargar(support,confianza,NumArticulos,TamAgrupaciones);
                MessageBox.Show("Se cargo el programa correctamente");
                Visible = false;

            }


        }
    }
}
