using System.Drawing.Drawing2D;

namespace laba7
{
    public partial class Form1 : Form
    {
        private bool isTriangle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isTriangle)
            {
                GraphicsPath trianglePath = new GraphicsPath();

                Point[] points =
                {
                    new Point(this.Width / 2, 0),
                    new Point(0, this.Height),
                    new Point(this.Width, this.Height)
                };

                trianglePath.AddPolygon(points);

                this.Region = new Region(trianglePath);
                isTriangle = true;
            }
            else
            {
                this.Region = null;
                isTriangle = false;
            }
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            this.Opacity = 0.75;
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
