using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico.utils
{
    public class Files
    {
        public static void GuardarArchivo(string dataString)
        {
            //string path = @"C:\Users\RedFrost\Documents\tokens.txt"; // path to file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"~/Documentos";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                using (FileStream fs = File.Create(fileName))
                {
                    // writing data in string                
                    byte[] info = new UTF8Encoding(true).GetBytes(dataString);
                    fs.Write(info, 0, info.Length);

                    // writing data in bytes already
                    byte[] data = new byte[] { 0x0 };
                    fs.Write(data, 0, data.Length);
                }
            }
        }

        public static string CargarArchivo()
        {
            //string path = @"C:\Users\RedFrost\Documents\tokens.txt"; // path to file
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
            return File.ReadAllText(fileName);
        }

    }
}
