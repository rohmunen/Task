using Microsoft.VisualStudio.TestPlatform.Utilities;
using Xunit.Abstractions;

namespace AreaCalculator.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Calculate_circle_area_outputs_correct_result()
        {
            int radius = 5;
            double expected = 78.53981633974483;

            double actual = Calculator.Calculate(segments: radius);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculate_rectangle_area_outputs_correct_result()
        {
            int firstSide = 10;
            int secondSide = 5;
            double expected = 50;

            double actual = Calculator.Calculate(segments: new double[] { firstSide, secondSide });

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculate_triangle_area_outputs_correct_result()
        {
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;
            double expected = 10.825317547305483;

            double actual = Calculator.Calculate(segments: new double[] { firstSide, secondSide, thirdSide });

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculate_isosceles_trapezoid_area_outputs_correct_result()
        {
            int longerBase = 10;
            int shortedBase = 5;
            int height = 5;
            double exptected = 37.5;

            double actual = Calculator.Calculate(Calculator.Shapes.IsoscelesTrapezoid, longerBase, shortedBase, height);

            Assert.Equal(exptected, actual);
        }

        [Fact]
        public void Catches_not_supported_and_returns_minus_one()
        {
            int segmentOne = 10;
            double expected = -1;

            double actual = Calculator.Calculate(Calculator.Shapes.IsoscelesTrapezoid, segmentOne);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Catches_key_not_found_error_and_returns_minus_one()
        {
            var segmentsValue = new double[] { 1, 1, 1, 1, 1, 1, 1, 1 };
            double expected = -1;

            double actual = Calculator.Calculate(Calculator.Shapes.IsoscelesTrapezoid, segmentsValue);

            Assert.Equal(expected, actual);
        }
    }
}