using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllersGroup.interfaz
{
    public partial class ControlCliente : UserControl
    {
        private InterfazPrincipal conexion;
        private String codigoCliente;
        public ControlCliente(String codigo, InterfazPrincipal P)
        {
            InitializeComponent();
            conexion = P;
            labelCodigo.Text = codigo;
            codigoCliente = codigo;

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            conexion.MostrarCliente(codigoCliente);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            conexion.RecuperarCliente(codigoCliente);
        }

        private void ControlCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
