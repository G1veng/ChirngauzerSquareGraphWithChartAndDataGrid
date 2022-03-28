using System;
using System.Collections.Generic;

namespace Services
{
    public class ServicesCharngauzerSquare : ICharngauzerSquare
    {
        public List<ModelCharngauzerSquare> GetPoints(double a, double leftBorder, double rigthBorder, double step)
        {
            List<ModelCharngauzerSquare> points = new List<ModelCharngauzerSquare>();
            for (double x = leftBorder; x <= rigthBorder && x + step < rigthBorder; x += step)
            {
                double y = GetY(x, a);
                points.Add(new ModelCharngauzerSquare((double)x, y));
                points.Add(new ModelCharngauzerSquare((double)x, -y));
            }
            return points;
        }
        private double GetY(double x, double a)
        {
            if (a > 0)
                if (x > a)
                    throw new ArgumentOutOfRangeException("If 'a' greater than 0, 'x' must be less than 'a'");
            if (a < 0)
                if (x < a)
                    throw new ArgumentOutOfRangeException("If 'a' less than 0, 'x' must be greater than 'a'");
            if (x + 0.1 > a && x - 0.1 < a)
                return 0;
            double y, numerator, denominator;
            denominator = 27 * a;
            double leftTemp = a - x;
            double rightTemp = (8 * a) + x;
            numerator = leftTemp * Math.Pow(rightTemp, 2);
            y = Math.Sqrt(numerator / denominator);
            return y;
        }
    }
}
