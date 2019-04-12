using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawingSimpleObjectsApp
{
    class Line:CustomPoint
    {
        Point point1;
        Point point2;

        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public Point Point1
        {
            get { return point1; }
            set { point1 = value; }
        }

        public Point Point2
        {
            get { return point2; }
            set { point2 = value; }
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, point1, point2);
        }
    }
}
