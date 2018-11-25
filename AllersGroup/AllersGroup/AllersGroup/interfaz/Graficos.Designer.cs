namespace AllersGroup.interfaz
{
    partial class Graficos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graficos));
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.inicio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.recom = new System.Windows.Forms.Label();
            this.recup = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.Label();
            this.texto2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butSelec = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inicio
            // 
            this.inicio.BackColor = System.Drawing.Color.Transparent;
            this.inicio.Location = new System.Drawing.Point(745, 52);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(53, 18);
            this.inicio.TabIndex = 0;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Location = new System.Drawing.Point(804, 52);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(86, 18);
            this.info.TabIndex = 1;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // recom
            // 
            this.recom.BackColor = System.Drawing.Color.Transparent;
            this.recom.Location = new System.Drawing.Point(911, 52);
            this.recom.Name = "recom";
            this.recom.Size = new System.Drawing.Size(101, 18);
            this.recom.TabIndex = 2;
            this.recom.Click += new System.EventHandler(this.recom_Click);
            // 
            // recup
            // 
            this.recup.BackColor = System.Drawing.Color.Transparent;
            this.recup.Location = new System.Drawing.Point(1032, 52);
            this.recup.Name = "recup";
            this.recup.Size = new System.Drawing.Size(57, 27);
            this.recup.TabIndex = 4;
            this.recup.Click += new System.EventHandler(this.recup_Click);
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.BackColor = System.Drawing.Color.Transparent;
            this.texto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(3, 0);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(0, 22);
            this.texto.TabIndex = 6;
            // 
            // texto2
            // 
            this.texto2.AutoSize = true;
            this.texto2.BackColor = System.Drawing.Color.Transparent;
            this.texto2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto2.Location = new System.Drawing.Point(3, 110);
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(0, 15);
            this.texto2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.texto2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(571, 486);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.textBox1);
            this.flowLayoutPanel3.Controls.Add(this.butSelec);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(563, 46);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Escoge el numero de productos\r\nmas frecuentes que deseas ver:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 25);
            this.textBox1.TabIndex = 10;
            // 
            // butSelec
            // 
            this.butSelec.BackColor = System.Drawing.Color.Transparent;
            this.butSelec.BackgroundImage = global::AllersGroup.Properties.Resources.BotonOscuro;
            this.butSelec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSelec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSelec.FlatAppearance.BorderSize = 0;
            this.butSelec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butSelec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butSelec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSelec.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSelec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butSelec.Location = new System.Drawing.Point(375, 2);
            this.butSelec.Margin = new System.Windows.Forms.Padding(2);
            this.butSelec.Name = "butSelec";
            this.butSelec.Size = new System.Drawing.Size(125, 31);
            this.butSelec.TabIndex = 29;
            this.butSelec.Text = "Escoger";
            this.butSelec.UseVisualStyleBackColor = false;
            this.butSelec.Click += new System.EventHandler(this.butSelec_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.texto);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 55);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(563, 52);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.Transparent;
            this.chartControl1.BackImage.Image = ((System.Drawing.Image)(resources.GetObject("chartControl1.BackImage.Image")));
            this.chartControl1.BackImage.Stretch = true;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            simpleDiagram3D1.RotationMatrixSerializable = "0.0086049544499355;0.893275443411166;-0.44942734335768;0;0.849718830198564;0.2304" +
    "08377226638;0.47422556796297;0;0.527165879363356;-0.38596756586844;-0.7570503112" +
    "29507;0;0;0;0;1";
            this.chartControl1.Diagram = simpleDiagram3D1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(600, 186);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Serie1";
            series1.View = pie3DSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(600, 434);
            this.chartControl1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1190, 685);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.recup);
            this.Controls.Add(this.recom);
            this.Controls.Add(this.info);
            this.Controls.Add(this.inicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Graficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllersGroup";
            this.Load += new System.EventHandler(this.Graficos_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inicio;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label recom;
        private System.Windows.Forms.Label recup;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Label texto2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butSelec;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Label label2;
    }
}