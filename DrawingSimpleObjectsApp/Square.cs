using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSimpleObjectsApp
{
    class Square: Point
    {
        private float side;

        public float Side
        {
            get { return side; }
            set { side = value; }
        }


        public Square (float x, float y, float side)
        {
            this.X = x;
            this.Y = y;
            this.side = side;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawRectangle(pen, X, Y, side, side);
        }
    }
}
