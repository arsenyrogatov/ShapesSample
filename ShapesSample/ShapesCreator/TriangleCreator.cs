using ShapesSample.Shapes;

namespace ShapesSample.ShapesCreator
{
    public class TriangleCreator : Creator //Создатель треугольников
    {
        public TriangleCreator(string displayName)
        {
            Name = displayName; //Имя для комбобокса
        }
        public override Shape CreateShape(string shapeName, double shapeLength)
        {
            return new Triangle(shapeName, shapeLength); //Создаем и возвращаем треугольник с заданными параметрами
        }
    }
}
