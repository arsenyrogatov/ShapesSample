using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesSample.Shapes
{
    public class Circle : Shape //Круг
    {
        public double Diameter { get; set; } //Диаметр

        public Circle(string name, double radius)
        {
            Name = name;
            Diameter = radius;
        }

        public override double GetCanvasLength() //Размер холста = Диаметр
        {
            return Diameter;
        }

        public override System.Windows.Shapes.Shape GetShape() //Получение фигуры
        {
            Ellipse ellipse = new()
            {
                Width = Diameter, //Задаем размеры и закрашиваем
                Height = Diameter,
                Fill = Brushes.Red
            };

            return ellipse;
        }
    }
}
