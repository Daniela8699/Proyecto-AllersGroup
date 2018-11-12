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
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(263, 239);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 344);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(623, 239);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(386, 344);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::AllersGroup.Properties.Resources.BotonOscuro;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Selecconar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::AllersGroup.Properties.Resources.BotonOscuro;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(796, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(618, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Similitud entre clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Recuperar clientes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::AllersGroup.Properties.Resources.iconoInfo;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(960, 601);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 37);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PanelRecuperar
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 685);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        private void PanelRecuperar_Load_1(object sender, EventArgs e)
        {
            //List<String> clientes = conexion.modelo.darClientesRecuperar();
            List<String> clientes = new List<string>();
            clientes.Add("CN9657");
            clientes.Add("CN4173");
            foreach (var a in clientes)
            {
                listBox1.Items.Add(a);
            }
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

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String seleccionado = (String)listBox1.SelectedItem;
            richTextBox1.Text = conexion.modelo.ItemsRecuperar(seleccionado);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String seleccionado = (String)listBox1.SelectedItem;
            richTextBox1.Text = conexion.modelo.ItemsRecuperar(seleccionado);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Información: \n Los clientes similares representan...");
        }
    }
}
