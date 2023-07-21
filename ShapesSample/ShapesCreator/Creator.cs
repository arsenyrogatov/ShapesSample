using ShapesSample.Shapes;

namespace ShapesSample.ShapesCreator
{
    public abstract class Creator //Создатель
    {
        public string? Name { get; set; } //Отображаемое в комбобоксе имя
        public abstract Shape CreateShape(string shapeName, double shapeLength); //Функиция создания фигуры
    }
}
