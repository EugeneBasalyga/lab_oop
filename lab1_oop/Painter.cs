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
        protected readonly List<TextBox> tbList = new List<TextBox>();
        protected List<Figure> drawList = new List<Figure>();
        protected readonly List<Point> points = new List<Point>();
        protected readonly List<Color> colorsList = new List<Color>();
        protected readonly List<String> InitFiguresList = new List<String>();
        Serialization Picture = new Serialization();

        private void Draw_button_Click(object sender, EventArgs e)
        {
            //dynamically create a copy of the figure, add it to the list, then draw
            drawList.Add(FigureList.figures[Figure_comboBox.SelectedIndex].CreateCopy(points, colorsList[Color_comboBox.SelectedIndex]));
            if (points.Count == drawList[drawList.Count - 1].pointCount)
                FigureslistBox.Items.Add(InitFiguresList[Figure_comboBox.SelectedIndex]);
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
            colorsList.Add(Color.Black);
            colorsList.Add(Color.Red);
            colorsList.Add(Color.Green);
            colorsList.Add(Color.Yellow);
            colorsList.Add(Color.Blue);
            InitFiguresList.Add("Line");
            InitFiguresList.Add("Rectangle");
            InitFiguresList.Add("Ellipse");
            InitFiguresList.Add("Circle");
            InitFiguresList.Add("Triangle");
            InitFiguresList.Add("Quadrangle");
        }


        private void Paint_Panel_Paint(object sender, PaintEventArgs e)
        {
            //draw
            foreach(var fig in drawList)
            {
                fig.Draw(e.Graphics);
            }
        }

        private void Painter_Load(object sender, EventArgs e)
        {
            Figure_comboBox.SelectedItem = Figure_comboBox.Items[0];
            Color_comboBox.SelectedItem = Color_comboBox.Items[0];
            foreach(var tb in tbList)
            {
                tb.ReadOnly = true;
            }
        }

        private void Paint_Panel_MouseClick(object sender, MouseEventArgs e)
        {
            //calculate the coordinates
            if (points.Count < FigureList.figures[Figure_comboBox.SelectedIndex].pointCount)
            {
                tbList[points.Count*2].Text = e.Location.X.ToString();
                tbList[points.Count * 2 + 1].Text = e.Location.Y.ToString();
                points.Add(new Point(e.Location.X, e.Location.Y));
            }
        }

        private void Figure_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            points.Clear();
            //select new figure
            for (var i = 0; i < tbList.Count; i++)
            {
                tbList[i].Clear();
                tbList[i].Enabled = (int)(i/2) < FigureList.figures[Figure_comboBox.SelectedIndex].pointCount;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear paint
            FigureslistBox.Items.Clear();
            drawList.Clear();
            Paint_Panel.Invalidate();
        }

        private void Color_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FigureslistBox.SelectedIndex != -1)
            {
                drawList[FigureslistBox.SelectedIndex].Color = colorsList[Color_comboBox.SelectedIndex];
            }
            Paint_Panel.Invalidate();
        }


        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "All files(*.*) | *.dat";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Picture.Serialize(drawList, saveFileDialog.FileName);
            }
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            FigureslistBox.Items.Clear();
            string tmp = null;
            openFileDialog.Filter = "All files(*.*) | *.dat";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                drawList = Picture.Deserialize(openFileDialog.FileName);
                for (var i = 0; i < drawList.Count; i++)
                {
                    tmp = drawList[i].GetType().ToString();
                    FigureslistBox.Items.Add(tmp.Substring(9));
                }
                Paint_Panel.Invalidate();
            }
        }

        private void FigureslistBox_Click(object sender, EventArgs e)
        {
            if (FigureslistBox.SelectedIndex != -1)
            {

            }
        }

        private void FigureslistBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FigureslistBox.SelectedIndex != -1)
            {
                if (e.KeyChar == (Char)Keys.Back)
                {
                    // drawList[FigureslistBox.SelectedIndex].
                    drawList.RemoveAt(FigureslistBox.SelectedIndex);
                    FigureslistBox.Items.Remove(FigureslistBox.SelectedItem);
                    Paint_Panel.Invalidate();
                }
            }
        }
    }
}
