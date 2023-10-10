using FigureLib.Entities.Figures;
using FigureLib.Entities.Figures.Base;

var p0 = new Point(0, 0);
var p1 = new Point(5, 7);
var p2 = new Point(9, 7);
var p3 = new Point(10, 2);
var p4 = new Point(2, 2);
var p5 = new Point(2, 0);

var f = new SimpleFigure(new List<Point> { p1, p2, p3, p4 });
var t = new Triangle(new List<Point> { p1, p2, p3 });
var rt = new Triangle(new List<Point> { p0, p4, p5 });
var st = new Triangle(new List<double> { 1, 3, 3 });

Console.WriteLine(f.GetArea()); //30
Console.WriteLine(t.GetArea()); //10
Console.WriteLine(rt.IsRectangular()); //true
Console.WriteLine(st.GetArea()); //1.479..
