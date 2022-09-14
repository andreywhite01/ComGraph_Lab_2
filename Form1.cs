using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ComGraph_Lab_1
{
    public partial class Form1 : Form
    {
        int xc = 0, yc = 0;
        float R = 0;
        float a = 0;
        float b = 0;

        Pen pen = new Pen(Color.Black, 2);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            printTripotrochida(g, pen, xc, yc, R, a, b);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void printTripotrochida(Graphics g, Pen pen, int xc, int yc, float R, float a, float b)
        {
            int maxT = 0;
            int approxValue = approxTrack.Value;

            if (pointAmount.Text != "")
                maxT = int.Parse(pointAmount.Text);
            PointF[] points = new PointF[maxT];

            for (int i = 0; i < maxT; i++)
            {
                float t = i / ((float)(approxValue) + 1);



                float X = (float)(R * (1 - b) * Math.Cos(b * t) + R * a * b * Math.Cos((1 - b) * t));
                float Y = (float)(R * (1 - b) * Math.Sin(b * t) - R * a * b * Math.Sin((1 - b) * t));

                points[i] = new PointF(X + xc, Y + yc);
            }
            if (points.Length >= 2)
                g.DrawCurve(pen, points);
        }

        private void paintBtn(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void valueChanged(object sender, EventArgs e)
        {

            xc = xTrack.Value;
            yc = yTrack.Value;
            R = RTrack.Value;
            a = (aTrack.Value - 100) * 0.1f;
            float.TryParse(textBox1.Text, out b);

            xTextBox.Text = string.Format("{0}", xc);
            yTextBox.Text = string.Format("{0}", yc);
            RTextBox.Text = string.Format("{0}", R);
            aTextBox.Text = string.Format("{0}", a);
        }
    }
}


