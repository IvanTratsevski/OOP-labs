namespace Figure
{
    internal class Parallel
    {
        public double side1, side2, side3, side4;
        public double[] x = new double[4], y = new double[4];

        public Parallel(double[] x, double[] y)
        {
            for(int i = 0; i < x.Length; i++)
            {
                this.x[i] = x[i];
                this.y[i] = y[i];
            }
        }
        public bool isReal()
        {
            return side1 == side3 && side2 == side4;
        }
        private void setSides()
        {
            side1 = (double)(Math.Sqrt(Math.Pow(x[0] - x[1], 2) + Math.Pow(y[0] - y[1], 2)));
            side2 = (double)(Math.Sqrt(Math.Pow(x[1] - x[2], 2) + Math.Pow(y[1] - y[2], 2)));
            side3 = (double)(Math.Sqrt(Math.Pow(x[2] - x[3], 2) + Math.Pow(y[2] - y[3], 2)));
            side4 = (double)(Math.Sqrt(Math.Pow(x[3] - x[0], 2) + Math.Pow(y[3] - y[0], 2)));
        }
        public double[] getSides()
        {
            setSides();
            double[] sides = { side1, side2, side3, side4 };
            return sides;
        }
        public double getPerimeter()
        {
            return side1 + side2 + side3 + side4;
        }
        public double getSquare()
        {
            double heightLength = x[1] - x[0];
            return Math.Abs(heightLength * side4);
        }
        public bool doesInclude(double pointX, double pointY)
        {
            bool includeS1 = (pointX - x[0]) * (y[1] - y[0]) == (pointY - y[0]) * (x[1] - x[0]);
            bool includeS2 = (pointX - x[1]) * (y[2] - y[1]) == (pointY - y[1]) * (x[2] - x[1]);
            bool includeS3 = (pointX - x[2]) * (y[3] - y[2]) == (pointY - y[2]) * (x[3] - x[2]);
            bool includeS4 = (pointX - x[3]) * (y[0] - y[3]) == (pointY - y[3]) * (x[0] - x[3]);
            return includeS1 || includeS2 || includeS3 || includeS4;
        }
    }
}
