using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenClosePrinciple
{
    public class Rhombus : Shape
    {
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }

        public override double Area() => (this.DiagonalMayor * this.DiagonalMenor) / 2;
    }
}