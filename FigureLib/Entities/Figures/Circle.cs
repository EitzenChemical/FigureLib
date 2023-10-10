using FigureLib.Entities.Figures.Base;

namespace FigureLib.Entities.Figures
{
    public class Circle : FigureBase
    {
        public int Radius { get; set; }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public Circle(int r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("invalid circle");
            }
            Radius = r;
        }
    }
}
