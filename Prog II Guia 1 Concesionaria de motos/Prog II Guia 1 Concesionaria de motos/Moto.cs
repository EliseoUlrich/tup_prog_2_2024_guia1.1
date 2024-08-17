using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_II_Guia_1_Concesionaria_de_motos
{
    public class Moto
    {
        private string marca;
        private int modelo;
        private double valorFabricacion;

        public string Marca { get; private set; }
        public int Modelo { get; private set; }
        public double ValorFabricacion { get; private set; }

        public Moto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }

        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            return ValorFabricacion - (ValorFabricacion * (añoACalcular - Modelo) / vidaUtil);
        }

        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            return ValorFabricacion * (Math.Pow(1-tasaDepreciacion, añoACalcular - Modelo));

        }

        public string VerDescripcion()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}, Valor de Fabricacion:${ValorFabricacion,10:f2}";
        }
    }
}
