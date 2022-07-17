using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japonstina.models
{
    public static class StavAplikace /*Uklada ID otevrene formy*/
    {
        public static string ActiveForm { get; set; } 
    }

    public class VyberCviceni
    {
        public static string btn;

        public static bool Hiragana { get; set; }
        public static bool Katakana { get; set; }
        public static bool N5 { get; set; }
        public static bool N4 { get; set; }
        public static bool Ichidan { get; set; }
        public static bool Godan { get; set; }
        public static bool Irregular { get; set; }

    }
}
