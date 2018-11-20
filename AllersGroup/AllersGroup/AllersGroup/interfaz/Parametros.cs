using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            
            pictureBox1.Visible = false;
        }

        public void mostrarGif()
        {
            pictureBox1.Visible = true;
        }


     

        private void butIniciarProgram_Click(object sender, EventArgs e)
        {


            ThreadStart delegado = new ThreadStart(cargarHilo);
            Thread hilo = new Thread(delegado);
            hilo.Start();

            mostrarGif();

            //Visible = false;

        }

        public void cargarHilo()
        {
            
            if (txtSoporte == null || txtConfianza == null || txtNumArticulos == null || txtTamAgrupaciones == null)
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
            else
            {

                double soporte = Double.Parse(txtSoporte.Text)/100;
                double confianza = Double.Parse(txtConfianza.Text)/100;
                int NumArticulos = Convert.ToInt32(txtNumArticulos.Text);
                int TamAgrupaciones = Convert.ToInt32(txtTamAgrupaciones.Text);

                conexion.cargar(soporte,confianza,NumArticulos,TamAgrupaciones);



                
            }

           

        }
        private void Parametros_Load(object sender, EventArgs e)
        {
              
        }
    }
}
