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
            String[] itulos = {"Hola","Hola 2","Hola 3","Hola 4" };
            int[] ints = { 2, 1, 3, 4 };

            for (int i = 0; i < itulos.Length; i++)
            {
                Series agregar = chart1.Series.Add(itulos[i]);
                agregar.Points.Add(ints[i]);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

    }
}
