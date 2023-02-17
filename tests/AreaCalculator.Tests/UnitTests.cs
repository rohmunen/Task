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
        public void Throws_error_on_wrong_segments_count()
        {
            int segmentOne = 10;
            void act() => Calculator.Calculate(Calculator.Shapes.IsoscelesTrapezoid, segmentOne);

            Assert.Throws<Exception>(act);
        }

        [Fact]
        public void Throws_error_if_cant_default_to_a_shape()
        {
            var segmentsValue = new double[] { 1, 1, 1, 1, 1, 1, 1, 1 };

            void act() => Calculator.Calculate(Calculator.Shapes.IsoscelesTrapezoid, segmentsValue);

            Assert.Throws<Exception>(act);
        }
    }
}