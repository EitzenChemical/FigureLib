using FigureLib.Entities.Figures.Base;

namespace FigureLib.Entities.Figures
{
    public class SimpleFigure : FigureBase
    {
        public SimpleFigure(List<Point> pts)
        {
            Points = pts;
        }
    }
}
