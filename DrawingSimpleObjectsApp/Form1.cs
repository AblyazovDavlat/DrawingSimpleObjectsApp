using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingSimpleObjectsApp
{
    public partial class Form1 : Form
    {
        Circle circle;
        Line line;
        public Form1()
        {
            InitializeComponent();

            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Blue);
            circle = new Circle( new Point(10,10), 10);
            circle.Draw(graphics, pen);

            line = new Line(new Point(10, 10), new Point(20, 20));
            line.Draw(graphics, pen);
            pictureBox1.Image = bitmap;
        }

    }
}
