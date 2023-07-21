using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesSample.Shapes
{
    public class Triangle : Shape //Равносторонний треуголник
    {
        public double Length { get; set; } //Длина стороны 

        public Triangle(string name, double length)
        {
            Name = name;
            Length = length;
        }

        public override double GetCanvasLength() //Размер холста = длина стороны
        {
            return Length;
        }

        public override System.Windows.Shapes.Shape GetShape() //Получение фигуры 
        {
            PointCollection points = new (); //Треугольника нет в стандартных Shape, поэтому рассматриваем его как коллекцию точек

            points.Add (new Point(0, 0));
            points.Add (new Point(Length/2, Length));
            points.Add (new Point(Length, 0));

            Polygon triangle = new (); //Объединяем точки в полигон
            triangle.Points = points;
            triangle.Fill = Brushes.Green;

            return triangle;
        }
    }
}
