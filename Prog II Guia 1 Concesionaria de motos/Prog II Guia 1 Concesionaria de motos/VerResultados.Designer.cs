namespace Prog_II_Guia_1_Concesionaria_de_motos
{
    partial class VerResultados
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
            this.labelResultados = new System.Windows.Forms.Label();
            this.lBResultados = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResultados
            // 
            this.labelResultados.AutoSize = true;
            this.labelResultados.Location = new System.Drawing.Point(33, 27);
            this.labelResultados.Name = "labelResultados";
            this.labelResultados.Size = new System.Drawing.Size(60, 13);
            this.labelResultados.TabIndex = 0;
            this.labelResultados.Text = "Resultados";
            // 
            // lBResultados
            // 
            this.lBResultados.FormattingEnabled = true;
            this.lBResultados.Location = new System.Drawing.Point(36, 55);
            this.lBResultados.Name = "lBResultados";
            this.lBResultados.Size = new System.Drawing.Size(422, 69);
            this.lBResultados.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(148, 140);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // VerResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 185);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lBResultados);
            this.Controls.Add(this.labelResultados);
            this.Name = "VerResultados";
            this.Text = "VerResultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResultados;
        public System.Windows.Forms.ListBox lBResultados;
        private System.Windows.Forms.Button btnCerrar;
    }
}