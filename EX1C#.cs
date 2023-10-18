using System;
using System.Drawing;
using System.Windows.Forms; 
   
namespace winformLineaPuntoCerchioRettangolo
{
    public partial class L_P_C_R : Form
    {
        public L_P_C_R()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Create a Object to draw on the window = Graphics
            Graphics g = e.Graphics;

            // LINE

            // Line color = Brown
            Pen linePen = new Pen(Color.Brown, 4); // Line width 4

            // Line coordinates
            int lineX1 = panel1.ClientSize.Width * 3 / 4;
            int lineY1 = panel1.ClientSize.Height / 4;
            int lineX2 = panel1.ClientSize.Width * 3 / 4;
            int lineY2 = panel1.ClientSize.Height * 3 / 4;

            // POINT

            // Draw the line
            g.DrawLine(linePen, lineX1, lineY1, lineX2, lineY2);

            // Point color = Black
            Brush pointBrush = new SolidBrush(Color.Black);

            // Point coordinates
            int pointX = panel1.ClientSize.Width / 4;
            int pointY = panel1.ClientSize.Height / 4;

            // Draw the point
            g.FillEllipse(pointBrush, pointX - 2, pointY - 2, 4, 4);

            // CIRCLE

            // Circle color = Blue
            Brush circleBrush = new SolidBrush(Color.Blue);

            // Circle center coordinates and radius
            int centerX = panel1.ClientSize.Width / 4;
            int centerY = panel1.ClientSize.Height / 2;
            int circleRadius = 60; // Circle radius

            // Draw the circle
            g.FillEllipse(circleBrush, centerX - circleRadius, centerY - circleRadius, 2 * circleRadius, 2 * circleRadius);

            // RECTANGLE

            // Rectangle color = Yellow
            Brush rectangleBrush = new SolidBrush(Color.Yellow);

            // Rectangle coordinates
            int rectX = panel1.ClientSize.Width / 2;
            int rectY = panel1.ClientSize.Height / 4;
            int rectWidth = 80; // Rectangle width
            int rectHeight = 60; // Rectangle height

            // Draw the rectangle
            g.FillRectangle(rectangleBrush, rectX, rectY, rectWidth, rectHeight);

            // Release resources
            linePen.Dispose();
            pointBrush.Dispose();
            circleBrush.Dispose();
            rectangleBrush.Dispose();
        }
    }
}