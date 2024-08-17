namespace Prog_II_Guia_1_Concesionaria_de_motos
{
    partial class TasacionDeMotos
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
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbAñoACalcular = new System.Windows.Forms.Label();
            this.lbValorDeFabricacion = new System.Windows.Forms.Label();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tBMarca = new System.Windows.Forms.TextBox();
            this.tBModelo = new System.Windows.Forms.TextBox();
            this.tBAñoACalcular = new System.Windows.Forms.TextBox();
            this.tBValorDeFabricacion = new System.Windows.Forms.TextBox();
            this.lbTasaDeDepreciacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBTasaDeDepreciacion = new System.Windows.Forms.TextBox();
            this.tBVidaUtil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(39, 42);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 0;
            this.lbMarca.Text = "Marca";
            this.lbMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(39, 74);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(64, 13);
            this.lbModelo.TabIndex = 1;
            this.lbModelo.Text = "Model (Año)";
            // 
            // lbAñoACalcular
            // 
            this.lbAñoACalcular.AutoSize = true;
            this.lbAñoACalcular.Location = new System.Drawing.Point(39, 105);
            this.lbAñoACalcular.Name = "lbAñoACalcular";
            this.lbAñoACalcular.Size = new System.Drawing.Size(75, 13);
            this.lbAñoACalcular.TabIndex = 2;
            this.lbAñoACalcular.Text = "Año a calcular";
            // 
            // lbValorDeFabricacion
            // 
            this.lbValorDeFabricacion.AutoSize = true;
            this.lbValorDeFabricacion.Location = new System.Drawing.Point(39, 134);
            this.lbValorDeFabricacion.Name = "lbValorDeFabricacion";
            this.lbValorDeFabricacion.Size = new System.Drawing.Size(110, 13);
            this.lbValorDeFabricacion.TabIndex = 3;
            this.lbValorDeFabricacion.Text = "Valor de fabricacion $";
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(39, 189);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(110, 32);
            this.btnCalcularCosto.TabIndex = 4;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(177, 189);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(97, 32);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tBMarca
            // 
            this.tBMarca.Location = new System.Drawing.Point(153, 39);
            this.tBMarca.Name = "tBMarca";
            this.tBMarca.Size = new System.Drawing.Size(100, 20);
            this.tBMarca.TabIndex = 6;
            // 
            // tBModelo
            // 
            this.tBModelo.Location = new System.Drawing.Point(153, 71);
            this.tBModelo.Name = "tBModelo";
            this.tBModelo.Size = new System.Drawing.Size(100, 20);
            this.tBModelo.TabIndex = 7;
            // 
            // tBAñoACalcular
            // 
            this.tBAñoACalcular.Location = new System.Drawing.Point(153, 102);
            this.tBAñoACalcular.Name = "tBAñoACalcular";
            this.tBAñoACalcular.Size = new System.Drawing.Size(100, 20);
            this.tBAñoACalcular.TabIndex = 8;
            // 
            // tBValorDeFabricacion
            // 
            this.tBValorDeFabricacion.Location = new System.Drawing.Point(153, 131);
            this.tBValorDeFabricacion.Name = "tBValorDeFabricacion";
            this.tBValorDeFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tBValorDeFabricacion.TabIndex = 9;
            // 
            // lbTasaDeDepreciacion
            // 
            this.lbTasaDeDepreciacion.AutoSize = true;
            this.lbTasaDeDepreciacion.Location = new System.Drawing.Point(306, 42);
            this.lbTasaDeDepreciacion.Name = "lbTasaDeDepreciacion";
            this.lbTasaDeDepreciacion.Size = new System.Drawing.Size(110, 13);
            this.lbTasaDeDepreciacion.TabIndex = 10;
            this.lbTasaDeDepreciacion.Text = "Tasa de depreciacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vida Util (Años)";
            // 
            // tBTasaDeDepreciacion
            // 
            this.tBTasaDeDepreciacion.Location = new System.Drawing.Point(435, 42);
            this.tBTasaDeDepreciacion.Name = "tBTasaDeDepreciacion";
            this.tBTasaDeDepreciacion.Size = new System.Drawing.Size(100, 20);
            this.tBTasaDeDepreciacion.TabIndex = 12;
            // 
            // tBVidaUtil
            // 
            this.tBVidaUtil.Location = new System.Drawing.Point(435, 74);
            this.tBVidaUtil.Name = "tBVidaUtil";
            this.tBVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tBVidaUtil.TabIndex = 13;
            // 
            // TasacionDeMotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 234);
            this.Controls.Add(this.tBVidaUtil);
            this.Controls.Add(this.tBTasaDeDepreciacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTasaDeDepreciacion);
            this.Controls.Add(this.tBValorDeFabricacion);
            this.Controls.Add(this.tBAñoACalcular);
            this.Controls.Add(this.tBModelo);
            this.Controls.Add(this.tBMarca);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.lbValorDeFabricacion);
            this.Controls.Add(this.lbAñoACalcular);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.lbMarca);
            this.Name = "TasacionDeMotos";
            this.Text = "Tasacion de motos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbAñoACalcular;
        private System.Windows.Forms.Label lbValorDeFabricacion;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox tBMarca;
        private System.Windows.Forms.TextBox tBModelo;
        private System.Windows.Forms.TextBox tBAñoACalcular;
        private System.Windows.Forms.TextBox tBValorDeFabricacion;
        private System.Windows.Forms.Label lbTasaDeDepreciacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBTasaDeDepreciacion;
        private System.Windows.Forms.TextBox tBVidaUtil;
    }
}

