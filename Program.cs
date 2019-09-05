using ForumDesktop.View;
using ForumDesktop.View.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForumDesktop
{
    static class Program
    {
        public static string stringConexaoMySQL = "SERVER=localhost; PORT=3308; DATABASE=db_forum; UID=root; PWD=admin";
        public static string usuarioLogado = "mauricio";
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHome());
        }
    }
}
