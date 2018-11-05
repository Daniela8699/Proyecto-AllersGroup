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
    public partial class Recomendaciones : Form
    {
        private InterfazPrincipal conexion;
        public Recomendaciones(InterfazPrincipal conexion)
        {
            this.conexion = conexion;
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(conexion, "Left", -10);
            Visible = false;
            conexion.Show();
            t.run();
        }

        private void info_Click(object sender, EventArgs e)
        {
            conexion.info_Click(sender, e);
            Visible = false;
        }

        private void graf_Click(object sender, EventArgs e)
        {
            conexion.graf_Click(sender, e);
            Visible = false;
        }

        private void Recomendaciones_Load(object sender, EventArgs e)
        {

        }

        private void butDistribuidor_Click(object sender, EventArgs e)
        {
            //Treer información
            String mensaje = conexion.mensajeRecomenaciones();
            richTextBox1.Text = mensaje; 

        }

        private void butCPrivada_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
