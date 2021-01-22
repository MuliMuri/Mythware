using System;
using System.Windows.Forms;

namespace ClassManager_StudentCrack._Chat.Template
{
    class Reply
    {
        /// <summary>
        /// Reply 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Reply_Form());
        }
    }
}
