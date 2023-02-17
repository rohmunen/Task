

using AreaCalculator.Models;

namespace AreaCalculator
{
    public class Calculator
    {   
        public enum Shapes
        {
            Circle = 1,
            Rectangle = 2,
            Triangle = 3,
            IsoscelesTrapezoid,
        }

        static Dictionary<Shapes, Func<double[], double>> shapes = new()
        {
            {
                Shapes.Circle, delegate(double[] segments)
                {
                    return new Circle().CalculateArea(segments);
                }
            },
            {
                Shapes.Rectangle, delegate(double[] segments)
                {
                    return segments[0] * segments[1];
                }
            },
            {
                Shapes.Triangle, delegate(double[] segments)
                {
                    return new Triangle().CalculateArea(segments);
                }
            },
            {
                Shapes.IsoscelesTrapezoid, delegate(double[] segments)
                {
                    return new IsoscelesTrapezium().CalculateArea(segments);
                }
            }
        };

        public static double Calculate(Shapes? shape = null, params double[] segments)
        {
            if (segments != null) 
            {
                return shapes[shape ?? (Shapes)segments.Length](segments);
            }
            return -1;
        }

    }
}