﻿using System;
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
        private InterfazPrincipal a;
        public Recomendaciones(InterfazPrincipal b)
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

        private void graf_Click(object sender, EventArgs e)
        {
            a.graf_Click(sender, e);
            Visible = false;
        }

        private void Recomendaciones_Load(object sender, EventArgs e)
        {

        }

        private void butDistribuidor_Click(object sender, EventArgs e)
        {
            
            if(txtSoporte == null)
            {
                MessageBox.Show("Por favor aplique un soporte a la aplicación");
            }
            else
            {
                richTextBox1.Text = "Prueba 1";
            }


        }

        private void butCPrivada_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}