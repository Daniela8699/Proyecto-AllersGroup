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
    public partial class ControlArticulo : UserControl
    {
        private InterfazPrincipal conexion;
        private String codigoCliente;
        public ControlArticulo(InterfazPrincipal p, String codigo)
        {
            InitializeComponent();
            codigoCliente = codigo;
            labelCodigo.Text = codigo;
            conexion = p;

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            conexion.MostrarArticulo(codigoCliente);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
