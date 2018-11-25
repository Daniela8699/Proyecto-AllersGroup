using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Transitions;

namespace AllersGroup.interfaz
{
    public partial class Graficos : Form
    {
        private InterfazPrincipal a;
        public Graficos(InterfazPrincipal b)
        {
            a = b;
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(a, "Left", -10);
            Visible = false;
            a.Show();
            t.run();
        }

        private void info_Click(object sender, EventArgs e)
        {
            a.info_Click(sender, e);
            Visible = false;
        }

        private void recom_Click(object sender, EventArgs e)
        {
            a.recom_Click(sender, e);
            Visible = false;
        }
        private void Graficos_Load(object sender, EventArgs e)
        {
            int[] masfrecuentes = a.modelo.masFrecuentesMetodo(a.num);
            cargar(a.num);
   
        }
        private void cargar(int numero)
        {
            int[] masfrecuentes = a.modelo.masFrecuentesMetodo(numero);

            texto.Text = "Los " + numero + " productos mas vendidos ordenados de mayor a menor son: ";
            for (int i = 0; i < masfrecuentes.Length; i++)
            {
                string x = a.modelo.BuscarItem(masfrecuentes[i]).ItemName;
                int y = a.modelo.apariciones(masfrecuentes[i]);
                int num = i + 1;
                texto2.Text += "["+num+"] "+ x + " con un total de apariciones en las transacciones de " + y + "\n\n";
                chartControl1.Series[0].Points.AddPoint(x, y);

            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void recup_Click(object sender, EventArgs e)
        {
            a.label1_Click(sender, e);
            Visible = false;
        }

      
        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void chartControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void butSelec_Click(object sender, EventArgs e)
        {
            texto2.Text = "";
            chartControl1.Series[0].Points.Clear();
            int numero = Int32.Parse(textBox1.Text);
            cargar(numero);
        }
    }
}
