using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Nevolin7PR.classes
{
    public class circle : figure
    {
        public int radius { get; set; }

        public circle(Brush fill, double thickness, Brush Scolor, int radius) : base(fill, thickness, Scolor)
        {
            this.radius = radius;
        }

        public override void Draw(Canvas resultCanvas)
        {
            Ellipse circle = new Ellipse
            {
                Width = radius*2,
                Height = radius*2,
                Fill = fill,
                Stroke = Scolor,
                StrokeThickness = thickness
            };
            resultCanvas.Children.Add(circle);
            
        }
    }
}
