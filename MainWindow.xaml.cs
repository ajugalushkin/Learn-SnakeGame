using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SnakeGame
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            var ellipse = CreateEllipse(new Point(rand.Next(1,800), rand.Next(1, 434)), Brushes.Purple);
            CanvasMap.Children.Insert(0, ellipse);
        }

        private Ellipse CreateEllipse(Point point, Brush brush)
        {
            var ellipse = new Ellipse()
            {
                Width = 16,
                Height = 16,
                Fill = brush



            };

            Canvas.SetLeft(ellipse, point.X);
            Canvas.SetTop(ellipse, point.Y);

            Canvas.SetTop(ellipse, point.Y);

            return ellipse;
        }
    }
}
