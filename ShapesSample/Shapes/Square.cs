using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesSample.Shapes
{
    public class Square : Shape //Квадрат
    { 
        public double SideLength { get; set; } // Длина стороны

        public Square(string name, double sideLength)
        {
            Name = name;
            SideLength = sideLength;
        }

        public override double GetCanvasLength() // Размер холста = длина стороны 
        {
            return SideLength;
        }

        public override System.Windows.Shapes.Shape GetShape() //Получение фигуры
        {
            Rectangle rectangle = new()
            {
                Width = SideLength, //Задаем размеры и закрашиваем 
                Height = SideLength,
                Fill = Brushes.Blue
            };
            return rectangle;
        }
    }
}
