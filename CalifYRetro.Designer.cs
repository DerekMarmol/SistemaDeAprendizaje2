﻿namespace SistemaDeAprendizaje2
{
    partial class CalifYRetro
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
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.dtgCalificaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonAd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(224, 59);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(356, 21);
            this.ComboBox1.TabIndex = 0;
            // 
            // dtgCalificaciones
            // 
            this.dtgCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCalificaciones.Location = new System.Drawing.Point(138, 110);
            this.dtgCalificaciones.Name = "dtgCalificaciones";
            this.dtgCalificaciones.Size = new System.Drawing.Size(572, 230);
            this.dtgCalificaciones.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calificaciones y Retroalimentacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(316, 396);
            this.buttonG.Name = "buttonG";
            this.buttonG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonG.Size = new System.Drawing.Size(75, 23);
            this.buttonG.TabIndex = 4;
            this.buttonG.Text = "Guardar";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click_1);
            // 
            // buttonAd
            // 
            this.buttonAd.Location = new System.Drawing.Point(439, 396);
            this.buttonAd.Name = "buttonAd";
            this.buttonAd.Size = new System.Drawing.Size(75, 23);
            this.buttonAd.TabIndex = 5;
            this.buttonAd.Text = "Agregar";
            this.buttonAd.UseVisualStyleBackColor = true;
            this.buttonAd.Click += new System.EventHandler(this.buttonAd_Click);
            // 
            // CalifYRetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAd);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCalificaciones);
            this.Controls.Add(this.ComboBox1);
            this.Name = "CalifYRetro";
            this.Text = "FormCalificacionYRetro";
            this.Load += new System.EventHandler(this.CalifYRetro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCalificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.DataGridView dtgCalificaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonAd;
    }
}