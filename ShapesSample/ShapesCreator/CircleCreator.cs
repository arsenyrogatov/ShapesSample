using ShapesSample.Shapes;

namespace ShapesSample.ShapesCreator
{
    public class CircleCreator : Creator //Создатель кругов
    {
        public CircleCreator(string displayName)
        {
            Name = displayName; //Имя для комбобокса
        }
        public override Shape CreateShape(string shapeName, double shapeLength)
        {
            return new Circle(shapeName, shapeLength); //Создаем и возвращаем круг с заданными параметрами
        }
    }
}
