using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawingSimpleObjectsApp
{
    public class Line:Point
    {
        private float x2;
        private float y2;

        public Line(float x1, float y1, float x2, float y2)
        {
            this.X = x1;
            this.Y = y1;

            this.x2 = x2;
            this.y2 = y2;
        }

        public float X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public float Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, X, Y, X2, Y2);
        }
    }
}
