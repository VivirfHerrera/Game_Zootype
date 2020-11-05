namespace Zootype
{
    partial class DatosAnimales
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
            this.components = new System.ComponentModel.Container();
            this.dgv_animales = new System.Windows.Forms.DataGridView();
            this.pdss1DataSet = new Zootype.pdss1DataSet();
            this.pdss1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_animales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdss1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdss1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_animales
            // 
            this.dgv_animales.AllowUserToAddRows = false;
            this.dgv_animales.AllowUserToDeleteRows = false;
            this.dgv_animales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_animales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_animales,
            this.nombre,
            this.habitat,
            this.alimentacion,
            this.imagen});
            this.dgv_animales.Location = new System.Drawing.Point(1, 1);
            this.dgv_animales.Name = "dgv_animales";
            this.dgv_animales.ReadOnly = true;
            this.dgv_animales.Size = new System.Drawing.Size(564, 449);
            this.dgv_animales.TabIndex = 0;
            // 
            // pdss1DataSet
            // 
            this.pdss1DataSet.DataSetName = "pdss1DataSet";
            this.pdss1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pdss1DataSetBindingSource
            // 
            this.pdss1DataSetBindingSource.DataSource = this.pdss1DataSet;
            this.pdss1DataSetBindingSource.Position = 0;
            // 
            // id_animales
            // 
            this.id_animales.HeaderText = "id";
            this.id_animales.Name = "id_animales";
            this.id_animales.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // habitat
            // 
            this.habitat.HeaderText = "habitat";
            this.habitat.Name = "habitat";
            this.habitat.ReadOnly = true;
            // 
            // alimentacion
            // 
            this.alimentacion.HeaderText = "alimentacion";
            this.alimentacion.Name = "alimentacion";
            this.alimentacion.ReadOnly = true;
            // 
            // imagen
            // 
            this.imagen.FillWeight = 500F;
            this.imagen.HeaderText = "imagen";
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            this.imagen.Width = 500;
            // 
            // DatosAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.dgv_animales);
            this.Name = "DatosAnimales";
            this.Text = "DatosAnimales";
            this.Load += new System.EventHandler(this.DatosAnimales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdss1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdss1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_animales;
        private System.Windows.Forms.BindingSource pdss1DataSetBindingSource;
        private pdss1DataSet pdss1DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_animales;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitat;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen;
    }
}