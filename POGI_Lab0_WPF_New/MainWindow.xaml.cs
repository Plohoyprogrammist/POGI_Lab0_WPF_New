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
        Triangle tr;
        Random rnd = new Random();
        Rectangle rect;
        Triangle tr2;
        Rectangle rect2;

        public MainWindow()
        {
            InitializeComponent();
            //Создание треугольника со случайными координатами
            Point2D p1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            tr = new Triangle(p1, p2, p3);
            DrawTriangle(tr);
            p1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            p2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            p3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p4 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            rect = new Rectangle(p1, p2, p3, p4);
            DrawRectangle(rect);

            p1 = new Point2D(25, 25);
            p2 = new Point2D(50, 50);
            p3 = new Point2D(75, 25);
            tr2 = new Triangle(p1, p2, p3);
            DrawTriangle(tr2);
            p1 = new Point2D(100, 25);
            p2 = new Point2D(200, 25);
            p3 = new Point2D(200, 50);
            p4 = new Point2D(100, 50);
            rect2 = new Rectangle(p1, p2, p3, p4);
            DrawRectangle(rect2);
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

        public void DrawTriangle(Triangle tr)
        {
            DrawLine(tr.P1, tr.P2);
            DrawLine(tr.P2, tr.P3);
            DrawLine(tr.P3, tr.P1);
        }

        public void DrawRectangle(Rectangle rect)
        {
            DrawLine(rect.P1, rect.P2);
            DrawLine(rect.P2, rect.P3);
            DrawLine(rect.P3, rect.P4);
            DrawLine(rect.P4, rect.P1);
        }

        public void ClearScene()
        {
            //Очистка Canvas от всех объектов
            Scene.Children.Clear();
        }
    }
}
