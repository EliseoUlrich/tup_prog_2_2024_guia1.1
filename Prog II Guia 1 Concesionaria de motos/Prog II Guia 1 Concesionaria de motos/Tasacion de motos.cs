using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_II_Guia_1_Concesionaria_de_motos
{
    public partial class TasacionDeMotos : Form
    {
        public TasacionDeMotos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            string marca = tBMarca.Text;
            int modelo = Convert.ToInt32(tBModelo.Text);
            int añoaCalcular = Convert.ToInt32(tBAñoACalcular.Text);
            double valorDeFabricacion = Convert.ToDouble(tBValorDeFabricacion.Text);
            double tasaDeDepreciacion = Convert.ToDouble(tBTasaDeDepreciacion.Text);
            int vidaUtil = Convert.ToInt32(tBVidaUtil.Text);

            Moto m = new Moto(marca, modelo, valorDeFabricacion);

            VerResultados verResultados = new VerResultados();
            verResultados.lBResultados.Items.Add(m.VerDescripcion());

            double valorLineal = m.CalcularDepreciacionLineal(añoaCalcular, vidaUtil);
            verResultados.lBResultados.Items.Add($"Depreciacion lineal: ${valorLineal,10:f2}");

            double valorAnual = m.CalcularDepreciacionAnual(añoaCalcular, tasaDeDepreciacion);
            verResultados.lBResultados.Items.Add($"Depreciacion anual: ${valorAnual,10:f2}");

            verResultados.ShowDialog();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
