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
    public partial class ControlProducto : UserControl
    {


        private InterfazPrincipal conexion;
        private String codigoProducto;
        


        public ControlProducto(InterfazPrincipal p , String codProducto)
        {
            InitializeComponent();
            conexion = p;
            codigoProducto = codProducto;
            labelCodigo.Text = codProducto;

        }

        private void butInforProducto_Click(object sender, EventArgs e)
        {
            //Conexion con metodo de mostrar articulo
            conexion.mostrarProducto(codigoProducto);

        }
        
        private void butSelect_Click(object sender, EventArgs e)
        {
            
         
            
        }
    }
}
