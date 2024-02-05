using AnalizadorLexico.Models;
using AnalizadorLexico.Utils;
using Microsoft.EntityFrameworkCore;

namespace AnalizadorLexico.utils
{
    public class Analizador
    {

        public static string? EvaluarSimbolo(string simbolo)
        {
            try { return Validaciones.validaciones[simbolo]; }
            catch (Exception) { return null; }
        }

        public static async Task<string> ObtenerToken(string palabra)
        {
            LexicoContext ctx = new LexicoContext();

            int estado = 0;
            bool esVariable = palabra.StartsWith("@");
            bool esComentario = palabra.StartsWith("\\*") && palabra.EndsWith("*\\");
            bool esCartel = palabra.StartsWith("\"") && palabra.EndsWith("\"");
            foreach (char letra in palabra)
            {
                char myVar = esVariable || esComentario || esCartel ? Char.ToUpper(letra) : letra;
                var analisis = await ctx.Matrizs.FirstAsync(x => x.Estado == estado);
                string? simbolo = EvaluarSimbolo(letra.ToString());

                try
                {
                var resultado = analisis.GetType()?
                    .GetProperty(simbolo ?? myVar.ToString())?
                    .GetValue(analisis, null);
                    if (resultado is not null)
                        estado = int.Parse(resultado.ToString());
                    else estado = 106;
                }
                catch (Exception)
                {

                    return "ERR";
                }
            }

            var fdc = await ctx.Matrizs.FirstAsync(x => x.Estado == estado);

            var resFDC = fdc.GetType()?.GetProperty("Fdc")?.GetValue(fdc, null);

            try { return Tokens.Diccionary[int.Parse(resFDC.ToString())]; }
            catch (Exception) { return "ERR"; }
        }
    }
}
