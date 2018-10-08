using AllersGroup.interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllersGroup
{
    public partial class InterfazPrincipal : Form
    {
        int support;
        int confianza;
        Controlador modelo;
        Form resul;
       public String reporte;
        public InterfazPrincipal()
        {
            resul = new Resultados(this);
            InitializeComponent();
           
        }

        private void InterfazPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double minSup = support / 100;
            double minCon = confianza / 100;
            int tam = Int16.Parse(textBox1.Text);
            int frec = Int16.Parse(textBox2.Text);
            if (tam >= 1 && tam <= 7 && frec > 0)
            {
                modelo = new Controlador(minCon, minSup);
                modelo.CargarDatos();
                modelo.generarAsociaciones(tam, frec);
                modelo.Apriori(tam, frec);
                reporte = modelo.reporte;
                Console.WriteLine(reporte);
                
            }
           
        }
        
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            support = trackBar1.Value;
            label5.Text = "" + trackBar1.Value;

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            confianza = trackBar2.Value;
            label6.Text = "" + trackBar2.Value;
        }
    }
}
