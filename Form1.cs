
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace ComGraph_Lab_1
{
    public partial class Form1 : Form
    {
        ushort MIN_POINTS_TO_DRAW = 2;

        int i = 0;
        int xc = 0, yc = 0;
        float R = 0;
        float a = 0;
        float b = 0;

        float maxT = 0;
        int T = 1000;
        PointF[] points;

        Graphics g;

        Color colorToDraw;

        Pen pen;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxPaint(object sender, PaintEventArgs e)
        {
            printTripotrochida(e.Graphics, pen, xc, yc, R, a, b);
        }
        private float countMaxT()
        {
            return 2 * (float)Math.PI / MinComDiv((int)(Math.Round(b * 100, 2)), (int)(Math.Round((1 - b) * 100, 2)));
        }
        private void refreshPoints(int N)
        {
            for (int k = 0; k < N; k++)
            {
                float t = k / (float)T * maxT;
                float X = (float)(R * (1 - b) * Math.Cos(b * t) + R * a * b * Math.Cos((1 - b) * t));
                float Y = (float)(R * (1 - b) * Math.Sin(b * t) - R * a * b * Math.Sin((1 - b) * t));

                points[k] = new PointF(X + xc, Y + yc);
            }
        }
        private void refreshParameters()
        {
            R = RTrack.Value;
            a = aTrack.Value;
            b = bTrack.Value / 100f;
            xc = xTrack.Value;
            yc = yTrack.Value;
            T = int.Parse(pointAmount.Text) + 1;    //прибавляем еще одну точку для соединения начала кривой и ее конца
            maxT = countMaxT();

            points = new PointF[i + 2];

            refreshPoints(i + 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorToDraw = Color.Green;
            pen = new Pen(colorToDraw, 2);

            g = pictureBox1.CreateGraphics();

            refreshParameters();
            refreshLabels();
        }
        static float MinComDiv(int a, int b)
        {
            float result = a > b ? a : b;
            while (true)
            {
                if (a % (int)result == 0 && b % (int)result == 0)
                    break;
                else
                    result--;
            }
            return result / 100f;
        }
        private void printPencil(Graphics g, float xc, float yc)
        {

            g.TranslateTransform(xc, yc);
            g.RotateTransform(-70.0F);

            Pen penPencil = new Pen(Color.Black, 2);
            SolidBrush bGreen = new SolidBrush(Color.Green);
            SolidBrush bWhite = new SolidBrush(Color.White);

            PointF[] pencilPointsG = new PointF[4];
            pencilPointsG[0] = new PointF(0, 0);
            pencilPointsG[1] = new PointF(10, -5);
            pencilPointsG[2] = new PointF(10, 5);
            pencilPointsG[3] = new PointF(0, 0);

            PointF[] pencilPointsW = new PointF[5];
            pencilPointsW[0] = new PointF(10, -5);
            pencilPointsW[1] = new PointF(20, -10);
            pencilPointsW[2] = new PointF(20, 10);
            pencilPointsW[3] = new PointF(10, 5);
            pencilPointsW[4] = new PointF(10, -5);

            g.FillRectangle(bGreen, 20, -10, 80, 20);
            g.DrawRectangle(penPencil, 20, -10, 80, 20);

            g.FillPolygon(bWhite, pencilPointsW);
            g.DrawPolygon(penPencil, pencilPointsW);
            g.FillPolygon(bGreen, pencilPointsG);
            g.DrawPolygon(penPencil, pencilPointsG);

            g.TranslateTransform(-xc, -yc);
            g.RotateTransform(70.0F);
        }
        private void printTripotrochida(Graphics g, Pen pen, int xc, int yc, float R, float a, float b)
        {
            // если в массиве достаточно точек, то рисуем кадр
            if (points.Length >= MIN_POINTS_TO_DRAW && timer1.Enabled)
            {
                float xPencil = points[points.Length - 1].X;
                float yPencil = points[points.Length - 1].Y;
                g.DrawCurve(pen, points);
                printPencil(g, xPencil, yPencil);
            }

            // увеличиваем количество точек
            ++i;
        }

        private void paintBtn(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                // обнуляем индекс
                i = 0;

                // ждем, пока не будет готов текущий кадр и тогда останавливаем таймер
                while(timer1.Enabled)
                    timer1.Stop();
            }

            refreshParameters();

            // обновляем кадр
            pictureBox1.Image = null;

            // заново начинаем рисовать кадры
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i <= T)
            {

                // создаем копию текущего кадра, состоящего из точек
                PointF[] oldPoints = new PointF[points.Length];
                points.CopyTo(oldPoints, 0);

                // увеличиваем наш массив точек на единицу и копируем в него точки из предыдущего кадра
                points = new PointF[i + 1];
                oldPoints.CopyTo(points, 0);

                // добавляем новую точку в текущий кадр
                float t = i / (float)T * maxT;

                float X = (float)(R * (1 - b) * Math.Cos(b * t) + R * a * b * Math.Cos((1 - b) * t));
                float Y = (float)(R * (1 - b) * Math.Sin(b * t) - R * a * b * Math.Sin((1 - b) * t));

                points[i] = new PointF(X + xc, Y + yc);

                // обновляем кадр
                pictureBox1.Image = null;
            }
            else
            {
                // если рисунок готов, то обновляем индекс и останавлваем таймер
                i = 0;
                timer1.Stop();
            }
            Invalidate();
        }
        private void refreshLabels()
        {
            xTextBox.Text = string.Format("{0}", xTrack.Value);
            yTextBox.Text = string.Format("{0}", yTrack.Value);
            RTextBox.Text = string.Format("{0}", RTrack.Value);
            aTextBox.Text = string.Format("{0}", aTrack.Value);
            bTextBox.Text = string.Format("{0}", bTrack.Value / 100f);
        }
        private void valueChanged(object sender, EventArgs e)
        {
            refreshLabels();
        }
    }
}


