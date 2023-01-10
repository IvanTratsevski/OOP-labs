
namespace IntegralLib
{
    public class Rectangleintegral
    {
        private double leftSide, rightSide;
        public Rectangleintegral(double leftSide, double rightSide)
        {
            this.leftSide = leftSide;
            this.rightSide = rightSide;
        }
        public double RectangleIntegralCalculate()
        {
            double n = 10000000;
            double h = (rightSide - leftSide) / n;
            double y, s = 0;
            for (double x = leftSide + h / 2; x < rightSide; x += h)
            {
                y = FuncToIntegrate(x);
                s += y * h;
            }
            return s;
        }
        public double FuncToIntegrate(double x)
        {
            return (Math.Sqrt(x + 11 * x * x) / (Math.Sqrt(Math.Pow((x + 1), 2)+4)));
        }
    }
}