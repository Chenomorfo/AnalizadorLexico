
using AnalizadorLexico.Utils;

namespace AnalizadorLexico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<Validaciones.Simbolo> tablaLexico = new();

        private async void button1_Click(object sender, EventArgs e)
        {
            tablaLexico = new();
            string myChain = rtbConsole.Text;
            string tokens = "";
            foreach (var line in myChain.Split("\n"))
            {
                Validaciones.Simbolo actual;
                string variable = "", tokenVar = "";
                bool esAsignacion = false;
                foreach (var word in line.Split(" "))
                {
                    if (word.Length == 0) break;

                    string temp = await utils.Analizador.ObtenerToken(word);

                    if (esAsignacion)
                    {
                        actual = new() { Lexema = variable, Token = tokenVar, Valor = word };
                        tablaLexico.Add(actual);
                    }
                    else if (temp == "OPAS :" && tokenVar == "IDEN")
                        esAsignacion = true;


                    if (temp == "IDEN")
                    {
                        variable = word;
                        tokenVar = temp;
                        tokens += $"<{temp}> ";
                    }
                    else if (tokenVar != "IDEN" && temp == "CONE" || temp == "CONR")
                    {
                        actual = new() { Lexema = word, Token = temp, Valor = word };
                        tokens += $"<{actual.Token}> ";
                        actual.Valor = word;
                        tablaLexico.Add(actual);
                    }
                    else tokens += $"<{temp}> ";

                }
                tokens += "\n";
            }

            dgvSimbolos.DataSource = tablaLexico;
            rtbDebug.Text = tokens;

        }

        private void rtbDebug_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            utils.Files.GuardarArchivo(rtbDebug.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validaciones.Simbolo.Save(tablaLexico);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvSimbolos.DataSource = Validaciones.Simbolo.Load();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            rtbDebug.Text = utils.Files.CargarArchivo();
        }

        private void guardarCodigo_Click(object sender, EventArgs e)
        {
            utils.Files.GuardarArchivo(rtbConsole.Text);
        }

        private void cargarCodigo_Click(object sender, EventArgs e)
        {
            rtbConsole.Text = utils.Files.CargarArchivo();
        }
    }
}
