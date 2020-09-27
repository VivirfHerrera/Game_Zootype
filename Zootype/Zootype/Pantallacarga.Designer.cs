namespace Zootype
{
    partial class Pantallacarga
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantallacarga));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CargaBar = new System.Windows.Forms.ProgressBar();
            this.trespuntos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // CargaBar
            // 
            this.CargaBar.Enabled = false;
            this.CargaBar.Location = new System.Drawing.Point(123, 269);
            this.CargaBar.Name = "CargaBar";
            this.CargaBar.Size = new System.Drawing.Size(406, 29);
            this.CargaBar.TabIndex = 1;
            // 
            // trespuntos
            // 
            this.trespuntos.AutoSize = true;
            this.trespuntos.Enabled = false;
            this.trespuntos.Location = new System.Drawing.Point(107, 311);
            this.trespuntos.Name = "trespuntos";
            this.trespuntos.Size = new System.Drawing.Size(16, 13);
            this.trespuntos.TabIndex = 2;
            this.trespuntos.Text = "...";
            this.trespuntos.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pantallacarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 358);
            this.Controls.Add(this.trespuntos);
            this.Controls.Add(this.CargaBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pantallacarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zootype";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Pantallacarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar CargaBar;
        private System.Windows.Forms.Label trespuntos;
        private System.Windows.Forms.Timer timer1;
    }
}

