using System;

namespace HeadHunterTaskLibrary.Shapes
{
    public class Triangle : Shape
    {
        public int? FirstSide { get; set; }
        public int? SecondSide { get; set; }
        public int? ThirdSide { get; set; }

        public Triangle(string name, int? firstSide, int? secondSide, int? thirdSide)
            : base(name)
        {
            FirstSide = firstSide ?? throw new ArgumentNullException(nameof(firstSide));
            SecondSide = secondSide ?? throw new ArgumentNullException(nameof(secondSide));
            ThirdSide = thirdSide ?? throw new ArgumentNullException(nameof(thirdSide));

            if (!IsTriangleExist())
                throw new ArgumentException("This triangle can't exist");
        }

        public bool IsTriangleRectangular()
        {
            return FirstSide * FirstSide == SecondSide * SecondSide + ThirdSide * ThirdSide
                    || SecondSide * SecondSide == FirstSide * FirstSide + ThirdSide * ThirdSide
                    || ThirdSide * ThirdSide == SecondSide * SecondSide + FirstSide * FirstSide;
        }

        public bool IsTriangleExist()
        {
            return FirstSide + SecondSide > ThirdSide
                    && SecondSide + ThirdSide > FirstSide
                    && ThirdSide + FirstSide > SecondSide;
        }

        public override double GetArea()
        {
            var per = Convert.ToDouble(FirstSide + SecondSide + ThirdSide) / 2.0;

            return Math.Round(Math.Sqrt(per * (per - (double)FirstSide) * (per - (double)SecondSide) * (per - (double)ThirdSide)), 5);
        }
    }
}
