using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

using ClassManager_StudentCrack._Chat;
using ClassManager_StudentCrack._Function;
using ClassManager_StudentCrack._Init;
using ClassManager_StudentCrack._NetWork;
using ClassManager_StudentCrack._Module;
using ClassManager_StudentCrack._Global;

namespace ClassManager_StudentCrack
{
    public partial class MainForm : Form
    {
        Global Global = new Global();
        
        

        public bool IsIntercept;
        public int MytWndIndex;

        private bool MythwareState;
        private List<Dictionary<string, string>> CardInfos;
        private Window window = new Window();
        private int InceptWndCount = 0;                         // 拦截对话框计数

        #region 重写WndProc
        private enum WM_MSG
        {
            WM_HOTKEY   =   0x312,  //窗口消息-热键
            WM_CREATE   =   0x1,    //窗口消息-创建
            WM_DESTROY  =   0x2     //窗口消息-销毁
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                // 热键事件
                case (int)WM_MSG.WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        // 窗口置顶ID
                        case HotKeys.Global.HotKeyIDs.WindowTop:
                            WindowState = FormWindowState.Normal;

                            // windowManager.TopWindow(Text);
                            
                            MainWin_CheckBox_TopWindow.Checked = true;
                            // MessageBox.Show("Ctrl + Alt + Shift + O");
                            break;

                        default:
                            break;
                    }
                    break;

                // 窗口创建事件
                case (int)WM_MSG.WM_CREATE:
                    // 自定义初始化
                    HotKeys.Global.Win.RegHotKey(Handle, HotKeys.Global.HotKeyIDs.WindowTop, HotKeys.Global.KeyModifiers.Ctrl | HotKeys.Global.KeyModifiers.Alt | HotKeys.Global.KeyModifiers.Shift, Keys.O);
                    break;

                // 窗口销毁事件
                case (int)WM_MSG.WM_DESTROY:
                    HotKeys.Global.Win.UnRegHotKey(Handle, HotKeys.Global.HotKeyIDs.WindowTop);
                    break;

                default:
                    break;
            }
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();

            Global.ProcessManager.ProcExit += Event_ProcExit;   // 绑定事件

            Global.ProcessManager.Add(Global.MythwareName);
            
            Global.WindowManager.Add(hWnd: this.Handle);
            //Global.WindowManager.TopWindow(Text);


        }

        private void Event_ProcExit(object sender, TaskCore.ProcessManager.ProcEventArgs e)
        {
            if (e.ProcName == Global.MythwareName)
            {
                SW_RunState_Label_State(0);
            }
        }

        // TODO: 日志类


        private void MythwareWindowRun()
        {
            // 挂起极域进程
            Global.ProcessManager.Suspend(Global.MythwareName);
            for (int i = 0; i < window.RunMytWnds.Count; i++)
            {
                Intercept intercept = new Intercept(window.RunMytWnds[i]);
                intercept.FormClosed += InterceptFormClosed;
                intercept.Show(this);
                InceptWndCount ++;
            }
        }

        private void InterceptFormClosed(object sender, FormClosedEventArgs e)
        {
            InceptWndCount --;
            if (IsIntercept)
            {
                // 需要拦截
                window.InceptMytwnds.Add(MytWndIndex);
            }
            else
            {
                // 加入单次允许白名单
                window.AllowMytwnds.Add(MytWndIndex);
            }

            // 全部选择完再处理
            if (InceptWndCount == 0)
            {
                // 释放极域进程
                Global.ProcessManager.Resume(Global.MythwareName);

                window.SetMythwareWindow();
            }
        }


        #region MainWin

        #region Menu
        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        #endregion
        // 窗口置顶复选框
        private void CheckBox_TopWindow_CheckStateChanged(object sender, EventArgs e)
        {
            if (!MainWin_CheckBox_TopWindow.Checked)
            {
                DialogResult result = MessageBox.Show(
                    "确定取消窗口置顶？\n注：取消后若被教师广播，可使用快捷键 Ctrl+Alt+Shift+O 重新置顶",
                    "警告",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                    );

                if (result == DialogResult.Yes)
                {
                    window.IsTop = false;
                    // TODO：日志
                }
                else
                {
                    MainWin_CheckBox_TopWindow.Checked = true;
                }
            }
            else
            {
                window.IsTop = true;
            }
        }
        #endregion

        #region RunState
        private void RunState_Button_StateFresh_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Usual
        private void Usual_Button_ShutdownTask_Click(object sender, EventArgs e)
        {
            if (Global.ProcessManager.Kill(Global.MythwareName))
            {
                MythwareState = false;
                RunState_Label_State.Text = "STOPPING";
                RunState_Label_State.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
            
            }
        }
        #endregion

        #region Net

        #endregion

        #region Chat

        #endregion

        #region File

        #endregion

        #region Shell

        #endregion

        #region Sundry

        /// <summary>
        /// 状态标签切换
        /// </summary>
        /// <param name="State">
        /// <para>0: STOPPING</para>
        /// <para>1: RUNNING</para>
        /// </param>
        private void SW_RunState_Label_State(int State)
        {
            switch (State)
            {
                case 0:
                    // STOPPING
                    RunState_Label_State.Text = "STOPPING";
                    RunState_Label_State.BackColor = System.Drawing.Color.LightGreen;
                    break;

                case 1:
                    // RUNNING
                    RunState_Label_State.Text = "RUNNING";
                    RunState_Label_State.BackColor = System.Drawing.Color.LightCoral;
                    break;

                default:
                    break;
            }
        }

        #endregion


        private void ToolStripMenuItem_LogTextBox_Clear_Click(object sender, EventArgs e)
        {
            MainWin_TextBox_Log.Text = null;
        }

        

        

        

        private void Net_Button_CardFresh_Click(object sender, EventArgs e)
        {
            Net_ComboBox_Card.Items.Clear();
            // TODO: 更新获取网卡函数
            if (NetInfo.GetNetWorkCard(out CardInfos))
            {
                // True
                for (int i = 0; i < CardInfos.Count; i++)
                {
                    string Item = string.Format("[{0}] -- {1} -- {2}",
                        CardInfos[i]["CardType"],
                        CardInfos[i]["Name"],
                        CardInfos[i]["InterFaceType"]);

                    Net_ComboBox_Card.Items.Add(Item);

                }
                Net_ComboBox_Card.SelectedIndex = 0;
            }
            else
            {
                Net_ComboBox_Card.Items.Add("Unknow");
                Net_ComboBox_Card.SelectedIndex = 0;
                MessageBox.Show("网卡信息获取失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Net_ComboBox_Card_SelectedValueChanged(object sender, EventArgs e)
        {
            List<string> IPInfo = NetInfo.GetIPInfo(CardInfos[Net_ComboBox_Card.SelectedIndex]["IP"], CardInfos[Net_ComboBox_Card.SelectedIndex]["Mask"]);

            Net_Label_IPPart.Text = string.Format("{0}--{1}", IPInfo[0], IPInfo[1]);
            Net_Label_IPMask.Text = CardInfos[Net_ComboBox_Card.SelectedIndex]["Mask"];
        }

        private void ToolStripMenuItem_NetShow_Clear_Click(object sender, EventArgs e)
        {
            Net_ListView_DevShow.Items.Clear();
        }

        private void Timer_GetSystemTime_Tick(object sender, EventArgs e)
        {
            // 判断窗口状态
            if (window.IsTop != window.LastIsTop)
            {
                // 切换
                window.SetMyWindow(Handle);
                window.LastIsTop = window.IsTop;
            }
            // 检测极域窗口
            if(window.CheckMythwareWindow())
            {
                if (!window.IsDialog)
                {
                    // 防止多次弹窗鬼畜
                    window.IsDialog = true;
                    MythwareWindowRun();
                }
            }

            // 更新标签时钟
            MainWin_Label_Time.Text = DateTime.Now.ToLocalTime().ToString();

            // 更新双端信息
            RunState_TextBox_LocalIP.Text = Infos.NetWork.LocalIP;

            // 检测运行状态
            if (!MythwareState) // false 启动获取
            {
                MythwareState = Init.GetMythwareRunState();
                if (MythwareState)
                {
                    RunState_Label_State.Text = "RUNNING";
                    RunState_Label_State.BackColor = System.Drawing.Color.LightCoral;
                }
            }
        }

        private void Net_Button_Scan_Click(object sender, EventArgs e)
        {
            // TODO: ARP协议 设备获取
        }

        private void TextBox_ChatInput_KeyDown(object sender, KeyEventArgs e)
        {
            // HotKeys.Form.Chat.Key_SendMsg(e);
        }

        private void Chat_Button_Send_Click(object sender, EventArgs e)
        {
            if (Chat_TextBox_Input.Text == "")
            {
                MessageBox.Show("不能发送空信息", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Chat.SendMsg(Chat_TextBox_Input.Text, "172.168.214.2"))// TODO: 更换IP
            {
                Chat_TextBox_Input.Text = "";
            }
            else
            {
                MessageBox.Show("内部错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
