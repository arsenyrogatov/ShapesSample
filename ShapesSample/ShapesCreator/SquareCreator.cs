using ShapesSample.Shapes;

namespace ShapesSample.ShapesCreator
{
    public class SquareCreator : Creator //Создатель квадратов
    {
        public SquareCreator(string displayName)
        {
            Name = displayName; //Имя для комбобокса
        }
        public override Shape CreateShape(string shapeName, double shapeLength)
        {
            return new Square(shapeName, shapeLength); //Создаем и возвращаем квадрат с заданными параметрами
        }
    }
}
