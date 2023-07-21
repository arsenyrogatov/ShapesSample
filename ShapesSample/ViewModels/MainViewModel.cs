using Prism.Commands;
using Prism.Mvvm;
using ShapesSample.Models;
using ShapesSample.Shapes;
using ShapesSample.ShapesCreator;
using System.Collections.ObjectModel;

namespace ShapesSample.ViewModels
{
    public class MainViewModel : BindableBase //Модель представления основного окна
    {
        public MainModel _model; //Модель

        public ObservableCollection<Creator> ShapesCreators => _model.ShapesCreators; //Создатели фигур = элементы комбобокса
        public Creator? SelectedShapeCreator { get { return _model.SelectedCreator; } set { _model.SelectedCreator = value; } } //Выбранный создатель = выбранный элемент комбобокса
        public string? ShapeLength { get { return _model.ShapeLength; } set { _model.ShapeLength = value; } } //Размер фигуры
        public DelegateCommand DrawSelectedShape { get; } //Команда добавления/отображения новой фигуры

        public ObservableCollection<Shape> Shapes => _model.Shapes; //Коллекция созданных фигур

        public MainViewModel()
        {
            _model = new MainModel(); //Создаем модель
            _model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
            DrawSelectedShape = new DelegateCommand(() =>
            {
                _model.AddShape(); //Привязываем функцию добавления к модели 
            });
        }
    }
}
