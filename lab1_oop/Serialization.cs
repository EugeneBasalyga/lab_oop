using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace lab1_oop
{
    class Serialization
    {

        public void Serialize(List<Figure> FigureList, string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            try
            {
                serializer.Serialize(fs, FigureList);
            }
            catch
            {
                MessageBox.Show("Save Error");
            }
            fs.Close();
        }


        public List<Figure> Deserialize(string FileName)
        {
            List<Figure> DeserializedFigures = null;
            BinaryFormatter serializer = new BinaryFormatter();
            

            FileStream fs = new FileStream(FileName, FileMode.Open);
            try
            {
                DeserializedFigures = (List<Figure>)(serializer.Deserialize(fs));
            }
            catch
            {
                MessageBox.Show("Open Error");
            }
            fs.Close();
            return DeserializedFigures;
        }
    }
}
