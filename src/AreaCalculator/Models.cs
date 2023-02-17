namespace AreaCalculator.Models
{
    abstract class Shape
    {
        public abstract string Name { get; }
        public abstract int RequiredParamsCount { get; }

        protected void CheckParamsCount(double[] segments)
        {
            if (RequiredParamsCount != segments.Length)
            {
                throw new NotSupportedException($"Incorrect amount of parameters to count {this.Name} area ({this.RequiredParamsCount} needed {segments.Length} provided)");
            }
        }

        protected abstract double Calculate(double[] segments);

        public double CalculateArea(double[] segments)
        {
            CheckParamsCount(segments);
            return Calculate(segments);
        }
    }

    class Triangle : Shape
    {
        public override string Name => "Triangle";

        public override int RequiredParamsCount => 3;

        protected override double Calculate(double[] segments)
        {
            var firstSide = segments[0];
            var secondSide = segments[1];
            var thirdSide = segments[2];
            double semiperimeter = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide));
        }
    }

    class Rectangle : Shape
    {
        public override string Name => "Triangle";

        public override int RequiredParamsCount => 3;

        protected override double Calculate(double[] segments)
        {
            return segments[0] * segments[1];
        }
    }

    class Circle : Shape
    {
        public override string Name => "Circle";

        public override int RequiredParamsCount => 1;

        protected override double Calculate(double[] segments)
        {
            return Math.PI * segments[0] * segments[0];
        }
    }

    class IsoscelesTrapezium : Shape
    {
        public override string Name => "Isosceles trapezium";

        public override int RequiredParamsCount => 3;

        protected override double Calculate(double[] segments)
        {
            return 0.5 * (segments[0] + segments[1]) * segments[2];
        }
    }
}