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
                MessageBox.Show("Los datos han sido analizados");


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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Explicación:\n\n\n-Soporte: Es el porcentaje de apariciones que debe cumplir las agrupaciones dentro de las ventas.\n\n-Confianza: Es el porcentaje, calculado matematicamente, en el que se asegura que un item logra implicar a otro. \n\n-Tamaño de Agrupaciones: Es el tamaño determinado para generar los conjuntos de articulos frecuentes.\nCabe resaltar que solo puede escoger un tamaño enre 1 a 7.\n\n-nNúmero de Articulos: Cantidad de articulos con los que desea analizar sus datos. Estos articulos son mas frecuentes en sus ventas, asi podemos obtener datos confiables.");
        }
    }
}
