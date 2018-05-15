using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Drawable;
using GenericPluginSystem;
using System.Xml;
using System.Text;
using System.Linq;
using System.Collections;
using System.Globalization;
using System.Threading;
using System.ComponentModel;

namespace lab1_oop
{
    public partial class Painter : Form
    {
        protected readonly List<TextBox> tbList = new List<TextBox>();
        protected List<Figure> drawList = new List<Figure>();
        protected readonly List<Point> points = new List<Point>();
        protected readonly List<float> ThiknessList = new List<float>();
        Serialization Picture = new Serialization();
        //public SaveConfig frm = new SaveConfig();
        public string applanguagestr;

        bool IsRestart = false;

        private void Draw_button_Click(object sender, EventArgs e)
        {
            string tmp = null;
            //dynamically create a copy of the figure, add it to the list, then draw
            drawList.Add(FigureList.figures[Figure_comboBox.SelectedIndex].CreateCopy(points, ContourcolorDialog.Color, ThiknessList[ThiknesscomboBox.SelectedIndex], BrushColorDialog.Color));
            if (points.Count != drawList[drawList.Count - 1].pointCount)
                drawList.Remove(drawList[drawList.Count - 1]);
            else
            {
                tmp = drawList[drawList.Count - 1].GetType().Name;
                FigureslistBox.Items.Add(tmp);
            }

            points.Clear();
            foreach (var tb in tbList)
                tb.Clear();
            Paint_Panel.Invalidate();
        }

        public Painter()
        {

            XmlDocument document = new XmlDocument();
            try
            {
                document.Load("config.xml");
                XmlElement element = document.DocumentElement;
                XmlNode node = element["Lang"];

                applanguagestr = (node["AppLang"].InnerText);

                document.Save("config.xml");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(applanguagestr);
            }
            catch
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                applanguagestr = "en-US";
            }


            InitializeComponent();

            string colorstr;
            try
            {
                document.Load("config.xml");
                XmlElement element = document.DocumentElement;
                XmlNode node = element["Panel"];
                colorstr = node["ArgbColor"].InnerText;
                Paint_Panel.BackColor = Color.FromArgb(Int32.Parse(colorstr));
                document.Save("config.xml");
            }
            catch
            {

            }

            tbList.Add(textBox1);
            tbList.Add(textBox8);
            tbList.Add(textBox2);
            tbList.Add(textBox7);
            tbList.Add(textBox3);
            tbList.Add(textBox6);
            tbList.Add(textBox4);
            tbList.Add(textBox5);
            ThiknessList.Add(1);
            ThiknessList.Add(2);
            ThiknessList.Add(4);
            ThiknessList.Add(6);
            ThiknessList.Add(8);
            ThiknessList.Add(10);
            ThiknessList.Add(12);

        }

        private void Paint_Panel_Paint(object sender, PaintEventArgs e)
        {
            //draw
            foreach (var fig in drawList)
            {
                fig.Draw(e.Graphics);
            }
        }

        private void Painter_Load(object sender, EventArgs e)
        {

            ThiknesscomboBox.SelectedItem = ThiknesscomboBox.Items[0];
            ContourcolorDialog.Color = Color.Black;
            ContourColorButton.BackColor = ContourcolorDialog.Color;
            BrushColorDialog.Color = Color.White;
            BrushColorButton.BackColor = BrushColorDialog.Color;
            foreach (var tb in tbList)
            {
                tb.ReadOnly = true;
            }
            ICollection<Figure> plugins = GenericPluginLoader<Figure>.LoadPlugins("Plugins");
            if (plugins != null)
            {
                foreach (var p in plugins)
                {
                    FigureList.figures.Add(p);
                }
            }
            if (Figure_comboBox.Items.Count > 0)
            {
                Figure_comboBox.SelectedItem = Figure_comboBox.Items[0];
            }

        }

        private void Paint_Panel_MouseClick(object sender, MouseEventArgs e)
        {
            //calculate the coordinates
            if (points.Count < FigureList.figures[Figure_comboBox.SelectedIndex].pointCount)
            {
                tbList[points.Count * 2].Text = e.Location.X.ToString();
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
                tbList[i].Enabled = (int)(i / 2) < FigureList.figures[Figure_comboBox.SelectedIndex].pointCount;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear paint
            FigureslistBox.Items.Clear();
            drawList.Clear();
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
                if (drawList == null)
                    drawList = new List<Figure>();
                for (var i = 0; i < drawList.Count; i++)
                {
                    tmp = drawList[i].GetType().Name;
                    FigureslistBox.Items.Add(tmp);
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

        private void ContourColorButton_Click(object sender, EventArgs e)
        {
            if (ContourcolorDialog.ShowDialog() == DialogResult.OK)
            {
                ContourColorButton.BackColor = ContourcolorDialog.Color;
                if (FigureslistBox.SelectedIndex != -1)
                {
                    drawList[FigureslistBox.SelectedIndex].Color = ContourcolorDialog.Color;
                    Paint_Panel.Invalidate();
                }
            }
        }

        private void ThiknesscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FigureslistBox.SelectedIndex != -1)
            {
                drawList[FigureslistBox.SelectedIndex].Thikness = ThiknessList[ThiknesscomboBox.SelectedIndex];
                Paint_Panel.Invalidate();
            }
        }

        private void BrushColorButton_Click(object sender, EventArgs e)
        {
            if (BrushColorDialog.ShowDialog() == DialogResult.OK)
            {
                BrushColorButton.BackColor = BrushColorDialog.Color;
                if (FigureslistBox.SelectedIndex != -1)
                {
                    drawList[FigureslistBox.SelectedIndex].BrushColor = BrushColorDialog.Color;
                    Paint_Panel.Invalidate();
                }
            }
        }

        private void Painter_FormClosed(object sender, FormClosedEventArgs e)
        {
            drawList.Clear();
        }

        private void changePanelColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ContourcolorDialog.ShowDialog() == DialogResult.OK)
            {
                Paint_Panel.BackColor = ContourcolorDialog.Color;
                Paint_Panel.Invalidate();
            }
        }

        public void SaveToXML()
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load("config.xml");
                XmlElement element = document.DocumentElement;
                element.RemoveAll();
            }
            catch
            {
                XmlTextWriter textWritter = new XmlTextWriter("config.xml", Encoding.UTF8);
                textWritter.WriteStartDocument();
                textWritter.WriteStartElement("head");
                textWritter.WriteEndElement();
                textWritter.Close();
                document.Load("config.xml");
            }

            XmlNode Lang = document.CreateElement("Lang");
            document.DocumentElement.AppendChild(Lang);

            XmlNode AppLang = document.CreateElement("AppLang");
            AppLang.InnerText = applanguagestr;
            Lang.AppendChild(AppLang);

            XmlNode Panel = document.CreateElement("Panel");
            document.DocumentElement.AppendChild(Panel); // указываем родителя

            XmlNode ArgbColor = document.CreateElement("ArgbColor"); // даём имя
            ArgbColor.InnerText = Paint_Panel.BackColor.ToArgb().ToString(); // и значение
            Panel.AppendChild(ArgbColor); // и указываем кому принадлежит

            document.Save("config.xml");
        }

        private void Painter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsRestart)
            {
                SaveToXML();
            }
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfig frm = new SaveConfig(applanguagestr);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                IsRestart = true;
                applanguagestr = "ru-RU";
                Application.Restart();
            }


        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfig frm = new SaveConfig(applanguagestr);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                IsRestart = true;
                applanguagestr = "en-US";
                Application.Restart();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToXML();
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfig frm = new SaveConfig(applanguagestr);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                IsRestart = true;
                applanguagestr = "fr-Fr";
                Application.Restart();
            }
        }
    }
}
