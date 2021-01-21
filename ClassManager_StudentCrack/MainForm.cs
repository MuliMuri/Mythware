using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

using ClassManager_StudentCrack.Function;
using ClassManager_StudentCrack.Init;

namespace ClassManager_StudentCrack
{
    public partial class MainForm : Form
    {
        // 局部变量声明
        private bool MythwareState;

        // 重写WndProc
        private const int WM_HOTKEY = 0x312;    //窗口消息-热键
        private const int WM_CREATE = 0x1;      //窗口消息-创建
        private const int WM_DESTROY = 0x2;     //窗口消息-销毁
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                // 热键事件
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        // 窗口置顶ID
                        case HotKeys.Global.HotKeyIDs.WindowTop:
                            MessageBox.Show("Ctrl + Alt + Shift + O");
                            break;

                        default:
                            break;
                    }
                    break;

                // 窗口创建事件
                case WM_CREATE:
                    // 自定义初始化
                    HotKeys.Global.Win.RegHotKey(
                        Handle,
                        HotKeys.Global.HotKeyIDs.WindowTop,
                        HotKeys.Global.KeyModifiers.Ctrl | HotKeys.Global.KeyModifiers.Alt | HotKeys.Global.KeyModifiers.Shift,
                        Keys.O
                    );
                    break;

                // 窗口销毁事件
                case WM_DESTROY:
                    HotKeys.Global.Win.UnRegHotKey(
                        Handle,
                        HotKeys.Global.HotKeyIDs.WindowTop
                        );
                    break;

                default:
                    break;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Chat.SaveChatEXE.CreateCodeEXE();
        }

        private void ToolStripMenuItem_LogTextBox_Clear_Click(object sender, EventArgs e)
        {
            MainWin_TextBox_Log.Text = null;
        }

        private void CheckBox_TopWindow_CheckStateChanged(object sender, EventArgs e)
        {
            if (MainWin_CheckBox_TopWindow.CheckState == CheckState.Unchecked)
            {
                DialogResult result = MessageBox.Show("确定取消窗口置顶？\n注：取消后若被教师广播，可使用快捷键 Ctrl+Alt+Shift+O 重新置顶", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes) return;
                else MainWin_CheckBox_TopWindow.CheckState = CheckState.Checked;
            }
        }

        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void Usual_Button_ShutdownTask_Click(object sender, EventArgs e)
        {
            Logs.SetTextBox(MainWin_TextBox_Log);
            Logs.WriteLogHead(3);
            Process[] Mythware_StudentMain = Process.GetProcessesByName("StudentMain");
            if (Mythware_StudentMain.Length != 0)
            {
                for (int i = 0; i < Mythware_StudentMain.Length; i++)
                {
                    if (!MemCore.ProcessManager.KillProcess(Mythware_StudentMain[i].Id, true))
                    {
                        Logs.WriteLog(String.Format("Error! -> 结束进程{0}失败", Mythware_StudentMain[i].Id));
                        Logs.WriteLog(String.Format("错误代码：{0}", Marshal.GetLastWin32Error().ToString()));
                    }
                    else
                    {
                        Logs.WriteLog(String.Format("Success! -> 结束进程{0}成功", Mythware_StudentMain[i].Id));
                    }
                }
                MythwareState = false;
                RunState_Label_State.Text = "STOPPING";
                RunState_Label_State.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                Logs.WriteLog("未找到 极域电子教室 进程");
            }
            Logs.WriteLogEnd();
        }

        private void Net_Button_CardFresh_Click(object sender, EventArgs e)
        {
            Net_ComboBox_Card.Items.Clear();
            NetworkInterface[] NetCard = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < NetCard.Length; i++)
            {
                Net_ComboBox_Card.Items.Add(NetCard[i].Description);
            }
            Net_ComboBox_Card.SelectedIndex = 0;
        }

        private void ToolStripMenuItem_NetShow_Clear_Click(object sender, EventArgs e)
        {
            Net_ListView_DevShow.Items.Clear();
        }

        private void Timer_GetSystemTime_Tick(object sender, EventArgs e)
        {
            // 更新标签时钟
            MainWin_Label_Time.Text = DateTime.Now.ToLocalTime().ToString();

            // 更新 双端 信息
            RunState_TextBox_LocalIP.Text = Infos.LocalIP;

            // 检测运行状态
            
            if (!MythwareState) // false 启动获取
            {
                MythwareState = _Init.GetMythwareRunState();
                if (MythwareState)
                {
                    RunState_Label_State.Text = "RUNNING";
                    RunState_Label_State.BackColor = System.Drawing.Color.LightCoral;
                }
            }
        }

        private void Net_Button_Scan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NetWork.NetWork.GetConState().ToString());
        }

        private void TextBox_ChatInput_KeyDown(object sender, KeyEventArgs e)
        {
            HotKeys.Form.Chat.Key_SendMsg(e);
        }

        private void Chat_Button_Send_Click(object sender, EventArgs e)
        {
            //TODO: 发送信息 函数
        }

        private void RunState_Button_StateFresh_Click(object sender, EventArgs e)
        {

        }

        private void Usual_Button_StartTask_Click(object sender, EventArgs e)
        {

        }

        private void Usual_Button_ReadPasswd_Click(object sender, EventArgs e)
        {

        }

        private void File_Button_SendStart_Click(object sender, EventArgs e)
        {

        }

        private void File_Button_SendStop_Click(object sender, EventArgs e)
        {

        }

        private void Shell_RichTextBox_CMDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                // 按下 Enter 键
            }
        }

        private void File_TreeView_LocalShow_Enter(object sender, EventArgs e)
        {
            // 刷新 TreeView
            
            
        }
    }
}
