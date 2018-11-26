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
            this.label1 = new System.Windows.Forms.Label();
            this.butParametrosCargar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Location = new System.Drawing.Point(809, 49);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(83, 33);
            this.info.TabIndex = 0;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // recom
            // 
            this.recom.BackColor = System.Drawing.Color.Transparent;
            this.recom.Location = new System.Drawing.Point(907, 49);
            this.recom.Name = "recom";
            this.recom.Size = new System.Drawing.Size(110, 22);
            this.recom.TabIndex = 1;
            this.recom.Click += new System.EventHandler(this.recom_Click);
            // 
            // graf
            // 
            this.graf.BackColor = System.Drawing.Color.Transparent;
            this.graf.Location = new System.Drawing.Point(1112, 49);
            this.graf.Name = "graf";
            this.graf.Size = new System.Drawing.Size(58, 22);
            this.graf.TabIndex = 2;
            this.graf.Click += new System.EventHandler(this.graf_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1023, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 33);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butParametrosCargar
            // 
            this.butParametrosCargar.BackColor = System.Drawing.Color.Transparent;
            this.butParametrosCargar.BackgroundImage = global::AllersGroup.Properties.Resources.BotonClaro;
            this.butParametrosCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butParametrosCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butParametrosCargar.FlatAppearance.BorderSize = 0;
            this.butParametrosCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butParametrosCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butParametrosCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butParametrosCargar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butParametrosCargar.Location = new System.Drawing.Point(965, 610);
            this.butParametrosCargar.Name = "butParametrosCargar";
            this.butParametrosCargar.Size = new System.Drawing.Size(162, 35);
            this.butParametrosCargar.TabIndex = 6;
            this.butParametrosCargar.Text = "Parámetros";
            this.butParametrosCargar.UseVisualStyleBackColor = false;
            this.butParametrosCargar.Click += new System.EventHandler(this.butParametrosCargar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.BackgroundImage = global::AllersGroup.Properties.Resources.BotonClaro;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(101, 610);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(162, 35);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Seleccionar Carpeta";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1202, 685);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.butParametrosCargar);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butParametrosCargar;
        private System.Windows.Forms.Button btnCargar;
    }
}