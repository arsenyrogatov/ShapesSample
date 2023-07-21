using ShapesSample.Shapes;
using System.Windows;
using System.Windows.Controls;

namespace ShapesSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_Loaded(object sender, RoutedEventArgs e) //Отрисовка фигуры
        {
            var canvas = (Canvas)sender; //Получаем холст
            var data = (Shape)canvas.DataContext; //Получаем фигуру которая должна быть нарисована
            var CanvasLength = data.GetCanvasLength(); //Получаем размер холста
            canvas.Width = CanvasLength; //Устанавливаем размеры
            canvas.Height = CanvasLength;
            canvas.Children.Add(data.GetShape()); //Рисуем фигуру
        }
    }
}
