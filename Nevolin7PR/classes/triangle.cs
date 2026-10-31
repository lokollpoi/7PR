using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Nevolin7PR.classes
{
    public class triangle:figure
    {
        public Point[] points { get; set; }
        public triangle(Brush fill, double thickness, Brush Scolor, Point[] points) : base(fill, thickness, Scolor)
        {
            this.points = points;
        }


         
        public override void Draw(Canvas resultCanvas)
        {
            Polygon polygon = new Polygon();
            polygon.Fill = fill;
            polygon.Stroke = Scolor;
            polygon.StrokeThickness = thickness;
            
            foreach(Point p in points)
            {
                polygon.Points.Add(p);
            }
            resultCanvas.Children.Add(polygon);
        }
    }
}
