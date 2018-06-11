using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drawable;
using System.IO;

namespace lab1_oop
{
    public partial class UserFigureForm : Form
    {
        public List<Figure> drlist;
        public UserFigure uf;
        Serialization Picture = new Serialization();
        public UserFigureForm(List<Figure> drawList)
        {
            drlist = drawList;
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (drlist.Count >= 2)
            {
                uf = new UserFigure(NametextBox.Text);
                uf.Points = new List<Point>();
                foreach (var fig in drlist)
                {
                    uf.UserFigureList.Add(new CompositFigure(fig.Points) { Figure = fig });
                }
                uf.TopLeft = uf.UserFigureList[0].Points[0];
                foreach (var fig in uf.UserFigureList)
                {
                    foreach (var point in fig.Points)
                    {
                        if (uf.TopLeft.X > point.X)
                            uf.TopLeft.X = point.X;
                        if (uf.TopLeft.Y > point.Y)
                            uf.TopLeft.Y = point.Y;
                    }
                }
                foreach (var fig in uf.UserFigureList)
                {
                    for (var i  = 0; i < fig.Points.Count; i++)
                    {
                        var point = fig.Points[i];
                        point.X = point.X - uf.TopLeft.X;
                        point.Y = point.Y - uf.TopLeft.Y;
                        fig.Points[i] = point;
                    }
                }
                foreach (var fig in uf.UserFigureList)
                {
                    foreach (var point in fig.Points)
                    {
                        uf.Points.Add(point);
                    }
                }
                if (File.Exists("CustomFigures.dat"))
                {
                    var l = Picture.Deserialize("CustomFigures.dat");
                    l.Add(uf);
                    Picture.Serialize(l, "CustomFigures.dat");
                }
                else
                    Picture.Serialize(new List<Figure> { { uf } }, "CustomFigures.dat");
            }
            else
                MessageBox.Show("Figure count must be more than 2");
        }
    }
}
