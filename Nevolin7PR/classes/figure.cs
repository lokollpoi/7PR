using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Nevolin7PR.classes
{
    public abstract class figure
    {
        public Brush fill { get; set; }
        public double thickness { get; set; }
        public Brush Scolor { get; set; }

        public figure(Brush fill, double thickness, Brush Scolor)
        {
            this.fill = fill;
           this.thickness = thickness;
            this.Scolor = Scolor;
                }
       public abstract void  Draw(Canvas resultCanvas);
        
    }
}
