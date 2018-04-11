using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace lab1_oop
{
    class Serialization
    {

        public void Serialize(List<Figure> FigureList, string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fs, FigureList);
            fs.Close();
        }


        public List<Figure> Deserialize(string FileName)
        {
            List<Figure> DeserializedFigures = null;
            BinaryFormatter serializer = new BinaryFormatter();

            FileStream fs = new FileStream(FileName, FileMode.Open);
            DeserializedFigures = (List<Figure>)(serializer.Deserialize(fs));
            fs.Close();
            return DeserializedFigures;
        }
    }
}
