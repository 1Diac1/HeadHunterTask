using System;

namespace HeadHunterTaskLibrary.Shapes
{
    public class Circle : Shape
    {
        public double? Raduis { get; set; }

        public Circle(string name, double? radius)
            : base(name)
        {
            Raduis = radius ?? throw new ArgumentNullException(nameof(radius));
        }

        public override double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow((double)Raduis, 2), 4);
        }
    }
}
