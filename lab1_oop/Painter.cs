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


namespace lab1_oop
{
    public partial class Painter : Form
    {
        protected readonly List<TextBox> tbList = new List<TextBox>();
        protected List<Figure> drawList = new List<Figure>();
        protected readonly List<Point> points = new List<Point>();
        protected readonly List<float> ThiknessList = new List<float>();
        Serialization Picture = new Serialization();
        public SaveConfig frm = new SaveConfig();

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
            InitializeComponent();

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


            XmlDocument document = new XmlDocument();
            try
            {
                document.Load("config.xml");
                XmlElement element = document.DocumentElement;
                XmlNode node = element["Panel"];
                XmlNode node2 = element["Language"];
                string colorstr;
                colorstr = (node["ArgbColor"].InnerText);
                Paint_Panel.BackColor = Color.FromArgb(Int32.Parse(colorstr));

                SaveMenuItem.Text = (node2["savemenuitem"].InnerText);
                OpenMenuItem.Text = (node2["openmenuitem"].InnerText);
                settingsToolStripMenuItem.Text = (node2["settingsToolStripMenuItem"].InnerText);
                changePanelColorToolStripMenuItem1.Text = (node2["changepanelcolortoolstripmenuItem1"].InnerText);
                languageToolStripMenuItem.Text = (node2["languagetoolstripmenuitem"].InnerText);
                russianToolStripMenuItem.Text = (node2["russiantoolstripmenuitem"].InnerText);
                englishToolStripMenuItem.Text = (node2["englishtoolstripmenuitem"].InnerText);
                Draw_button.Text = (node2["draw_button"].InnerText);
                ClearButton.Text = (node2["clearButton"].InnerText);
                Figure_comboBox.Items.Add((node2["line"].InnerText));
                Figure_comboBox.Items.Add((node2["circle"].InnerText));
                Figure_comboBox.Items.Add((node2["triangle"].InnerText));
                Figure_comboBox.Items.Add((node2["quadrangle"].InnerText));
                Figure_comboBox.Items.Add((node2["ellipse"].InnerText));
                Figure_comboBox.Items.Add((node2["rectangle"].InnerText));
                ThiknessLabel.Text = (node2["thiknesslabel"].InnerText);
                BrushLabel.Text = (node2["brushlabel"].InnerText);
                ContourLabel.Text = (node2["contourlabel"].InnerText);

                frm.LoadText(node2);
                //document.DocumentElement.ParentNode.RemoveAll();
                document.Save("config.xml");
            }
            catch
            {
                foreach (var f in FigureList.figures)
                {
                    Figure_comboBox.Items.Add(f.GetType().Name);
                }
            }
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
                    Figure_comboBox.Items.Add(p.GetType().Name);
                }
            }
            if (Figure_comboBox.Items.Count > 0)
                Figure_comboBox.SelectedItem = Figure_comboBox.Items[0];
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


        private void Painter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frm.ShowDialog() == DialogResult.OK)
            {
                XmlDocument document = new XmlDocument();
                try
                {
                    document.Load("config.xml");
                    //document.RemoveAll();
                    XmlElement element = document.DocumentElement;
                    XmlNode node = element["head"];
                    node.RemoveAll();
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

                XmlNode Panel = document.CreateElement("Panel");
                document.DocumentElement.AppendChild(Panel); // указываем родителя
                XmlAttribute attribute1 = document.CreateAttribute("number"); // создаём атрибут
                attribute1.Value = "1"; // устанавливаем значение атрибута
                Panel.Attributes.Append(attribute1); // добавляем атрибут

                XmlNode subElement1 = document.CreateElement("ArgbColor"); // даём имя
                subElement1.InnerText = Paint_Panel.BackColor.ToArgb().ToString(); // и значение
                Panel.AppendChild(subElement1); // и указываем кому принадлежит


                XmlNode lang = document.CreateElement("Language");
                document.DocumentElement.AppendChild(lang);
                XmlAttribute attribute2 = document.CreateAttribute("number");
                attribute2.Value = "1";
                lang.Attributes.Append(attribute2);

                XmlNode savemenuitem = document.CreateElement("savemenuitem");
                savemenuitem.InnerText = SaveMenuItem.Text;
                lang.AppendChild(savemenuitem);
                XmlNode openmenuitem = document.CreateElement("openmenuitem");
                openmenuitem.InnerText = OpenMenuItem.Text;
                lang.AppendChild(openmenuitem);
                XmlNode settingstoolstripmenuitem = document.CreateElement("settingsToolStripMenuItem");
                settingstoolstripmenuitem.InnerText = settingsToolStripMenuItem.Text;
                lang.AppendChild(settingstoolstripmenuitem);
                XmlNode changepanelcolortoolstripmenuItem1 = document.CreateElement("changepanelcolortoolstripmenuItem1");
                changepanelcolortoolstripmenuItem1.InnerText = changePanelColorToolStripMenuItem1.Text;
                lang.AppendChild(changepanelcolortoolstripmenuItem1);
                XmlNode languagetoolstripmenuitem = document.CreateElement("languagetoolstripmenuitem");
                languagetoolstripmenuitem.InnerText = languageToolStripMenuItem.Text;
                lang.AppendChild(languagetoolstripmenuitem);
                XmlNode russiantoolstripmenuitem = document.CreateElement("russiantoolstripmenuitem");
                russiantoolstripmenuitem.InnerText = russianToolStripMenuItem.Text;
                lang.AppendChild(russiantoolstripmenuitem);
                XmlNode englishtoolstripmenuitem = document.CreateElement("englishtoolstripmenuitem");
                englishtoolstripmenuitem.InnerText = englishToolStripMenuItem.Text;
                lang.AppendChild(englishtoolstripmenuitem);
                XmlNode draw_button = document.CreateElement("draw_button");
                draw_button.InnerText = Draw_button.Text;
                lang.AppendChild(draw_button);
                XmlNode clearButton = document.CreateElement("clearButton");
                clearButton.InnerText = ClearButton.Text;
                lang.AppendChild(clearButton);
                XmlNode line = document.CreateElement("line");
                line.InnerText = Figure_comboBox.Items[0].ToString();
                lang.AppendChild(line);
                XmlNode circle = document.CreateElement("circle");
                circle.InnerText = Figure_comboBox.Items[1].ToString();
                lang.AppendChild(circle);
                XmlNode triangle = document.CreateElement("triangle");
                triangle.InnerText = Figure_comboBox.Items[2].ToString();
                lang.AppendChild(triangle);
                XmlNode quadrangle = document.CreateElement("quadrangle");
                quadrangle.InnerText = Figure_comboBox.Items[3].ToString();
                lang.AppendChild(quadrangle);
                XmlNode ellipse = document.CreateElement("ellipse");
                ellipse.InnerText = Figure_comboBox.Items[4].ToString();
                lang.AppendChild(ellipse);
                XmlNode rectangle = document.CreateElement("rectangle");
                rectangle.InnerText = Figure_comboBox.Items[5].ToString();
                lang.AppendChild(rectangle);
                XmlNode thiknesslabel = document.CreateElement("thiknesslabel");
                thiknesslabel.InnerText = ThiknessLabel.Text;
                lang.AppendChild(thiknesslabel);
                XmlNode contourlabel = document.CreateElement("contourlabel");
                contourlabel.InnerText = ContourLabel.Text;
                lang.AppendChild(contourlabel);
                XmlNode brushlabel = document.CreateElement("brushlabel");
                brushlabel.InnerText = BrushLabel.Text;
                lang.AppendChild(brushlabel);

                frm.SaveText(document, lang);
                document.Save("config.xml");
            }
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMenuItem.Text = "Сохранить как";
            OpenMenuItem.Text = "Открыть";
            settingsToolStripMenuItem.Text = "Настройки";
            changePanelColorToolStripMenuItem1.Text = "Изменить цвет панели";
            languageToolStripMenuItem.Text = "Язык";
            russianToolStripMenuItem.Text = "Русский";
            englishToolStripMenuItem.Text = "Английский";
            Draw_button.Text = "Рисовать";
            ClearButton.Text = "Очистить";
            Figure_comboBox.Items[0] = "Линия";
            Figure_comboBox.Items[1] = "Круг";
            Figure_comboBox.Items[2] = "Треугольник";
            Figure_comboBox.Items[3] = "Четырёхугольник";
            Figure_comboBox.Items[4] = "Эллипс";
            Figure_comboBox.Items[5] = "Прямоугольник";
            Figure_comboBox.SelectedItem = Figure_comboBox.Items[0];
            ThiknessLabel.Text = "Толщина";
            ContourLabel.Text = "Цвет контура";
            BrushLabel.Text = "Цвет кисти";
            frm.ChangeTextToRussian();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMenuItem.Text = "Save as";
            OpenMenuItem.Text = "Open";
            settingsToolStripMenuItem.Text = "Settings";
            changePanelColorToolStripMenuItem1.Text = "Change Panel Color";
            languageToolStripMenuItem.Text = "Language";
            russianToolStripMenuItem.Text = "Russian";
            englishToolStripMenuItem.Text = "English";
            Draw_button.Text = "Draw";
            ClearButton.Text = "Clean";
            int count = Figure_comboBox.Items.Count - 1;
            for (int i = 0; i <= count; i++)
            {
                Figure_comboBox.Items.RemoveAt(0);
            }
            foreach (var f in FigureList.figures)
            {
                Figure_comboBox.Items.Add(f.GetType().Name);
            }
            Figure_comboBox.SelectedItem = Figure_comboBox.Items[0];
            ThiknessLabel.Text = "Thikness";
            ContourLabel.Text = "Contour color";
            BrushLabel.Text = "Brush color";
            frm.ChangeTextToEnglish();
        }
    }
}
