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
    public partial class PanelRecuperar : Form
    {
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Label inicio;
        private Label info;
        private Label recom;
        private Label graf;
        private InterfazPrincipal conexion;
        public PanelRecuperar(InterfazPrincipal conexion)
        {
            this.conexion = conexion;
            InitializeComponent();
        }

        private void PanelRecuperar_Load(object sender, EventArgs e)
        {
            List<String> clientes= conexion.modelo.darClientesRecuperar();

            foreach (var a in clientes)
            {
                listBox1.Items.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String seleccionado = (String)listBox1.SelectedItem;
            richTextBox1.Text=conexion.modelo.ItemsRecuperar(seleccionado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String seleccionado = (String)listBox1.SelectedItem;
            richTextBox1.Text = conexion.modelo.ItemsRecuperar(seleccionado);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelRecuperar));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.recom = new System.Windows.Forms.Label();
            this.graf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(180, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 433);
            this.listBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(609, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(345, 433);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(230, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Selección";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(713, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inicio
            // 
            this.inicio.BackColor = System.Drawing.Color.Transparent;
            this.inicio.Location = new System.Drawing.Point(749, 48);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(49, 19);
            this.inicio.TabIndex = 4;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Location = new System.Drawing.Point(804, 48);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(85, 19);
            this.info.TabIndex = 5;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // recom
            // 
            this.recom.BackColor = System.Drawing.Color.Transparent;
            this.recom.Location = new System.Drawing.Point(908, 48);
            this.recom.Name = "recom";
            this.recom.Size = new System.Drawing.Size(101, 19);
            this.recom.TabIndex = 6;
            this.recom.Click += new System.EventHandler(this.recom_Click);
            // 
            // graf
            // 
            this.graf.BackColor = System.Drawing.Color.Transparent;
            this.graf.Location = new System.Drawing.Point(1110, 48);
            this.graf.Name = "graf";
            this.graf.Size = new System.Drawing.Size(59, 19);
            this.graf.TabIndex = 7;
            this.graf.Click += new System.EventHandler(this.graf_Click);
            // 
            // PanelRecuperar
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 685);
            this.Controls.Add(this.graf);
            this.Controls.Add(this.recom);
            this.Controls.Add(this.info);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PanelRecuperar";
            this.Load += new System.EventHandler(this.PanelRecuperar_Load_1);
            this.ResumeLayout(false);

        }

        private void PanelRecuperar_Load_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void recom_Click(object sender, EventArgs e)
        {
            conexion.recom_Click(sender, e);
            Visible = false;
        }

        private void graf_Click(object sender, EventArgs e)
        {
            conexion.graf_Click(sender, e);
            Visible = false;
        }
    }
}
