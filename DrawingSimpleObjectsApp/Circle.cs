using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSimpleObjectsApp
{
    class Circle : CustomPoint
    {
        private float radius;
        private Point center;


        public float Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Point Çenter
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
            }
        }


        public Circle(Point center, int radius)
        {
            this.radius = radius;
            this.center = center;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, center.X - radius, center.Y - radius,
                      radius + radius, radius + radius);
        }
    }
}
