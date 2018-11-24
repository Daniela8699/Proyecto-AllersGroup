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
        private double soporte;
        private double confianza;


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

        public void darSoporte()
        {
            soporte = Double.Parse(comboxSoporte.SelectedItem.ToString())/100;
        }

        public void darConfianza()
        {
            confianza =  Double.Parse(comBoxConfianza.SelectedItem.ToString())/100;
        }
     

        private void butIniciarProgram_Click(object sender, EventArgs e)
        {
            darConfianza();
            darSoporte();

            ThreadStart delegado = new ThreadStart(cargarHilo);
            Thread hilo = new Thread(delegado);
            hilo.Start();

            mostrarGif();
            
        }

        public void cargarHilo()
        {

            

            if ( txtNumArticulos == null || txtTamAgrupaciones == null)
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
            else
            {


                int NumArticulos = Convert.ToInt32(txtNumArticulos.Text);
                int TamAgrupaciones = Convert.ToInt32(txtTamAgrupaciones.Text);

                conexion.cargar(soporte,confianza,NumArticulos,TamAgrupaciones);
                
            }

           

        }
        private void Parametros_Load(object sender, EventArgs e)
        {
              
        }

        private void comboxSoporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //soporte = Double.Parse(comboxSoporte.SelectedText);
        }

        private void comBoxConfianza_SelectedIndexChanged(object sender, EventArgs e)
        {
            //confianza = Double.Parse(comBoxConfianza.SelectedText);
        }
    }
}
