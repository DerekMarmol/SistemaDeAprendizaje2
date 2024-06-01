namespace SistemaDeAprendizaje2
{
    partial class FormVerMateriales
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
            this.btnDescargar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCatalogoCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(681, 80);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(75, 23);
            this.btnDescargar.TabIndex = 3;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnCatalogoCurso
            // 
            this.btnCatalogoCurso.Location = new System.Drawing.Point(664, 109);
            this.btnCatalogoCurso.Name = "btnCatalogoCurso";
            this.btnCatalogoCurso.Size = new System.Drawing.Size(116, 23);
            this.btnCatalogoCurso.TabIndex = 4;
            this.btnCatalogoCurso.Text = "Regresar Al Catalogo";
            this.btnCatalogoCurso.UseVisualStyleBackColor = true;
            this.btnCatalogoCurso.Click += new System.EventHandler(this.btnCatalogoCurso_Click);
            // 
            // FormVerMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCatalogoCurso);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormVerMateriales";
            this.Text = "FormVerMateriales";
            this.Load += new System.EventHandler(this.FormVerMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCatalogoCurso;
    }
}