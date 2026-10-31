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

namespace Nevolin7PR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void TriangleClick(object sender, RoutedEventArgs e)
        {
            Point[] trPoint = new Point[]
            {
        new Point(150, 100),
        new Point(10, 300),
        new Point(300, 300)
             };
            classes.triangle tr = new classes.triangle(Brushes.LightBlue, 
                2.0,
                Brushes.LightBlue, trPoint
             
                );
            tr.Draw(resultCanvas);
        }

        private void CircleClick(object sender, RoutedEventArgs e)
        {
            classes.circle circle = new classes.circle(Brushes.Black, 2.0, Brushes.White, 30);
            circle.Draw(resultCanvas);
        }
    }
}
