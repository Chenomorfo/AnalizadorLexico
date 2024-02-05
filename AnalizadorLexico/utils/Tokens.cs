using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico.utils
{
    public class Tokens
    {
        public static readonly Dictionary<int, string> Diccionary = new Dictionary<int, string>()
        {
            // Identificadores y comentarios
            {4,     "PR01 INI" }, //Inicio
            {7,     "PR11 IMP" }, //Imprimir
            {11,    "PR02 ENT" }, //Entero
            {15,    "PR03 REA" }, //Real
            {19,    "PR04 FEC" },
            {22,    "PR05 FVB" },
            {52,    "PR15 FIN" }, //Fin
            {26,    "PR06 CAR" },
            {28,    "PR01 CAD" },
            {32,    "PR01 SIP" },
            {34,    "PR01 SIN" },
            {38,    "PR01 LER" },
            {42,    "PR01 MIE" },  //While
            {45,    "PR01 MSI" }, //DO-While
            {49,    "PR01 PAR" }, //For
            //Identificadores y comentarios
            {55,    "IDEN" },
            {60,    "COMM" },
            {61,    "CE01 \\" },
            // Operadores aritmeticos
            {63,    "OA01 +" }, // sum
            {65,    "OA02 -" }, //sub
            {67,    "OA03 /" }, // div
            {69,    "OA04 *" }, //mul
            // Operadores logicos
            {71,    "OL01 &" }, // AND
            {73,    "OL02 |" }, // OR
            {75,    "OL03 !" }, // NOT
            // Operadores relacionales y de asignacion
            {78,    "OR01 ==" }, //Equals
            {80,    "OR02 >" }, //Greater
            {82,    "OR04 >=" }, //Greater/equals
            {84,    "OR03 <" }, // Less
            {86,    "OR05 <=" }, // Less/equals
            {88,    "OPAS :" }, // set ( dataType dataName: dataValue ; example => @MyAge ENT: 21)
            // Constantes enteros y reales
            {90,    "CONE" },
            {93,    "CONR" },
            //Caracteres especiales
            {95,    "CE02 #" },
            {97,    "CE03 $" },
            {99,    "CE04 %" },
            {101,   "CE05 ." },
            // Letreros (Strings)
            {105,   "LETR" },
            {106,   "ERR" }, //Error
        };
    }
}
