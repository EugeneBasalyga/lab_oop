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
using System.Globalization;
using System.Threading;

namespace lab1_oop
{
    public partial class SaveConfig : Form
    {
        public SaveConfig(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

            InitializeComponent();
        }

    }
}
