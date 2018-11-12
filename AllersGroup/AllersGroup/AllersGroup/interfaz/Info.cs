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
    public partial class Info : Form
    {
        private InterfazPrincipal a;
        public Info(InterfazPrincipal b)
        {
            a = b;
            InitializeComponent();


            Bitmap imagenBotonInfoOscuro = new Bitmap(Application.StartupPath+@"\Resources\BotonInfoOscuro.jpeg");
            butInfoFrecuentes.Image = imagenBotonInfoOscuro;


        }
        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(a, "Left", -10);
            Visible = false;
            a.Show();
            t.run();
        }

        private void recom_Click(object sender, EventArgs e)
        {
            a.recom_Click(sender, e);
            Visible = false;
        }

        private void graf_Click(object sender, EventArgs e)
        {
            a.graf_Click(sender, e);
            Visible = false;
        }

        private void butDistribuidorC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("DISTRIBUIDORES");
            richTextBox1.Text = "Los 4 productos mas vendidos de esta categoría son: \n";
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");

        }

        private void butLimpiarInfoPF_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
           

        }

        private void butDrogFarmaciaMiscC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("DROG FARMACIA Y MISC");
            richTextBox1.Text = "Los 4 productos mas vendidos de esta categoría son: \n";
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butAplicarControladorPF_Click(object sender, EventArgs e)
        {
            
            //a.cargar(support);
            //MessageBox.Show("Datos Cargados");
            
        }

        

        private void butCPrivadaC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("CLINICAS PRIVADAS");
            richTextBox1.Text = "Los 4 productos mas vendidos de esta categoría son: \n";
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";

            }
            MessageBox.Show("Productos Cargados");
        }

        private void butCPublicasC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("CLINICAS PUBLICAS");
            richTextBox1.Text = "Los 4 productos mas vendidos de esta categoría son: \n";
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butNoDedicadoSaludC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("NO DEDICADO A SALUD");
            richTextBox1.Text = "Los 4 productos mas vendidos de esta categoría son: \n";
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butAlmacenCadenaC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("ALMACENES DE CADENA");
            richTextBox1.Text = "Los 4 productos mas vendidos de esta categoría son: \n";
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butBellezayEsteticaC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("BELLEZA Y ESTETICA");
            richTextBox1.Text = "Los 4 productos mas vendidos de esta categoría son: \n";
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butVeterinarioC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("VETERINARIOS");
            richTextBox1.Text = "Los 4 productos mas vendidos de esta categoría son: \n";
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butOdontoCentroOdontoC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("ODONTO CENTRO ODONTO");
            richTextBox1.Text = "Los 4 productos mas vendidos de esta categoría son: \n";
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butMedAmbulC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("MED LAB OP AMBUL");
            richTextBox1.Text = "Los 4 productos mas vendidos de esta categoría son: \n";
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void recup_Click(object sender, EventArgs e)
        {
            a.label1_Click(sender, e);
            Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butInfoFrecuentes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se presentan los articulos que son mas frecuentes \n por cada tipo de cliente de la empresa");
        }
    }
}
