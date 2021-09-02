using System;

namespace HeadHunterTaskLibrary
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public abstract double GetArea();

        public override string ToString()
        {
            return $"{this.Name}({this.GetType().Name}): {this.GetArea()}";
        }
    }
}
