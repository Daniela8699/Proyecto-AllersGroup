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
            int[] masfrecuentes= a.modelo.masFrecuentesMetodo(a.num);

            for (int i = 0; i < masfrecuentes.Length; i++)
            {
            chart1.Series["Series1"].Points.AddXY(a.modelo.BuscarNombreItemCode(masfrecuentes[i]),a.modelo.apariciones(masfrecuentes[i]));
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

    }
}
