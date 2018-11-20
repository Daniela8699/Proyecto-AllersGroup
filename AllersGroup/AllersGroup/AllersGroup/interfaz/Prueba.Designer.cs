namespace AllersGroup.interfaz
{
    partial class Prueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prueba));
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.panelInfoArti = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInfoClien = new System.Windows.Forms.Panel();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.btnDias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelArriba1 = new System.Windows.Forms.Panel();
            this.panelAbajo = new System.Windows.Forms.Panel();
            this.flowArticulos = new System.Windows.Forms.FlowLayoutPanel();
            this.flowClientes = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelInfo.SuspendLayout();
            this.panelInfoArti.SuspendLayout();
            this.panelInfoClien.SuspendLayout();
            this.panelAbajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelInfo
            // 
            this.PanelInfo.Controls.Add(this.panelInfoArti);
            this.PanelInfo.Controls.Add(this.panelInfoClien);
            this.PanelInfo.Location = new System.Drawing.Point(0, 143);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(2336, 100);
            this.PanelInfo.TabIndex = 0;
            this.PanelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelArriba_Paint);
            // 
            // panelInfoArti
            // 
            this.panelInfoArti.Controls.Add(this.label2);
            this.panelInfoArti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoArti.Location = new System.Drawing.Point(1158, 0);
            this.panelInfoArti.Name = "panelInfoArti";
            this.panelInfoArti.Size = new System.Drawing.Size(1178, 100);
            this.panelInfoArti.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1152, 75);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // panelInfoClien
            // 
            this.panelInfoClien.Controls.Add(this.txtDias);
            this.panelInfoClien.Controls.Add(this.btnDias);
            this.panelInfoClien.Controls.Add(this.label1);
            this.panelInfoClien.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfoClien.Location = new System.Drawing.Point(0, 0);
            this.panelInfoClien.Name = "panelInfoClien";
            this.panelInfoClien.Size = new System.Drawing.Size(1158, 100);
            this.panelInfoClien.TabIndex = 0;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(908, 13);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(244, 31);
            this.txtDias.TabIndex = 2;
            // 
            // btnDias
            // 
            this.btnDias.Location = new System.Drawing.Point(907, 58);
            this.btnDias.Name = "btnDias";
            this.btnDias.Size = new System.Drawing.Size(245, 36);
            this.btnDias.TabIndex = 1;
            this.btnDias.Text = "Seleccionar dias";
            this.btnDias.UseVisualStyleBackColor = true;
            this.btnDias.Click += new System.EventHandler(this.btnDias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(889, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelArriba1
            // 
            this.PanelArriba1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArriba1.Location = new System.Drawing.Point(0, 0);
            this.PanelArriba1.Name = "PanelArriba1";
            this.PanelArriba1.Size = new System.Drawing.Size(2343, 137);
            this.PanelArriba1.TabIndex = 1;
            // 
            // panelAbajo
            // 
            this.panelAbajo.Controls.Add(this.flowArticulos);
            this.panelAbajo.Controls.Add(this.flowClientes);
            this.panelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajo.Location = new System.Drawing.Point(0, 249);
            this.panelAbajo.Name = "panelAbajo";
            this.panelAbajo.Size = new System.Drawing.Size(2343, 696);
            this.panelAbajo.TabIndex = 2;
            // 
            // flowArticulos
            // 
            this.flowArticulos.AutoScroll = true;
            this.flowArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowArticulos.Location = new System.Drawing.Point(1158, 0);
            this.flowArticulos.Name = "flowArticulos";
            this.flowArticulos.Size = new System.Drawing.Size(1185, 696);
            this.flowArticulos.TabIndex = 1;
            // 
            // flowClientes
            // 
            this.flowClientes.AutoScroll = true;
            this.flowClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowClientes.Location = new System.Drawing.Point(0, 0);
            this.flowClientes.Name = "flowClientes";
            this.flowClientes.Size = new System.Drawing.Size(1158, 696);
            this.flowClientes.TabIndex = 0;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2343, 945);
            this.Controls.Add(this.panelAbajo);
            this.Controls.Add(this.PanelArriba1);
            this.Controls.Add(this.PanelInfo);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            this.PanelInfo.ResumeLayout(false);
            this.panelInfoArti.ResumeLayout(false);
            this.panelInfoArti.PerformLayout();
            this.panelInfoClien.ResumeLayout(false);
            this.panelInfoClien.PerformLayout();
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
    }
}