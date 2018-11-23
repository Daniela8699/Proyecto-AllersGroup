namespace AllersGroup.interfaz
{
    partial class PanelRecuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelRecuperar));
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.panelInfoClien = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDias = new System.Windows.Forms.Button();
            this.panelInfoArti = new System.Windows.Forms.Panel();
            this.butInfoCantidadDias = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelArriba1 = new System.Windows.Forms.Panel();
            this.graf = new System.Windows.Forms.Label();
            this.recom = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.Inicio = new System.Windows.Forms.Label();
            this.panelAbajo = new System.Windows.Forms.Panel();
            this.flowArticulos = new System.Windows.Forms.FlowLayoutPanel();
            this.flowClientes = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelInfo.SuspendLayout();
            this.panelInfoClien.SuspendLayout();
            this.panelInfoArti.SuspendLayout();
            this.PanelArriba1.SuspendLayout();
            this.panelAbajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelInfo
            // 
            this.PanelInfo.BackColor = System.Drawing.Color.Transparent;
            this.PanelInfo.Controls.Add(this.panelInfoClien);
            this.PanelInfo.Location = new System.Drawing.Point(0, 86);
            this.PanelInfo.Margin = new System.Windows.Forms.Padding(2);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(1175, 52);
            this.PanelInfo.TabIndex = 0;
            this.PanelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelArriba_Paint);
            // 
            // panelInfoClien
            // 
            this.panelInfoClien.BackColor = System.Drawing.Color.Transparent;
            this.panelInfoClien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInfoClien.Controls.Add(this.button1);
            this.panelInfoClien.Controls.Add(this.txtDias);
            this.panelInfoClien.Controls.Add(this.label1);
            this.panelInfoClien.Controls.Add(this.btnDias);
            this.panelInfoClien.Controls.Add(this.panelInfoArti);
            this.panelInfoClien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoClien.Location = new System.Drawing.Point(0, 0);
            this.panelInfoClien.Margin = new System.Windows.Forms.Padding(2);
            this.panelInfoClien.Name = "panelInfoClien";
            this.panelInfoClien.Size = new System.Drawing.Size(1175, 52);
            this.panelInfoClien.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AllersGroup.Properties.Resources.iconoInfo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(527, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(231, 22);
            this.txtDias.Margin = new System.Windows.Forms.Padding(2);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(124, 21);
            this.txtDias.TabIndex = 2;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de días";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDias
            // 
            this.btnDias.BackColor = System.Drawing.Color.Transparent;
            this.btnDias.BackgroundImage = global::AllersGroup.Properties.Resources.BotonInfoOscuro;
            this.btnDias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDias.FlatAppearance.BorderSize = 0;
            this.btnDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDias.Location = new System.Drawing.Point(368, 19);
            this.btnDias.Margin = new System.Windows.Forms.Padding(2);
            this.btnDias.Name = "btnDias";
            this.btnDias.Size = new System.Drawing.Size(130, 24);
            this.btnDias.TabIndex = 1;
            this.btnDias.Text = "Seleccionar días";
            this.btnDias.UseVisualStyleBackColor = false;
            this.btnDias.Click += new System.EventHandler(this.btnDias_Click);
            // 
            // panelInfoArti
            // 
            this.panelInfoArti.BackColor = System.Drawing.Color.Transparent;
            this.panelInfoArti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelInfoArti.Controls.Add(this.butInfoCantidadDias);
            this.panelInfoArti.Controls.Add(this.label2);
            this.panelInfoArti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInfoArti.Location = new System.Drawing.Point(579, 0);
            this.panelInfoArti.Margin = new System.Windows.Forms.Padding(2);
            this.panelInfoArti.Name = "panelInfoArti";
            this.panelInfoArti.Size = new System.Drawing.Size(596, 52);
            this.panelInfoArti.TabIndex = 1;
            this.panelInfoArti.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfoArti_Paint);
            // 
            // butInfoCantidadDias
            // 
            this.butInfoCantidadDias.BackgroundImage = global::AllersGroup.Properties.Resources.iconoInfo;
            this.butInfoCantidadDias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butInfoCantidadDias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butInfoCantidadDias.FlatAppearance.BorderSize = 0;
            this.butInfoCantidadDias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butInfoCantidadDias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butInfoCantidadDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butInfoCantidadDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInfoCantidadDias.Location = new System.Drawing.Point(512, 13);
            this.butInfoCantidadDias.Margin = new System.Windows.Forms.Padding(2);
            this.butInfoCantidadDias.Name = "butInfoCantidadDias";
            this.butInfoCantidadDias.Size = new System.Drawing.Size(32, 30);
            this.butInfoCantidadDias.TabIndex = 23;
            this.butInfoCantidadDias.UseVisualStyleBackColor = true;
            this.butInfoCantidadDias.Click += new System.EventHandler(this.butInfoCantidadDias_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Productos sobre las ventas de clientes similiares";
            // 
            // PanelArriba1
            // 
            this.PanelArriba1.BackColor = System.Drawing.Color.Transparent;
            this.PanelArriba1.Controls.Add(this.graf);
            this.PanelArriba1.Controls.Add(this.recom);
            this.PanelArriba1.Controls.Add(this.info);
            this.PanelArriba1.Controls.Add(this.Inicio);
            this.PanelArriba1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArriba1.Location = new System.Drawing.Point(0, 0);
            this.PanelArriba1.Margin = new System.Windows.Forms.Padding(2);
            this.PanelArriba1.Name = "PanelArriba1";
            this.PanelArriba1.Size = new System.Drawing.Size(1175, 91);
            this.PanelArriba1.TabIndex = 1;
            // 
            // graf
            // 
            this.graf.Location = new System.Drawing.Point(1218, 724);
            this.graf.Name = "graf";
            this.graf.Size = new System.Drawing.Size(66, 18);
            this.graf.TabIndex = 4;
            this.graf.Click += new System.EventHandler(this.graf_Click);
            // 
            // recom
            // 
            this.recom.Location = new System.Drawing.Point(906, 48);
            this.recom.Name = "recom";
            this.recom.Size = new System.Drawing.Size(102, 18);
            this.recom.TabIndex = 2;
            this.recom.Click += new System.EventHandler(this.recom_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(805, 48);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(85, 18);
            this.info.TabIndex = 1;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(748, 48);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(51, 18);
            this.Inicio.TabIndex = 0;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // panelAbajo
            // 
            this.panelAbajo.BackColor = System.Drawing.Color.Transparent;
            this.panelAbajo.Controls.Add(this.flowArticulos);
            this.panelAbajo.Controls.Add(this.flowClientes);
            this.panelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajo.Location = new System.Drawing.Point(0, 152);
            this.panelAbajo.Margin = new System.Windows.Forms.Padding(2);
            this.panelAbajo.Name = "panelAbajo";
            this.panelAbajo.Size = new System.Drawing.Size(1175, 362);
            this.panelAbajo.TabIndex = 2;
            // 
            // flowArticulos
            // 
            this.flowArticulos.AutoScroll = true;
            this.flowArticulos.BackColor = System.Drawing.Color.Transparent;
            this.flowArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowArticulos.Location = new System.Drawing.Point(579, 0);
            this.flowArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.flowArticulos.Name = "flowArticulos";
            this.flowArticulos.Size = new System.Drawing.Size(596, 362);
            this.flowArticulos.TabIndex = 1;
            // 
            // flowClientes
            // 
            this.flowClientes.AutoScroll = true;
            this.flowClientes.BackColor = System.Drawing.Color.Transparent;
            this.flowClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowClientes.Location = new System.Drawing.Point(0, 0);
            this.flowClientes.Margin = new System.Windows.Forms.Padding(2);
            this.flowClientes.Name = "flowClientes";
            this.flowClientes.Size = new System.Drawing.Size(579, 362);
            this.flowClientes.TabIndex = 0;
            this.flowClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.flowClientes_Paint);
            // 
            // PanelRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1175, 514);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.panelAbajo);
            this.Controls.Add(this.PanelArriba1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelRecuperar";
            this.Load += new System.EventHandler(this.Prueba_Load);
            this.PanelInfo.ResumeLayout(false);
            this.panelInfoClien.ResumeLayout(false);
            this.panelInfoClien.PerformLayout();
            this.panelInfoArti.ResumeLayout(false);
            this.panelInfoArti.PerformLayout();
            this.PanelArriba1.ResumeLayout(false);
            this.panelAbajo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Panel panelInfoArti;
        private System.Windows.Forms.Panel panelInfoClien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Button btnDias;
        private System.Windows.Forms.Panel PanelArriba1;
        private System.Windows.Forms.Panel panelAbajo;
        private System.Windows.Forms.FlowLayoutPanel flowArticulos;
        private System.Windows.Forms.FlowLayoutPanel flowClientes;
        private System.Windows.Forms.Button butInfoCantidadDias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Inicio;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label recom;
        private System.Windows.Forms.Label graf;
    }
}