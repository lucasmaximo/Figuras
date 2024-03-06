using Figuras.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Entities
{
    internal class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cor cor) : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
