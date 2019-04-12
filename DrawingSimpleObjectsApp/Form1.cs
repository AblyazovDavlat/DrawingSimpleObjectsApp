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
        Pen pen;
        Bitmap bitmap;
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();

            pen = new Pen(Color.Black);
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            
        }

        void colorPen_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadio.Checked) pen.Color = Color.Red;
            if (greenRadio.Checked) pen.Color = Color.Green;
            if (yellowRadio.Checked) pen.Color = Color.Yellow;
            if (blueRadio.Checked) pen.Color = Color.Blue;
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var location = e.Location;

            if (circleRadio.Checked)
            {
                Circle circle = new Circle(location.X, location.Y, int.Parse(radiusCircle.Text));
                circle.Draw(graphics, pen);
                pictureBox1.Image = bitmap;
            }
            if (triangleRadio.Checked)
            {
                Triangle triangle = new Triangle(float.Parse(x1Triangle.Text), float.Parse(y1Triangle.Text),
                    float.Parse(x2Triangle.Text), float.Parse(y2Triangle.Text), float.Parse(x3Triangle.Text), float.Parse(y3Triangle.Text));
                triangle.Draw(graphics, pen);
                pictureBox1.Image = bitmap;
            }
            if (squareRadio.Checked)
            {
                Square square = new Square(location.X, location.Y, float.Parse(squareSide.Text));
                square.Draw(graphics, pen);
                pictureBox1.Image = bitmap;
            }
            if (lineRadio.Checked)
            {
                Line line = new Line(location.X, location.Y, location.X + float.Parse(lengthLine.Text), location.Y + float.Parse(lengthLine.Text));
                line.Draw(graphics, pen);
                pictureBox1.Image = bitmap;
            }
        }

        void radioFigure_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
