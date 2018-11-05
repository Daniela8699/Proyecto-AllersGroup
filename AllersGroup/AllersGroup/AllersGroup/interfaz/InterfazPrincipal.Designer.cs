namespace AllersGroup
{
    partial class InterfazPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazPrincipal));
            this.info = new System.Windows.Forms.Label();
            this.recom = new System.Windows.Forms.Label();
            this.graf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.butRecuperarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Location = new System.Drawing.Point(894, 49);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(88, 33);
            this.info.TabIndex = 0;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // recom
            // 
            this.recom.BackColor = System.Drawing.Color.Transparent;
            this.recom.Location = new System.Drawing.Point(988, 49);
            this.recom.Name = "recom";
            this.recom.Size = new System.Drawing.Size(110, 22);
            this.recom.TabIndex = 1;
            this.recom.Click += new System.EventHandler(this.recom_Click);
            // 
            // graf
            // 
            this.graf.BackColor = System.Drawing.Color.Transparent;
            this.graf.Location = new System.Drawing.Point(1113, 49);
            this.graf.Name = "graf";
            this.graf.Size = new System.Drawing.Size(58, 22);
            this.graf.TabIndex = 2;
            this.graf.Click += new System.EventHandler(this.graf_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1045, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Parámetros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butRecuperarCliente
            // 
            this.butRecuperarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRecuperarCliente.Location = new System.Drawing.Point(1031, 90);
            this.butRecuperarCliente.Name = "butRecuperarCliente";
            this.butRecuperarCliente.Size = new System.Drawing.Size(125, 50);
            this.butRecuperarCliente.TabIndex = 4;
            this.butRecuperarCliente.Text = "Recuperar Cliente";
            this.butRecuperarCliente.UseVisualStyleBackColor = true;
            this.butRecuperarCliente.Click += new System.EventHandler(this.butRecuperarCliente_Click);
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1202, 685);
            this.Controls.Add(this.butRecuperarCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.graf);
            this.Controls.Add(this.recom);
            this.Controls.Add(this.info);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InterfazPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllersGroup";
            this.Load += new System.EventHandler(this.InterfazPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label recom;
        private System.Windows.Forms.Label graf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butRecuperarCliente;
    }
}