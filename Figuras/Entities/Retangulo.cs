using Figuras.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Entities
{
    internal class Retangulo : Figura
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura, Cor cor) :base(cor)
        {
            Altura = altura;
            Largura = largura;
        }

        public override double Area()
        {
            return Altura * Largura;
        }
    }
}
