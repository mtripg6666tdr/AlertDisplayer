using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlertDisplayer
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] arg = Environment.GetCommandLineArgs();
            if (arg.Length == 4)
            {
                MessageBoxIcon messageBoxIcon;
                if (Enum.TryParse<MessageBoxIcon>(arg[3], out messageBoxIcon))
                {
                    MessageBox.Show(arg[1], arg[2], MessageBoxButtons.OK, messageBoxIcon,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }
    }
}
