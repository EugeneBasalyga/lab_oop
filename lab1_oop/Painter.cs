using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_oop
{
    public partial class Painter : Form
    {
        protected Rectangle Rect;
        protected Line Line;
        int x1, x2, x3, x4, y1, y2, y3, y4;

        private void Draw_button_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            var Points = new List<Point>();
            if (FigureList.figures[Figure_comboBox.SelectedIndex].pointCount == 2)
            {
                Points.Add(new Point(x1, y1));
                Points.Add(new Point(x2, y2));
                FigureList.figures[Figure_comboBox.SelectedIndex].Draw(graphics, Points);
            }
            if (FigureList.figures[Figure_comboBox.SelectedIndex].pointCount == 3)
            {
                Points.Add(new Point(x1, y1));
                Points.Add(new Point(x2, y2));
                Points.Add(new Point(x3, y3));
                FigureList.figures[Figure_comboBox.SelectedIndex].Draw(graphics, Points);
            }
            if (FigureList.figures[Figure_comboBox.SelectedIndex].pointCount == 4)
            {
                Points.Add(new Point(x1, y1));
                Points.Add(new Point(x2, y2));
                Points.Add(new Point(x3, y3));
                Points.Add(new Point(x4, y4));
                FigureList.figures[Figure_comboBox.SelectedIndex].Draw(graphics, Points);
            }
            Points.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            x1 = 0;
            x2 = 0;
            x3 = 0;
            x4 = 0;
            y1 = 0;
            y2 = 0;
            y3 = 0;
            y4 = 0;
        }

        public Painter()
        {
            InitializeComponent();
            //Line = new Line(new Point(30, 50), new Point(200, 200), 1, Color.Red);
            //Rect = new Rectangle(new Point(230, 50), new Point(370, 250), Color.White);
            //var Rect2 = new Rectangle();// new Point(230,50), new Point(370, 250), Color.White);
            //Rect2.TopLeft = new Point(230, 50);
            //var x = new DrawableFigure();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //FigureList.line.Draw(e.Graphics, new Point(10, 10), new Point(20, 20));
            //var Points = new List<Point>();

            ////foreach (var el in FigureList.figures)
            ////{
            ////    el.Draw(e.Graphics, Points);
            ////}

            //Points.Add(new Point(1, 1));
            //Points.Add(new Point(200, 200));
            //FigureList.figures[0].Draw(e.Graphics, Points);
            //Points[0] = new Point(250, 250);
            //Points[1] = new Point(300, 300);
            //FigureList.figures[1].Draw(e.Graphics, Points);
            //Points[0] = new Point(500, 200);
            //Points[1] = new Point(575, 300);
            //FigureList.figures[2].Draw(e.Graphics, Points);
            //Points[0] = new Point(450, 450);
            //Points[1] = new Point(450, 500);
            //Points.Add(new Point(550, 550));
            //FigureList.figures[3].Draw(e.Graphics, Points);
            //Points[0] = new Point(300, 450);
            //Points[1] = new Point(300, 500);
            //FigureList.figures[4].Draw(e.Graphics, Points);
            //Points[0] = new Point(700, 200);
            //Points[1] = new Point(800, 250);
            //Points[2] = new Point(750, 300);
            //Points.Add(new Point(500, 300));
            //FigureList.figures[5].Draw(e.Graphics, Points);

            //foreach (var el in FigureList.figures2)
            //{
            //    el.Draw(e.Graphics, new Point(10, 10), new Point(20, 20));
            //}

            //FigureList.rectangle.Draw(e.Graphics, new Point(10, 10), new Point(20, 20));
            //FigureList.rectangle.Color = Color.Aqua;
            //FigureList.rectangle.Draw(e.Graphics, new Point(20, 20), new Point(30, 30));
            //var Rect2 = new Rectangle(new Point(230, 50), new Point(370, 250), Color.Blue);
            //Rect2.Draw(e.Graphics, new Point(30, 30), new Point(60, 60));
            //Rect2.Draw(e.Graphics);
            //var Rect3 = new Rectangle(new Point(230, 50), new Point(370, 250), Color.Green);
            //Rect3.Draw(e.Graphics, new Point(70, 70), new Point(90, 90));
            //Line.Draw(formGraphics);
            //Line.Draw(formGraphics, new Point(130, 150), new Point(3200, 300));
            //Rect.Draw(formGraphics);
            //Rect.Color = Color.Aqua;
            //Rect.Draw(formGraphics, new Point(330, 50), new Point(370, 450));
            //formGraphics.Dispose();
        }

        private void Painter_Load(object sender, EventArgs e)
        {
            Figure_comboBox.SelectedItem = Figure_comboBox.Items[0];
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
        }

        private void Paint_Panel_MouseClick(object sender, MouseEventArgs e)
        {
           // e.Location.X
           if (textBox1.Enabled == true && textBox1.Text == "" && textBox8.Enabled == true && textBox8.Text == "")
            {
                x1 = e.Location.X;
                y1 = e.Location.Y;
                textBox1.Text = x1.ToString();
                textBox8.Text = y1.ToString();
            }
            else
            {
                if (textBox2.Enabled == true && textBox2.Text == "" && textBox7.Enabled == true && textBox7.Text == "")
                {
                    x2 = e.Location.X;
                    y2 = e.Location.Y;
                    textBox2.Text = x2.ToString();
                    textBox7.Text = y2.ToString();
                }
                else
                {
                    if (textBox3.Enabled == true && textBox3.Text == "" && textBox6.Enabled == true && textBox6.Text == "")
                    {
                        x3 = e.Location.X;
                        y3 = e.Location.Y;
                        textBox3.Text = x3.ToString();
                        textBox6.Text = y3.ToString();
                    }
                    else
                    {
                        if (textBox4.Enabled == true && textBox4.Text == "" && textBox5.Enabled == true && textBox5.Text == "")
                        {
                            x4 = e.Location.X;
                            y4 = e.Location.Y;
                            textBox4.Text = x4.ToString();
                            textBox5.Text = y4.ToString();
                        }
                    }
                }
            }
        }

        private void Figure_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Figure_comboBox.SelectedItem == Figure_comboBox.Items[0] || Figure_comboBox.SelectedItem == Figure_comboBox.Items[1] || 
                Figure_comboBox.SelectedItem == Figure_comboBox.Items[2] || Figure_comboBox.SelectedItem == Figure_comboBox.Items[3])
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
            }
            if (Figure_comboBox.SelectedItem == Figure_comboBox.Items[4])
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = true;
            }
            if (Figure_comboBox.SelectedItem == Figure_comboBox.Items[5])
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }
    }
}
