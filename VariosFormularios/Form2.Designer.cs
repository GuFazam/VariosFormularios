﻿namespace VariosFormularios
{
    partial class FormSegundo
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
            this.textBoxMultiTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMultiTexto
            // 
            this.textBoxMultiTexto.Location = new System.Drawing.Point(12, 12);
            this.textBoxMultiTexto.Multiline = true;
            this.textBoxMultiTexto.Name = "textBoxMultiTexto";
            this.textBoxMultiTexto.Size = new System.Drawing.Size(776, 341);
            this.textBoxMultiTexto.TabIndex = 0;
            // 
            // FormSegundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMultiTexto);
            this.Name = "FormSegundo";
            this.Text = "Segundo Formulário Exemplo";
            this.Load += new System.EventHandler(this.FormSegundo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMultiTexto;
    }
}