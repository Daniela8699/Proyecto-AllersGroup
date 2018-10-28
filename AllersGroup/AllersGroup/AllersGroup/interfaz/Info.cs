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

        }

        private void butLimpiarInfoPF_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();


        }
    }
}
