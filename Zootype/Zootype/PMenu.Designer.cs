namespace Zootype
{
    partial class PMenu
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
            this.SuspendLayout();
            // 
            // PMenu
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "PMenu";
            this.Load += new System.EventHandler(this.PMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnInstrucciones;
    }
}