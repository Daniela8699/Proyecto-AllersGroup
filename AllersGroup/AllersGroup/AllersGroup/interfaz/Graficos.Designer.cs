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
            this.inicio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.recom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inicio
            // 
            this.inicio.BackColor = System.Drawing.Color.Transparent;
            this.inicio.Location = new System.Drawing.Point(826, 52);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(53, 18);
            this.inicio.TabIndex = 0;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Location = new System.Drawing.Point(895, 52);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(86, 29);
            this.info.TabIndex = 1;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // recom
            // 
            this.recom.BackColor = System.Drawing.Color.Transparent;
            this.recom.Location = new System.Drawing.Point(998, 52);
            this.recom.Name = "recom";
            this.recom.Size = new System.Drawing.Size(101, 18);
            this.recom.TabIndex = 2;
            this.recom.Click += new System.EventHandler(this.recom_Click);
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 685);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inicio;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label recom;
    }
}