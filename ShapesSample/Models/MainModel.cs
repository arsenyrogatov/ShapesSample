using Prism.Mvvm;
using ShapesSample.Shapes;
using ShapesSample.ShapesCreator;
using System.Collections.ObjectModel;

namespace ShapesSample.Models
{
    public class MainModel : BindableBase //Модель основного окна
    {
        public ObservableCollection<Shape> Shapes { get; set; } //Созданные фигуры
        public ObservableCollection<Creator> ShapesCreators { get; set; } //Создатели фигур
        public Creator? SelectedCreator { get; set; } //Выбранный создатель
        public string? ShapeLength { get; set; } //Размер фигуры (диаметр/длина стороны/etc)

        public MainModel()
        {
            Shapes = new();
            ShapesCreators = new();
            InitilizeShapesCreators();
        }

        private void InitilizeShapesCreators()
        {
            ShapesCreators.Clear();
            ShapesCreators.Add(new CircleCreator("Круг")); //Добавляем создателей всех фигур которые имеются 
            ShapesCreators.Add(new SquareCreator("Квадрат"));
            ShapesCreators.Add(new TriangleCreator("Треугольник"));
        }

        public void AddShape() //Функция создания фигур
        {
            double length;
            if (SelectedCreator != null && double.TryParse(ShapeLength, out length)) //Если создатель выбран и удалось преобразовать размер в double
                Shapes.Add(SelectedCreator.CreateShape($"Фигура №{Shapes.Count + 1} (размер: {length})", length)); //Добавляем финуру
            else
                System.Windows.MessageBox.Show("Ошибка при создании фигуры!");
        }
    }
}
