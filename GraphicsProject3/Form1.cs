using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        // Draw the sky
        g.FillRectangle(Brushes.SkyBlue, 0, 0, pictureBox1.Width, pictureBox1.Height);

        // Draw the sun
        g.FillEllipse(Brushes.Yellow, 20, 20, 60, 60);

        // Draw some clouds
        for (int i = 0; i < 5; i++)
        {
            DrawCloud(g, 100 + i * 70, 30);
        }

        // Draw the barn
        g.FillRectangle(Brushes.Red, 50, 200, 150, 100);
        g.FillPolygon(Brushes.DarkRed, new Point[] { new Point(50, 200), new Point(200, 200), new Point(125, 150) });

        // Draw the windows of the barn
        g.FillRectangle(Brushes.LightBlue, 70, 220, 40, 30);
        g.FillRectangle(Brushes.LightBlue, 140, 220, 40, 30);

        // Draw the door of the barn
        g.FillRectangle(Brushes.Brown, 100, 260, 50, 40);
        g.FillEllipse(Brushes.Black, 140, 280, 5, 5);

        // Draw the field
        for (int i = 0; i < 10; i++)
        {
            g.FillRectangle(i % 2 == 0 ? Brushes.SaddleBrown : Brushes.Wheat, 250, 200 + i * 10, 150, 10);
        }

        // Draw some trees
        for (int i = 0; i < 3; i++)
        {
            DrawTree(g, 300 + i * 50, 250);
        }

        // Draw the park
        g.FillRectangle(Brushes.LightGreen, 450, 200, 150, 100);
        for (int i = 0; i < 2; i++)
        {
            DrawTree(g, 475 + i * 60, 210);
        }

        // Draw some people
        for (int i = 0; i < 3; i++)
        {
            DrawPerson(g, 500 + i * 30, 300);
        }

        // Draw some animals
        for (int i = 0; i < 3; i++)
        {
            DrawAnimal(g, 60 + i * 30, 300);
        }
    }

    private void DrawTree(Graphics g, int x, int y)
    {
        // Draw the trunk
        g.FillRectangle(Brushes.Brown, x, y, 10, 30);

        // Draw the leaves
        g.FillEllipse(Brushes.Green, x - 15, y - 20, 40, 40);
        g.FillEllipse(Brushes.Green, x - 10, y - 30, 30, 30);
        g.FillEllipse(Brushes.Green, x - 5, y - 40, 20, 20);
    }

    private void DrawCloud(Graphics g, int x, int y)
    {
        // Draw the cloud
        for (int i = 0; i < 5; i++)
        {
            g.FillEllipse(Brushes.White, x + i * 10, y, 30, 30);
        }
    }

    private void DrawPerson(Graphics g, int x, int y)
    {
        // Draw the head
        g.FillEllipse(Brushes.PeachPuff, x, y, 10, 10);

        // Draw the body
        g.DrawLine(new Pen(Brushes.Black, 2), new Point(x + 5, y + 10), new Point(x + 5, y + 20));

        // Draw the arms
        g.DrawLine(new Pen(Brushes.Black, 2), new Point(x, y + 15), new Point(x + 10, y + 15));

        // Draw the legs
        g.DrawLine(new Pen(Brushes.Black, 2), new Point(x + 5, y + 20), new Point(x, y + 30));
        g.DrawLine(new Pen(Brushes.Black, 2), new Point(x + 5, y + 20), new Point(x + 10, y + 30));
    }

    private void DrawAnimal(Graphics g, int x, int y)
    {
        // Draw the body
        g.FillEllipse(Brushes.Brown, x, y, 20, 10);

        // Draw the head
        g.FillEllipse(Brushes.Brown, x + 15, y, 10, 10);

        // Draw the legs
        for (int i = 0; i < 4; i++)
        {
            g.DrawLine(new Pen(Brushes.Black, 1), new Point(x + 5 * i, y + 10), new Point(x + 5 * i, y + 15));
        }
    }
}
