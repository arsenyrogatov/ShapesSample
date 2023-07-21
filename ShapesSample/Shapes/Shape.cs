namespace ShapesSample.Shapes
{
    public abstract class Shape //Базовый класс фигур 
    {
        public string? Name { get; set; } //Название
        public abstract double GetCanvasLength(); //Получение размера холста
        public abstract System.Windows.Shapes.Shape GetShape(); //Получение самой фигуры
    }
}
