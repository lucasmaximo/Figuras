using Figuras.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Entities
{
    internal abstract class Figura
    {
        public Cor Cor { get; set; }
        public List<Figura> Figuras { get; set; } = new List<Figura>();

        public Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();

    }
}
