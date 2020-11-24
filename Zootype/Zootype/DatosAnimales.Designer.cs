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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosAnimales));
            this.dgv_animales = new System.Windows.Forms.DataGridView();
            this.id_animales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdss1DataSet = new Zootype.pdss1DataSet();
            this.pdss1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_lista1 = new System.Windows.Forms.ToolStripButton();
            this.btn_lista2 = new System.Windows.Forms.ToolStripButton();
            this.btn_lista3 = new System.Windows.Forms.ToolStripButton();
            this.btn_volver = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdss1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdss1DataSetBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.dgv_animales.Location = new System.Drawing.Point(0, 28);
            this.dgv_animales.Name = "dgv_animales";
            this.dgv_animales.ReadOnly = true;
            this.dgv_animales.Size = new System.Drawing.Size(565, 449);
            this.dgv_animales.TabIndex = 0;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_lista1,
            this.btn_lista2,
            this.btn_lista3,
            this.btn_volver});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_lista1
            // 
            this.btn_lista1.Image = ((System.Drawing.Image)(resources.GetObject("btn_lista1.Image")));
            this.btn_lista1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_lista1.Name = "btn_lista1";
            this.btn_lista1.Size = new System.Drawing.Size(60, 22);
            this.btn_lista1.Text = "Lista 1";
            this.btn_lista1.Click += new System.EventHandler(this.btn_lista1_Click);
            // 
            // btn_lista2
            // 
            this.btn_lista2.Image = ((System.Drawing.Image)(resources.GetObject("btn_lista2.Image")));
            this.btn_lista2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_lista2.Name = "btn_lista2";
            this.btn_lista2.Size = new System.Drawing.Size(60, 22);
            this.btn_lista2.Text = "Lista 2";
            this.btn_lista2.Click += new System.EventHandler(this.btn_lista2_Click);
            // 
            // btn_lista3
            // 
            this.btn_lista3.Image = ((System.Drawing.Image)(resources.GetObject("btn_lista3.Image")));
            this.btn_lista3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_lista3.Name = "btn_lista3";
            this.btn_lista3.Size = new System.Drawing.Size(60, 22);
            this.btn_lista3.Text = "Lista 3";
            this.btn_lista3.Click += new System.EventHandler(this.btn_lista3_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(59, 22);
            this.btn_volver.Text = "Volver";
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // DatosAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(552, 476);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_animales);
            this.Name = "DatosAnimales";
            this.Text = "DatosAnimales";
            this.Load += new System.EventHandler(this.DatosAnimales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdss1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdss1DataSetBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_lista1;
        private System.Windows.Forms.ToolStripButton btn_lista2;
        private System.Windows.Forms.ToolStripButton btn_lista3;
        private System.Windows.Forms.ToolStripButton btn_volver;
    }
}