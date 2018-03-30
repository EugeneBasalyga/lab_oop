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
        protected readonly List<TextBox> tbList = new List<TextBox>();
        protected readonly List<Figure> drawList = new List<Figure>();
        protected readonly List<Point> points = new List<Point>();


        private void Draw_button_Click(object sender, EventArgs e)
        {
            //динамически создаём копию фигуры,добавляем её в список, чтобы затем отрисовать
            drawList.Add(FigureList.figures[Figure_comboBox.SelectedIndex].CreateInstance(points));
            points.Clear();
            foreach (var tb in tbList)
                tb.Clear();
            Paint_Panel.Invalidate();
        }

        public Painter()
        {
            InitializeComponent();

            tbList.Add(textBox1);
            tbList.Add(textBox8);
            tbList.Add(textBox2);
            tbList.Add(textBox7);
            tbList.Add(textBox3);
            tbList.Add(textBox6);
            tbList.Add(textBox4);
            tbList.Add(textBox5);

        }


        private void Paint_Panel_Paint(object sender, PaintEventArgs e)
        {
            foreach(var fig in drawList)
            {
                fig.Draw(e.Graphics);
            }
        }

        private void Painter_Load(object sender, EventArgs e)
        {
            Figure_comboBox.SelectedItem = Figure_comboBox.Items[0];
            foreach(var tb in tbList)
            {
                tb.ReadOnly = true;
            }
        }

        private void Paint_Panel_MouseClick(object sender, MouseEventArgs e)
        {
            if(points.Count < FigureList.figures[Figure_comboBox.SelectedIndex].pointCount)
            {
                tbList[points.Count*2].Text = e.Location.X.ToString();
                tbList[points.Count * 2 + 1].Text = e.Location.Y.ToString();
                points.Add(new Point(e.Location.X, e.Location.Y));
            }
        }

        private void Figure_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            points.Clear();
            for (var i = 0; i < tbList.Count; i++)
            {
                tbList[i].Clear();
                tbList[i].Enabled = (int)(i/2) < FigureList.figures[Figure_comboBox.SelectedIndex].pointCount;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            drawList.Clear();
            Paint_Panel.Invalidate();
        }
    }
}
