namespace AllersGroup.interfaz
{
    partial class ControlProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butInforProducto = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.butSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AllersGroup.Properties.Resources.medicamento;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 187);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butInforProducto
            // 
            this.butInforProducto.BackColor = System.Drawing.Color.Transparent;
            this.butInforProducto.BackgroundImage = global::AllersGroup.Properties.Resources.BotonOscuro;
            this.butInforProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butInforProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butInforProducto.FlatAppearance.BorderSize = 0;
            this.butInforProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butInforProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInforProducto.ForeColor = System.Drawing.Color.White;
            this.butInforProducto.Location = new System.Drawing.Point(12, 249);
            this.butInforProducto.Name = "butInforProducto";
            this.butInforProducto.Size = new System.Drawing.Size(108, 40);
            this.butInforProducto.TabIndex = 1;
            this.butInforProducto.Text = "Información";
            this.butInforProducto.UseVisualStyleBackColor = false;
            this.butInforProducto.Click += new System.EventHandler(this.butInforProducto_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(73, 17);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(117, 36);
            this.labelCodigo.TabIndex = 5;
            this.labelCodigo.Text = "Codigo";
            // 
            // butSelect
            // 
            this.butSelect.BackColor = System.Drawing.Color.Transparent;
            this.butSelect.BackgroundImage = global::AllersGroup.Properties.Resources.BotonOscuro;
            this.butSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSelect.FlatAppearance.BorderSize = 0;
            this.butSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSelect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSelect.ForeColor = System.Drawing.Color.White;
            this.butSelect.Location = new System.Drawing.Point(128, 249);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(108, 40);
            this.butSelect.TabIndex = 6;
            this.butSelect.Text = "Seleccionar";
            this.butSelect.UseVisualStyleBackColor = false;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // ControlProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.butSelect);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.butInforProducto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ControlProducto";
            this.Size = new System.Drawing.Size(255, 301);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butInforProducto;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button butSelect;
    }
}
