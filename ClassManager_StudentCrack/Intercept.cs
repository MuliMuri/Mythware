using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassManager_StudentCrack._Function;
using ClassManager_StudentCrack._Module;

namespace ClassManager_StudentCrack
{
    public partial class Intercept : Form
    {
        Bitmap[] InterceptIcons = new Bitmap[5];  // 功能图标
        Window window = new Window();
        string[] FuncTexts = new string[5];
        int Index;
        bool IsIntercept = true;

        private void LoadIcons()
        {
            InterceptIcons[0] = Properties.Resources.ScreenShow_Img;    // 屏幕广播
            InterceptIcons[1] = Properties.Resources.StdShow_Img;       // 学生演示
            InterceptIcons[2] = Properties.Resources.NetCinema_Img;     // 网络影院
            InterceptIcons[3] = Properties.Resources.NetVideo_Img;      // 视频直播
            InterceptIcons[4] = Properties.Resources.WhiteBoard_Img;    // 共享白板
        }

        private void LoadString()
        {
            FuncTexts[0] = Properties.Resources.ScreenShow_Str;
            FuncTexts[1] = Properties.Resources.StdShow_Str;
            FuncTexts[2] = Properties.Resources.NetCinema_Str;
            FuncTexts[3] = Properties.Resources.NetVideo_Str;
            FuncTexts[4] = Properties.Resources.WhiteBoard_Str;
        }

        private string MakeString()
        {
            string[] cut = FuncTexts[Index].Split('-');
            StringBuilder a = new StringBuilder(string.Format(Label_TextShow.Text, cut[0], cut[1], cut[0], cut[0]));
            return a.Replace("+~", "\r\n").ToString();  // +~即 换行
        }

        public Intercept(int Index)
        {
            this.Index = Index;

            LoadIcons();
            LoadString();

            InitializeComponent();
        }

        private void Intercept_Load(object sender, EventArgs e)
        {
            PictureBox_Icon.Image = InterceptIcons[Index];
            Label_TextShow.Text = MakeString();

            window.SetMyWindow(Handle);
        }

        private void Intercept_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;

            mainForm.IsIntercept = IsIntercept;
            mainForm.MytWndIndex = Index;
        }

        private void Button_Prevent_Click(object sender, EventArgs e)
        {
            IsIntercept = true;
            this.Close();
        }

        private void Button_Allow_Click(object sender, EventArgs e)
        {
            IsIntercept = false;
            this.Close();
        }
    }
}
