using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using Drawable;


namespace lab1_oop
{
    class Serialization
    {

        public void Serialize(List<Figure> FigureList, string FileName)
        {
            FileStream fs = null;
            BinaryFormatter serializer = new BinaryFormatter();
            try
            {
                fs = new FileStream(FileName, FileMode.Create);
                serializer.Serialize(fs, FigureList);
            }
            catch
            {
                MessageBox.Show("Save Error");
            }
            finally
            {
                if(fs != null)
                    fs.Close();
            }
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
            finally
            {
                fs.Close();
            }
            return DeserializedFigures;
        }
    }
}
