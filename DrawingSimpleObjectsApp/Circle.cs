using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSimpleObjectsApp
{
    public class Circle : Point
    {
        private float radius;

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

        public Circle(float centerX, float centerY, int radius)
        {
            this.X = centerX;
            this.Y = centerY;
            this.radius = radius;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, X - radius, Y - radius,
                      radius + radius, radius + radius);
        }
    }
}
