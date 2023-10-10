using FigureLib.Entities.Figures.Base;

namespace FigureLib.Entities.Figures
{
    public class Triangle : FigureBase
    {
        public List<double> Sides { get; set; } = new List<double>();

        public Triangle(List<double> s)
        {
            Sides = s.OrderByDescending(s => s).ToList();
            CheckIsValidTriangle();
        }

        public Triangle(List<Point> pts)
        {
            Points = pts;
            FillSides(pts);
            CheckIsValidTriangle();
        }

        public bool IsRectangular()
        {
            // float для меньшей погрешности, тк есть возможность задать фигуру по координатам
            var a = (float)Math.Pow(Sides[0], 2);
            var b = (float)Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2);
            return a == b;
        }

        public override double GetArea()
        {
            if (Sides.Count == 3)
            {
                var p = (Sides[0] + Sides[1] + Sides[2]) / 2;
                return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            }
            return base.GetArea();
        }

        private void CheckIsValidTriangle()
        {
            if (Sides.Count > 3
                || Sides[0] >= Sides[1] + Sides[2]
                || Points.Count > 0 && Points.Count != 3)
            {
                throw new ArgumentException("invalid triangle");
            }
        }

        private void FillSides(List<Point> pts)
        {
            if (pts.Count == 3)
            {
                var a = Math.Sqrt(Math.Pow(pts[1].x - pts[0].x, 2) + Math.Pow(pts[1].y - pts[0].y, 2));
                var b = Math.Sqrt(Math.Pow(pts[2].x - pts[1].x, 2) + Math.Pow(pts[2].y - pts[1].y, 2));
                var c = Math.Sqrt(Math.Pow(pts[0].x - pts[2].x, 2) + Math.Pow(pts[0].y - pts[2].y, 2));

                Sides.AddRange(new List<double> { a, b, c });
                Sides = Sides.OrderByDescending(s => s).ToList();
            }
        }
    }
}
