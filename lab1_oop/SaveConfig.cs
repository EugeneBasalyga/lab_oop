using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lab1_oop
{
    public partial class SaveConfig : Form
    {
        public SaveConfig()
        {
            InitializeComponent();
        }

        public void ChangeTextToRussian()
        {
            SaveConfigLabel.Text = "Сохранить настройки ?";
            buttonYes.Text = "Да";
            buttonNo.Text = "Нет";
        }
        public void ChangeTextToEnglish()
        {
            SaveConfigLabel.Text = "Save Configuration ?";
            buttonYes.Text = "Yes";
            buttonNo.Text = "No";
        }
        public void SaveText(XmlDocument doc, XmlNode lng)
        {
            XmlNode saveconfiglabel = doc.CreateElement("saveconfiglabel");
            saveconfiglabel.InnerText = SaveConfigLabel.Text;
            lng.AppendChild(saveconfiglabel);

            XmlNode buttonyes = doc.CreateElement("buttonyes");
            buttonyes.InnerText = buttonYes.Text;
            lng.AppendChild(buttonyes);

            XmlNode buttonno = doc.CreateElement("buttonno");
            buttonno.InnerText = buttonNo.Text;
            lng.AppendChild(buttonno);
        }

        public void LoadText(XmlNode nd)
        {
            SaveConfigLabel.Text = (nd["saveconfiglabel"].InnerText);
            buttonYes.Text = (nd["buttonyes"].InnerText);
            buttonNo.Text = (nd["buttonno"].InnerText);
        }
    }
}
