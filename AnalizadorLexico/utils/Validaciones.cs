using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static AnalizadorLexico.Utils.Validaciones;

namespace AnalizadorLexico.Utils
{
    public class Validaciones
    {
        public class Simbolo
        {
            public string Lexema { get; set; }
            public string Token { get; set; }
            public string? Valor { get; set; }

            public static List<Simbolo>? Load()
            {
                string fileName = "";
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = @"~/Documentos";
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //string file = @"C:\Users\RedFrost\Documents\lexema.txt";
                    fileName = openFileDialog.FileName;
                }
                else return null;

                List<Simbolo> myFile = new List<Simbolo>();
                XmlSerializer formatter = new XmlSerializer(myFile.GetType());
                FileStream aFile = new FileStream(fileName, FileMode.Open);
                byte[] buffer = new byte[aFile.Length];
                aFile.Read(buffer, 0, (int)aFile.Length);
                MemoryStream stream = new MemoryStream(buffer);
                return (List<Simbolo>)formatter.Deserialize(stream);
            }


            public static void Save(List<Simbolo> myFile)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"~/Documentos";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    FileStream outFile = File.Create(fileName);
                    XmlSerializer formatter = new XmlSerializer(myFile.GetType());
                    formatter.Serialize(outFile, myFile);

                }
                //string path = @"C:\Users\RedFrost\Documents\lexema.txt";
            }

        }

        private static readonly Dictionary<string, string> dictionary = new()
        {
            {"0", "_0" },
            {"1", "_1" },
            {"2", "_2" },
            {"3", "_3" },
            {"4", "_4" },
            {"5", "_5" },
            {"6", "_6" },
            {"7", "_7" },
            {"8", "_8" },
            {"9", "_9" },
            {"@", "Arroba" },
            {"*", "Asterisco" },
            {"\\", "Backslash" },
            {"+", "Mas" },
            {"-", "Menos" },
            {"/", "Diagonal" },
            {"&", "Ampersand" },
            {"|", "Stick" },
            {"!", "Exclamacion" },
            {"=", "Igual" },
            {">", "MayorQue" },
            {"<", "MenorQue" },
            {":", "DosPuntos" },
            {"#", "Hash" },
            {"$", "Dinero" },
            {"%", "Porciento" },
            {".", "Punto" },
            {"\"", "DosComillas" },
        };
        public static Dictionary<string, string> validaciones = dictionary;
    }
}
