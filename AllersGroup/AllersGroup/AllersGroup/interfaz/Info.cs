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
        private string categoria;
        public Info(InterfazPrincipal b)
        {
            a = b;
            InitializeComponent();
            

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
            categoria = "DISTRIBUIDORES";
            cargar(a.modelo.NumArticulos, categoria);
            MessageBox.Show("Productos Cargados");

        }

        private void butDrogFarmaciaMiscC_Click(object sender, EventArgs e)
        {
            categoria = "DROG FARMACIA Y MISC";
            cargar(a.modelo.NumArticulos, categoria);
            MessageBox.Show("Productos Cargados");
        }

        private void butAplicarControladorPF_Click(object sender, EventArgs e)
        {
            
            //a.cargar(support);
            //MessageBox.Show("Datos Cargados");
            
        }

        

        private void butCPrivadaC_Click(object sender, EventArgs e)
        {
            
            categoria = "CLINICAS PRIVADAS";
            cargar(a.modelo.NumArticulos, categoria);
            MessageBox.Show("Productos Cargados");
        }

        private void butCPublicasC_Click(object sender, EventArgs e)
        {
            
            categoria = "CLINICAS PUBLICAS";
            cargar(a.modelo.NumArticulos, categoria);
            MessageBox.Show("Productos Cargados");
        }

        private void butNoDedicadoSaludC_Click(object sender, EventArgs e)
        {
            
            categoria = "NO DEDICADO A SALUD";
            cargar(a.modelo.NumArticulos, categoria);
            MessageBox.Show("Productos Cargados");
        }

        private void butAlmacenCadenaC_Click(object sender, EventArgs e)
        {
          
            categoria = "ALMACENES DE CADENA";
            cargar(a.modelo.NumArticulos, categoria);
            MessageBox.Show("Productos Cargados");
        }

        private void butBellezayEsteticaC_Click(object sender, EventArgs e)
        {
          
            categoria = "BELLEZA Y ESTETICA";
            cargar(a.modelo.NumArticulos, categoria);
            MessageBox.Show("Productos Cargados");
        }

        private void butVeterinarioC_Click(object sender, EventArgs e)
        {
         
            categoria = "VETERINARIOS";
            cargar(a.modelo.NumArticulos, categoria);
            MessageBox.Show("Productos Cargados");
        }

        private void butOdontoCentroOdontoC_Click(object sender, EventArgs e)
        {
           
            categoria = "ODONTO CENTRO ODONTO";
            cargar(a.modelo.NumArticulos, categoria);
            MessageBox.Show("Productos Cargados");
        }

        private void butMedAmbulC_Click(object sender, EventArgs e)
        {
            
            categoria = "MED LAB OP AMBUL";
            cargar(a.modelo.NumArticulos, categoria);
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

        private void butInfoFrecuentes_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        private void cargar(int num, string categoria)
        {
            string[] frec = a.frecuentesCategoria(num, categoria);

            texto.Text = "Los" + a.modelo.NumArticulos + " productos mas vendidos de esta categoría son:";
            for (int i = 0; i < frec.Count(); i++)
            {
                texto2.Text += "- " + frec[i] + "\n";
            }
        }
        private void butSelec_Click(object sender, EventArgs e)
        {
            texto2.Text = "";
           
            int numero = Int32.Parse(textBox1.Text);
            cargar(numero,categoria);
        }
    }
}
