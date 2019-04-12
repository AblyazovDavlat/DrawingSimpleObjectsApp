using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSimpleObjectsApp
{
    public class Triangle: Point
    {
        private float x2;
        private float y2;

        private float x3;
        private float y3;

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

        public float X3
        {
            get { return x3; }
            set { x3 = value; }
        }
  
        public float Y3
        {
            get { return y3; }
            set { y3 = value; }
        }

        public Triangle (float x, float y, float x2, float y2, float x3, float y3)
        {
            double a, b, c;
            a = Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
            b = Math.Sqrt(Math.Pow(x - x3, 2) + Math.Pow(y - y3, 2));
            c = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            try
            {
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    throw new ArgumentException("Not a triangle");
                }
                else
                {
                    this.X = x;
                    this.Y = y;
                    this.x2 = x2;
                    this.y2 = y2;
                    this.x3 = x3;
                    this.y3 = y3;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, X, Y, X2, Y2);
            graphics.DrawLine(pen, X2, Y2, X3, Y3);
            graphics.DrawLine(pen, X, Y, X3, Y3);
        }
    }
}
