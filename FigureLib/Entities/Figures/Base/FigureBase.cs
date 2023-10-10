namespace FigureLib.Entities.Figures.Base
{
    public abstract class FigureBase
    {
        public List<Point> Points { get; set; } = new List<Point>();

        public virtual double GetArea()
        {
            // если тип фигуры неизвестен, будем считать площадь по формуле Гаусса для выпуклого многоугольника по координатам
            return GetGaussArea();
        }

        private double GetGaussArea()
        {
            var count = Points.Count;

            if (count < 3)
            {
                return 0;
            }

            var sum = 0;


            for (int i = 0; i < count; i++)
            {

                if (i != count - 1)
                {
                    sum += Points[i].x * Points[i + 1].y;
                }
                else
                {
                    sum += Points[i].x * Points[0].y;
                }

                if (i > 0)
                {
                    sum -= Points[i].x * Points[i - 1].y;
                }
            }
            sum -= Points[0].x * Points[count - 1].y;

            var result = Math.Abs(sum) / 2;

            return result;
        }
    }
}