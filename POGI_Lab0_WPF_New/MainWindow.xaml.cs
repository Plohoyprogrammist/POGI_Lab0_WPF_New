using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POGI_Lab0_WPF_New
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

        public void DrawLine(Point2D p1, Point2D p2)
        {
            //Создание новой линии
            Line line = new Line();
            //Цвет и толщина линии
            line.Stroke = Brushes.Red;
            line.StrokeThickness = 3;
            //Установка координат линии из координат точек Point2D
            line.X1 = p1.X;
            line.Y1 = p1.Y;
            line.X2 = p2.X;
            line.Y2 = p2.Y;
            //Добавление линии в Canvas
            Scene.Children.Add(line);
        }
    }
}
