using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());
        }
    }
    public struct Cliente
    {
        public static string colunaTele { get; set; }
        public static string coluna { get; set; }
        public static string colunaNome { get; set; }
        public static string colunaCNPJ { get; set; }
        public static string colunaEstacoes { get; set; }
        public static string colunaM2M { get; set; }
        public static string colunaTotal { get; set; }
        public static string colunaReferencia { get; set; }

    }
}
