
namespace ClassManager_StudentCrack
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "PC_01",
            "192.168.1.1",
            "存活"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "PC_02",
            "192.168.1.2",
            "死亡"}, -1);
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Windows");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("本地磁盘（C:）", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("本地磁盘（D:）");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("此电脑", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_RunInfo = new System.Windows.Forms.TabPage();
            this.RunState_Button_StateFresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RunState_Label_WebState = new System.Windows.Forms.Label();
            this.RunState_Label_NetState = new System.Windows.Forms.Label();
            this.RunState_Label_FireWallState = new System.Windows.Forms.Label();
            this.RunState_TextBox_LocalGateWay = new System.Windows.Forms.TextBox();
            this.RunState_TextBox_LocalMac = new System.Windows.Forms.TextBox();
            this.RunState_TextBox_LocalIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RunState_Label_State = new System.Windows.Forms.Label();
            this.tabPage_Functions = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Usual_TabControl_ProtectInfo = new System.Windows.Forms.TabControl();
            this.TabPage_Control = new System.Windows.Forms.TabPage();
            this.TabPage_Power = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Usual_Button_StartTask = new System.Windows.Forms.Button();
            this.Usual_Button_ShutdownTask = new System.Windows.Forms.Button();
            this.Usual_Button_WritePasswd = new System.Windows.Forms.Button();
            this.Usual_Button_ReadPasswd = new System.Windows.Forms.Button();
            this.Usual_TextBox_ShowPasswd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage_NetScan = new System.Windows.Forms.TabPage();
            this.Net_Label_IPMask = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Net_Label_IPPart = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Net_Button_Scan = new System.Windows.Forms.Button();
            this.Net_Button_CardFresh = new System.Windows.Forms.Button();
            this.Net_ListView_DevShow = new System.Windows.Forms.ListView();
            this.PC_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PC_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PC_State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Right_ClickContextMenuStrip_NetShow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_NetShow_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.Net_ComboBox_Card = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage_NetCom = new System.Windows.Forms.TabPage();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage_Msg = new System.Windows.Forms.TabPage();
            this.Chat_Button_Send = new System.Windows.Forms.Button();
            this.Chat_TextBox_Input = new System.Windows.Forms.TextBox();
            this.Chat_RichTextBox_Show = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Chat_RadioButton_SendMode_UnAnonymous = new System.Windows.Forms.RadioButton();
            this.Chat_RadioButton_SendMode_Anonymous = new System.Windows.Forms.RadioButton();
            this.Chat_CheckBox_SendMode_IsBack = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Chat_NumUpDown_SendLoop = new System.Windows.Forms.NumericUpDown();
            this.Chat_CheckBox_SendMode_Loop = new System.Windows.Forms.CheckBox();
            this.TabPage_File = new System.Windows.Forms.TabPage();
            this.File_Button_SendStart = new System.Windows.Forms.Button();
            this.File_Button_SendStop = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.File_ProgressBar_AllProg = new System.Windows.Forms.ProgressBar();
            this.label17 = new System.Windows.Forms.Label();
            this.File_ProgressBar_CurrProg = new System.Windows.Forms.ProgressBar();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.File_TreeView_LocalShow = new System.Windows.Forms.TreeView();
            this.File_ImageList_Icon = new System.Windows.Forms.ImageList(this.components);
            this.File_ListView_NetTask = new System.Windows.Forms.ListView();
            this.TabPage_Shell = new System.Windows.Forms.TabPage();
            this.Shell_RichTextBox_CMDBox = new System.Windows.Forms.RichTextBox();
            this.MainWin_CheckBox_TopWindow = new System.Windows.Forms.CheckBox();
            this.MainWin_Label_Time = new System.Windows.Forms.Label();
            this.MainWin_TextBox_Log = new System.Windows.Forms.TextBox();
            this.RightClick_ContextMenuStrip_LogTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_LogTextBox_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_LogTextBox_ExpLog = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWin_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Back_Timer_GetSystemTime = new System.Windows.Forms.Timer(this.components);
            this.File_ContextMenuStrip_Treeview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl1.SuspendLayout();
            this.tabPage_RunInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_Functions.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Usual_TabControl_ProtectInfo.SuspendLayout();
            this.TabPage_Power.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage_NetScan.SuspendLayout();
            this.Right_ClickContextMenuStrip_NetShow.SuspendLayout();
            this.tabPage_NetCom.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage_Msg.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chat_NumUpDown_SendLoop)).BeginInit();
            this.TabPage_File.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.TabPage_Shell.SuspendLayout();
            this.RightClick_ContextMenuStrip_LogTextBox.SuspendLayout();
            this.MainWin_MenuStrip.SuspendLayout();
            this.File_ContextMenuStrip_Treeview.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabControl1.Controls.Add(this.tabPage_RunInfo);
            this.TabControl1.Controls.Add(this.tabPage_Functions);
            this.TabControl1.Controls.Add(this.tabPage_NetScan);
            this.TabControl1.Controls.Add(this.tabPage_NetCom);
            this.TabControl1.HotTrack = true;
            this.TabControl1.Location = new System.Drawing.Point(0, 25);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(457, 367);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 1;
            // 
            // tabPage_RunInfo
            // 
            this.tabPage_RunInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage_RunInfo.Controls.Add(this.RunState_Button_StateFresh);
            this.tabPage_RunInfo.Controls.Add(this.groupBox2);
            this.tabPage_RunInfo.Controls.Add(this.groupBox1);
            this.tabPage_RunInfo.Controls.Add(this.RunState_Label_State);
            this.tabPage_RunInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RunInfo.Name = "tabPage_RunInfo";
            this.tabPage_RunInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RunInfo.Size = new System.Drawing.Size(449, 341);
            this.tabPage_RunInfo.TabIndex = 0;
            this.tabPage_RunInfo.Text = "运行状态";
            this.tabPage_RunInfo.UseVisualStyleBackColor = true;
            // 
            // RunState_Button_StateFresh
            // 
            this.RunState_Button_StateFresh.Location = new System.Drawing.Point(391, 126);
            this.RunState_Button_StateFresh.Name = "RunState_Button_StateFresh";
            this.RunState_Button_StateFresh.Size = new System.Drawing.Size(50, 25);
            this.RunState_Button_StateFresh.TabIndex = 3;
            this.RunState_Button_StateFresh.Text = "刷新";
            this.RunState_Button_StateFresh.UseVisualStyleBackColor = true;
            this.RunState_Button_StateFresh.Click += new System.EventHandler(this.RunState_Button_StateFresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RunState_Label_WebState);
            this.groupBox2.Controls.Add(this.RunState_Label_NetState);
            this.groupBox2.Controls.Add(this.RunState_Label_FireWallState);
            this.groupBox2.Controls.Add(this.RunState_TextBox_LocalGateWay);
            this.groupBox2.Controls.Add(this.RunState_TextBox_LocalMac);
            this.groupBox2.Controls.Add(this.RunState_TextBox_LocalIP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(231, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生端信息";
            // 
            // RunState_Label_WebState
            // 
            this.RunState_Label_WebState.AutoSize = true;
            this.RunState_Label_WebState.BackColor = System.Drawing.Color.LightCoral;
            this.RunState_Label_WebState.Font = new System.Drawing.Font("宋体", 9F);
            this.RunState_Label_WebState.Location = new System.Drawing.Point(101, 120);
            this.RunState_Label_WebState.Name = "RunState_Label_WebState";
            this.RunState_Label_WebState.Padding = new System.Windows.Forms.Padding(2);
            this.RunState_Label_WebState.Size = new System.Drawing.Size(39, 16);
            this.RunState_Label_WebState.TabIndex = 12;
            this.RunState_Label_WebState.Text = "False";
            // 
            // RunState_Label_NetState
            // 
            this.RunState_Label_NetState.AutoSize = true;
            this.RunState_Label_NetState.BackColor = System.Drawing.Color.LightGreen;
            this.RunState_Label_NetState.Font = new System.Drawing.Font("宋体", 9F);
            this.RunState_Label_NetState.Location = new System.Drawing.Point(101, 100);
            this.RunState_Label_NetState.Name = "RunState_Label_NetState";
            this.RunState_Label_NetState.Padding = new System.Windows.Forms.Padding(2);
            this.RunState_Label_NetState.Size = new System.Drawing.Size(33, 16);
            this.RunState_Label_NetState.TabIndex = 11;
            this.RunState_Label_NetState.Text = "True";
            // 
            // RunState_Label_FireWallState
            // 
            this.RunState_Label_FireWallState.AutoSize = true;
            this.RunState_Label_FireWallState.BackColor = System.Drawing.Color.LightGreen;
            this.RunState_Label_FireWallState.Font = new System.Drawing.Font("宋体", 9F);
            this.RunState_Label_FireWallState.Location = new System.Drawing.Point(101, 80);
            this.RunState_Label_FireWallState.Name = "RunState_Label_FireWallState";
            this.RunState_Label_FireWallState.Padding = new System.Windows.Forms.Padding(2);
            this.RunState_Label_FireWallState.Size = new System.Drawing.Size(33, 16);
            this.RunState_Label_FireWallState.TabIndex = 10;
            this.RunState_Label_FireWallState.Text = "启用";
            // 
            // RunState_TextBox_LocalGateWay
            // 
            this.RunState_TextBox_LocalGateWay.BackColor = System.Drawing.SystemColors.GrayText;
            this.RunState_TextBox_LocalGateWay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RunState_TextBox_LocalGateWay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RunState_TextBox_LocalGateWay.Location = new System.Drawing.Point(41, 63);
            this.RunState_TextBox_LocalGateWay.Name = "RunState_TextBox_LocalGateWay";
            this.RunState_TextBox_LocalGateWay.ReadOnly = true;
            this.RunState_TextBox_LocalGateWay.Size = new System.Drawing.Size(100, 14);
            this.RunState_TextBox_LocalGateWay.TabIndex = 9;
            this.RunState_TextBox_LocalGateWay.Text = "192.168.1.1";
            this.RunState_TextBox_LocalGateWay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RunState_TextBox_LocalGateWay.WordWrap = false;
            // 
            // RunState_TextBox_LocalMac
            // 
            this.RunState_TextBox_LocalMac.BackColor = System.Drawing.SystemColors.GrayText;
            this.RunState_TextBox_LocalMac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RunState_TextBox_LocalMac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RunState_TextBox_LocalMac.Location = new System.Drawing.Point(41, 43);
            this.RunState_TextBox_LocalMac.Name = "RunState_TextBox_LocalMac";
            this.RunState_TextBox_LocalMac.ReadOnly = true;
            this.RunState_TextBox_LocalMac.Size = new System.Drawing.Size(120, 14);
            this.RunState_TextBox_LocalMac.TabIndex = 8;
            this.RunState_TextBox_LocalMac.Text = "FF-FF-FF-FF-FF-FF";
            this.RunState_TextBox_LocalMac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RunState_TextBox_LocalMac.WordWrap = false;
            // 
            // RunState_TextBox_LocalIP
            // 
            this.RunState_TextBox_LocalIP.BackColor = System.Drawing.SystemColors.GrayText;
            this.RunState_TextBox_LocalIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RunState_TextBox_LocalIP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RunState_TextBox_LocalIP.Location = new System.Drawing.Point(41, 20);
            this.RunState_TextBox_LocalIP.Name = "RunState_TextBox_LocalIP";
            this.RunState_TextBox_LocalIP.ReadOnly = true;
            this.RunState_TextBox_LocalIP.Size = new System.Drawing.Size(100, 14);
            this.RunState_TextBox_LocalIP.TabIndex = 7;
            this.RunState_TextBox_LocalIP.Text = "192.168.1.1";
            this.RunState_TextBox_LocalIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RunState_TextBox_LocalIP.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "网页访问状态：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Internet状态：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "防火墙状态：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "网关：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mac：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP：";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "教师端信息";
            // 
            // RunState_Label_State
            // 
            this.RunState_Label_State.BackColor = System.Drawing.Color.LightGreen;
            this.RunState_Label_State.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RunState_Label_State.Location = new System.Drawing.Point(8, 8);
            this.RunState_Label_State.Name = "RunState_Label_State";
            this.RunState_Label_State.Size = new System.Drawing.Size(433, 143);
            this.RunState_Label_State.TabIndex = 0;
            this.RunState_Label_State.Text = "STOPPING";
            this.RunState_Label_State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_Functions
            // 
            this.tabPage_Functions.Controls.Add(this.groupBox4);
            this.tabPage_Functions.Controls.Add(this.groupBox3);
            this.tabPage_Functions.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Functions.Name = "tabPage_Functions";
            this.tabPage_Functions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Functions.Size = new System.Drawing.Size(449, 341);
            this.tabPage_Functions.TabIndex = 1;
            this.tabPage_Functions.Text = "常用功能";
            this.tabPage_Functions.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Usual_TabControl_ProtectInfo);
            this.groupBox4.Location = new System.Drawing.Point(11, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 183);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "隐私保护";
            // 
            // Usual_TabControl_ProtectInfo
            // 
            this.Usual_TabControl_ProtectInfo.Controls.Add(this.TabPage_Control);
            this.Usual_TabControl_ProtectInfo.Controls.Add(this.TabPage_Power);
            this.Usual_TabControl_ProtectInfo.Location = new System.Drawing.Point(6, 20);
            this.Usual_TabControl_ProtectInfo.Name = "Usual_TabControl_ProtectInfo";
            this.Usual_TabControl_ProtectInfo.SelectedIndex = 0;
            this.Usual_TabControl_ProtectInfo.Size = new System.Drawing.Size(418, 157);
            this.Usual_TabControl_ProtectInfo.TabIndex = 0;
            // 
            // TabPage_Control
            // 
            this.TabPage_Control.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Control.Name = "TabPage_Control";
            this.TabPage_Control.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Control.Size = new System.Drawing.Size(410, 131);
            this.TabPage_Control.TabIndex = 0;
            this.TabPage_Control.Text = "监控保护";
            this.TabPage_Control.UseVisualStyleBackColor = true;
            // 
            // TabPage_Power
            // 
            this.TabPage_Power.Controls.Add(this.label13);
            this.TabPage_Power.Controls.Add(this.label2);
            this.TabPage_Power.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Power.Name = "TabPage_Power";
            this.TabPage_Power.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Power.Size = new System.Drawing.Size(410, 131);
            this.TabPage_Power.TabIndex = 1;
            this.TabPage_Power.Text = "权限管理";
            this.TabPage_Power.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "U盘限制：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "网页访问限制：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Usual_Button_StartTask);
            this.groupBox3.Controls.Add(this.Usual_Button_ShutdownTask);
            this.groupBox3.Controls.Add(this.Usual_Button_WritePasswd);
            this.groupBox3.Controls.Add(this.Usual_Button_ReadPasswd);
            this.groupBox3.Controls.Add(this.Usual_TextBox_ShowPasswd);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 75);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "进程操作";
            // 
            // Usual_Button_StartTask
            // 
            this.Usual_Button_StartTask.Location = new System.Drawing.Point(8, 46);
            this.Usual_Button_StartTask.Name = "Usual_Button_StartTask";
            this.Usual_Button_StartTask.Size = new System.Drawing.Size(223, 23);
            this.Usual_Button_StartTask.TabIndex = 12;
            this.Usual_Button_StartTask.Text = "启动进程";
            this.Usual_Button_StartTask.UseVisualStyleBackColor = true;
            this.Usual_Button_StartTask.Click += new System.EventHandler(this.Usual_Button_StartTask_Click);
            // 
            // Usual_Button_ShutdownTask
            // 
            this.Usual_Button_ShutdownTask.Location = new System.Drawing.Point(231, 46);
            this.Usual_Button_ShutdownTask.Name = "Usual_Button_ShutdownTask";
            this.Usual_Button_ShutdownTask.Size = new System.Drawing.Size(196, 23);
            this.Usual_Button_ShutdownTask.TabIndex = 11;
            this.Usual_Button_ShutdownTask.Text = "结束进程";
            this.Usual_Button_ShutdownTask.UseVisualStyleBackColor = true;
            this.Usual_Button_ShutdownTask.Click += new System.EventHandler(this.Usual_Button_ShutdownTask_Click);
            // 
            // Usual_Button_WritePasswd
            // 
            this.Usual_Button_WritePasswd.Font = new System.Drawing.Font("宋体", 9F);
            this.Usual_Button_WritePasswd.Location = new System.Drawing.Point(231, 13);
            this.Usual_Button_WritePasswd.Name = "Usual_Button_WritePasswd";
            this.Usual_Button_WritePasswd.Size = new System.Drawing.Size(41, 20);
            this.Usual_Button_WritePasswd.TabIndex = 10;
            this.Usual_Button_WritePasswd.Text = "写入";
            this.Usual_Button_WritePasswd.UseVisualStyleBackColor = true;
            // 
            // Usual_Button_ReadPasswd
            // 
            this.Usual_Button_ReadPasswd.Font = new System.Drawing.Font("宋体", 9F);
            this.Usual_Button_ReadPasswd.Location = new System.Drawing.Point(190, 13);
            this.Usual_Button_ReadPasswd.Name = "Usual_Button_ReadPasswd";
            this.Usual_Button_ReadPasswd.Size = new System.Drawing.Size(41, 20);
            this.Usual_Button_ReadPasswd.TabIndex = 9;
            this.Usual_Button_ReadPasswd.Text = "读取";
            this.Usual_Button_ReadPasswd.UseVisualStyleBackColor = true;
            this.Usual_Button_ReadPasswd.Click += new System.EventHandler(this.Usual_Button_ReadPasswd_Click);
            // 
            // Usual_TextBox_ShowPasswd
            // 
            this.Usual_TextBox_ShowPasswd.BackColor = System.Drawing.SystemColors.GrayText;
            this.Usual_TextBox_ShowPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usual_TextBox_ShowPasswd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Usual_TextBox_ShowPasswd.Location = new System.Drawing.Point(89, 16);
            this.Usual_TextBox_ShowPasswd.Name = "Usual_TextBox_ShowPasswd";
            this.Usual_TextBox_ShowPasswd.ReadOnly = true;
            this.Usual_TextBox_ShowPasswd.Size = new System.Drawing.Size(100, 14);
            this.Usual_TextBox_ShowPasswd.TabIndex = 8;
            this.Usual_TextBox_ShowPasswd.Text = "20041123";
            this.Usual_TextBox_ShowPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usual_TextBox_ShowPasswd.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "学生端密码：";
            // 
            // tabPage_NetScan
            // 
            this.tabPage_NetScan.Controls.Add(this.Net_Label_IPMask);
            this.tabPage_NetScan.Controls.Add(this.label9);
            this.tabPage_NetScan.Controls.Add(this.Net_Label_IPPart);
            this.tabPage_NetScan.Controls.Add(this.label15);
            this.tabPage_NetScan.Controls.Add(this.Net_Button_Scan);
            this.tabPage_NetScan.Controls.Add(this.Net_Button_CardFresh);
            this.tabPage_NetScan.Controls.Add(this.Net_ListView_DevShow);
            this.tabPage_NetScan.Controls.Add(this.Net_ComboBox_Card);
            this.tabPage_NetScan.Controls.Add(this.label14);
            this.tabPage_NetScan.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NetScan.Name = "tabPage_NetScan";
            this.tabPage_NetScan.Size = new System.Drawing.Size(449, 341);
            this.tabPage_NetScan.TabIndex = 3;
            this.tabPage_NetScan.Text = "局域网扫描";
            this.tabPage_NetScan.UseVisualStyleBackColor = true;
            // 
            // Net_Label_IPMask
            // 
            this.Net_Label_IPMask.AutoSize = true;
            this.Net_Label_IPMask.Location = new System.Drawing.Point(351, 36);
            this.Net_Label_IPMask.Name = "Net_Label_IPMask";
            this.Net_Label_IPMask.Size = new System.Drawing.Size(23, 12);
            this.Net_Label_IPMask.TabIndex = 8;
            this.Net_Label_IPMask.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "IP掩码：";
            // 
            // Net_Label_IPPart
            // 
            this.Net_Label_IPPart.AutoSize = true;
            this.Net_Label_IPPart.Location = new System.Drawing.Point(73, 36);
            this.Net_Label_IPPart.Name = "Net_Label_IPPart";
            this.Net_Label_IPPart.Size = new System.Drawing.Size(23, 12);
            this.Net_Label_IPPart.TabIndex = 6;
            this.Net_Label_IPPart.Text = "N/A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "IP网段：";
            // 
            // Net_Button_Scan
            // 
            this.Net_Button_Scan.Location = new System.Drawing.Point(13, 56);
            this.Net_Button_Scan.Name = "Net_Button_Scan";
            this.Net_Button_Scan.Size = new System.Drawing.Size(424, 23);
            this.Net_Button_Scan.TabIndex = 4;
            this.Net_Button_Scan.Text = "扫描";
            this.Net_Button_Scan.UseVisualStyleBackColor = true;
            this.Net_Button_Scan.Click += new System.EventHandler(this.Net_Button_Scan_Click);
            // 
            // Net_Button_CardFresh
            // 
            this.Net_Button_CardFresh.Location = new System.Drawing.Point(390, 5);
            this.Net_Button_CardFresh.Name = "Net_Button_CardFresh";
            this.Net_Button_CardFresh.Size = new System.Drawing.Size(47, 23);
            this.Net_Button_CardFresh.TabIndex = 3;
            this.Net_Button_CardFresh.Text = "刷新";
            this.Net_Button_CardFresh.UseVisualStyleBackColor = true;
            this.Net_Button_CardFresh.Click += new System.EventHandler(this.Net_Button_CardFresh_Click);
            // 
            // Net_ListView_DevShow
            // 
            this.Net_ListView_DevShow.BackgroundImageTiled = true;
            this.Net_ListView_DevShow.CheckBoxes = true;
            this.Net_ListView_DevShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PC_Name,
            this.PC_IP,
            this.PC_State});
            this.Net_ListView_DevShow.ContextMenuStrip = this.Right_ClickContextMenuStrip_NetShow;
            this.Net_ListView_DevShow.GridLines = true;
            this.Net_ListView_DevShow.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.Net_ListView_DevShow.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.Net_ListView_DevShow.LabelWrap = false;
            this.Net_ListView_DevShow.Location = new System.Drawing.Point(13, 85);
            this.Net_ListView_DevShow.Name = "Net_ListView_DevShow";
            this.Net_ListView_DevShow.Size = new System.Drawing.Size(424, 245);
            this.Net_ListView_DevShow.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Net_ListView_DevShow.TabIndex = 2;
            this.Net_ListView_DevShow.UseCompatibleStateImageBehavior = false;
            this.Net_ListView_DevShow.View = System.Windows.Forms.View.Details;
            // 
            // PC_Name
            // 
            this.PC_Name.Text = "设备名称";
            this.PC_Name.Width = 167;
            // 
            // PC_IP
            // 
            this.PC_IP.Text = "IP";
            this.PC_IP.Width = 191;
            // 
            // PC_State
            // 
            this.PC_State.Text = "设备状态";
            // 
            // Right_ClickContextMenuStrip_NetShow
            // 
            this.Right_ClickContextMenuStrip_NetShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_NetShow_Clear});
            this.Right_ClickContextMenuStrip_NetShow.Name = "ContextMenuStrip_NetShow";
            this.Right_ClickContextMenuStrip_NetShow.Size = new System.Drawing.Size(101, 26);
            // 
            // ToolStripMenuItem_NetShow_Clear
            // 
            this.ToolStripMenuItem_NetShow_Clear.Name = "ToolStripMenuItem_NetShow_Clear";
            this.ToolStripMenuItem_NetShow_Clear.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_NetShow_Clear.Text = "清空";
            this.ToolStripMenuItem_NetShow_Clear.Click += new System.EventHandler(this.ToolStripMenuItem_NetShow_Clear_Click);
            // 
            // Net_ComboBox_Card
            // 
            this.Net_ComboBox_Card.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Net_ComboBox_Card.DropDownWidth = 400;
            this.Net_ComboBox_Card.FormattingEnabled = true;
            this.Net_ComboBox_Card.Location = new System.Drawing.Point(57, 7);
            this.Net_ComboBox_Card.MaxDropDownItems = 30;
            this.Net_ComboBox_Card.Name = "Net_ComboBox_Card";
            this.Net_ComboBox_Card.Size = new System.Drawing.Size(327, 20);
            this.Net_ComboBox_Card.TabIndex = 1;
            this.Net_ComboBox_Card.SelectedValueChanged += new System.EventHandler(this.Net_ComboBox_Card_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "网卡：";
            // 
            // tabPage_NetCom
            // 
            this.tabPage_NetCom.Controls.Add(this.TabControl2);
            this.tabPage_NetCom.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NetCom.Name = "tabPage_NetCom";
            this.tabPage_NetCom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NetCom.Size = new System.Drawing.Size(449, 341);
            this.tabPage_NetCom.TabIndex = 2;
            this.tabPage_NetCom.Text = "局域网通信";
            this.tabPage_NetCom.UseVisualStyleBackColor = true;
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage_Msg);
            this.TabControl2.Controls.Add(this.TabPage_File);
            this.TabControl2.Controls.Add(this.TabPage_Shell);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(3, 3);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(443, 335);
            this.TabControl2.TabIndex = 0;
            // 
            // TabPage_Msg
            // 
            this.TabPage_Msg.Controls.Add(this.Chat_Button_Send);
            this.TabPage_Msg.Controls.Add(this.Chat_TextBox_Input);
            this.TabPage_Msg.Controls.Add(this.Chat_RichTextBox_Show);
            this.TabPage_Msg.Controls.Add(this.groupBox5);
            this.TabPage_Msg.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Msg.Name = "TabPage_Msg";
            this.TabPage_Msg.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Msg.Size = new System.Drawing.Size(435, 309);
            this.TabPage_Msg.TabIndex = 0;
            this.TabPage_Msg.Text = "聊天";
            this.TabPage_Msg.UseVisualStyleBackColor = true;
            // 
            // Chat_Button_Send
            // 
            this.Chat_Button_Send.Location = new System.Drawing.Point(370, 281);
            this.Chat_Button_Send.Name = "Chat_Button_Send";
            this.Chat_Button_Send.Size = new System.Drawing.Size(59, 22);
            this.Chat_Button_Send.TabIndex = 4;
            this.Chat_Button_Send.Text = "发送";
            this.Chat_Button_Send.UseVisualStyleBackColor = true;
            this.Chat_Button_Send.Click += new System.EventHandler(this.Chat_Button_Send_Click);
            // 
            // Chat_TextBox_Input
            // 
            this.Chat_TextBox_Input.BackColor = System.Drawing.Color.PapayaWhip;
            this.Chat_TextBox_Input.Font = new System.Drawing.Font("宋体", 12F);
            this.Chat_TextBox_Input.Location = new System.Drawing.Point(106, 230);
            this.Chat_TextBox_Input.MaxLength = 400;
            this.Chat_TextBox_Input.Multiline = true;
            this.Chat_TextBox_Input.Name = "Chat_TextBox_Input";
            this.Chat_TextBox_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Chat_TextBox_Input.Size = new System.Drawing.Size(323, 49);
            this.Chat_TextBox_Input.TabIndex = 3;
            this.Chat_TextBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_ChatInput_KeyDown);
            // 
            // Chat_RichTextBox_Show
            // 
            this.Chat_RichTextBox_Show.Location = new System.Drawing.Point(106, 14);
            this.Chat_RichTextBox_Show.Name = "Chat_RichTextBox_Show";
            this.Chat_RichTextBox_Show.Size = new System.Drawing.Size(323, 210);
            this.Chat_RichTextBox_Show.TabIndex = 2;
            this.Chat_RichTextBox_Show.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SplitContainer1);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(94, 297);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "模式";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(3, 17);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.Chat_RadioButton_SendMode_UnAnonymous);
            this.SplitContainer1.Panel1.Controls.Add(this.Chat_RadioButton_SendMode_Anonymous);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.Chat_CheckBox_SendMode_IsBack);
            this.SplitContainer1.Panel2.Controls.Add(this.label16);
            this.SplitContainer1.Panel2.Controls.Add(this.Chat_NumUpDown_SendLoop);
            this.SplitContainer1.Panel2.Controls.Add(this.Chat_CheckBox_SendMode_Loop);
            this.SplitContainer1.Size = new System.Drawing.Size(88, 277);
            this.SplitContainer1.SplitterDistance = 72;
            this.SplitContainer1.TabIndex = 0;
            // 
            // Chat_RadioButton_SendMode_UnAnonymous
            // 
            this.Chat_RadioButton_SendMode_UnAnonymous.AutoSize = true;
            this.Chat_RadioButton_SendMode_UnAnonymous.Checked = true;
            this.Chat_RadioButton_SendMode_UnAnonymous.Location = new System.Drawing.Point(5, 42);
            this.Chat_RadioButton_SendMode_UnAnonymous.Name = "Chat_RadioButton_SendMode_UnAnonymous";
            this.Chat_RadioButton_SendMode_UnAnonymous.Size = new System.Drawing.Size(71, 16);
            this.Chat_RadioButton_SendMode_UnAnonymous.TabIndex = 1;
            this.Chat_RadioButton_SendMode_UnAnonymous.TabStop = true;
            this.Chat_RadioButton_SendMode_UnAnonymous.Text = "实名发送";
            this.Chat_RadioButton_SendMode_UnAnonymous.UseVisualStyleBackColor = true;
            // 
            // Chat_RadioButton_SendMode_Anonymous
            // 
            this.Chat_RadioButton_SendMode_Anonymous.AutoSize = true;
            this.Chat_RadioButton_SendMode_Anonymous.Location = new System.Drawing.Point(5, 12);
            this.Chat_RadioButton_SendMode_Anonymous.Name = "Chat_RadioButton_SendMode_Anonymous";
            this.Chat_RadioButton_SendMode_Anonymous.Size = new System.Drawing.Size(71, 16);
            this.Chat_RadioButton_SendMode_Anonymous.TabIndex = 0;
            this.Chat_RadioButton_SendMode_Anonymous.Text = "匿名发送";
            this.Chat_RadioButton_SendMode_Anonymous.UseVisualStyleBackColor = true;
            // 
            // Chat_CheckBox_SendMode_IsBack
            // 
            this.Chat_CheckBox_SendMode_IsBack.AutoSize = true;
            this.Chat_CheckBox_SendMode_IsBack.Checked = true;
            this.Chat_CheckBox_SendMode_IsBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chat_CheckBox_SendMode_IsBack.Location = new System.Drawing.Point(5, 85);
            this.Chat_CheckBox_SendMode_IsBack.Name = "Chat_CheckBox_SendMode_IsBack";
            this.Chat_CheckBox_SendMode_IsBack.Size = new System.Drawing.Size(78, 16);
            this.Chat_CheckBox_SendMode_IsBack.TabIndex = 3;
            this.Chat_CheckBox_SendMode_IsBack.Text = "能否回复?";
            this.Chat_CheckBox_SendMode_IsBack.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(65, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "/s";
            // 
            // Chat_NumUpDown_SendLoop
            // 
            this.Chat_NumUpDown_SendLoop.Location = new System.Drawing.Point(5, 35);
            this.Chat_NumUpDown_SendLoop.Name = "Chat_NumUpDown_SendLoop";
            this.Chat_NumUpDown_SendLoop.Size = new System.Drawing.Size(59, 21);
            this.Chat_NumUpDown_SendLoop.TabIndex = 1;
            this.Chat_NumUpDown_SendLoop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Chat_CheckBox_SendMode_Loop
            // 
            this.Chat_CheckBox_SendMode_Loop.AutoSize = true;
            this.Chat_CheckBox_SendMode_Loop.Location = new System.Drawing.Point(5, 5);
            this.Chat_CheckBox_SendMode_Loop.Name = "Chat_CheckBox_SendMode_Loop";
            this.Chat_CheckBox_SendMode_Loop.Size = new System.Drawing.Size(72, 16);
            this.Chat_CheckBox_SendMode_Loop.TabIndex = 0;
            this.Chat_CheckBox_SendMode_Loop.Text = "循环发送";
            this.Chat_CheckBox_SendMode_Loop.UseVisualStyleBackColor = true;
            // 
            // TabPage_File
            // 
            this.TabPage_File.Controls.Add(this.File_Button_SendStart);
            this.TabPage_File.Controls.Add(this.File_Button_SendStop);
            this.TabPage_File.Controls.Add(this.label18);
            this.TabPage_File.Controls.Add(this.File_ProgressBar_AllProg);
            this.TabPage_File.Controls.Add(this.label17);
            this.TabPage_File.Controls.Add(this.File_ProgressBar_CurrProg);
            this.TabPage_File.Controls.Add(this.SplitContainer2);
            this.TabPage_File.Location = new System.Drawing.Point(4, 22);
            this.TabPage_File.Name = "TabPage_File";
            this.TabPage_File.Size = new System.Drawing.Size(435, 309);
            this.TabPage_File.TabIndex = 2;
            this.TabPage_File.Text = "文件收发";
            this.TabPage_File.UseVisualStyleBackColor = true;
            // 
            // File_Button_SendStart
            // 
            this.File_Button_SendStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.File_Button_SendStart.Location = new System.Drawing.Point(357, 248);
            this.File_Button_SendStart.Name = "File_Button_SendStart";
            this.File_Button_SendStart.Size = new System.Drawing.Size(75, 23);
            this.File_Button_SendStart.TabIndex = 8;
            this.File_Button_SendStart.Text = "发送";
            this.File_Button_SendStart.UseVisualStyleBackColor = true;
            this.File_Button_SendStart.Click += new System.EventHandler(this.File_Button_SendStart_Click);
            // 
            // File_Button_SendStop
            // 
            this.File_Button_SendStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.File_Button_SendStop.Enabled = false;
            this.File_Button_SendStop.Location = new System.Drawing.Point(357, 279);
            this.File_Button_SendStop.Name = "File_Button_SendStop";
            this.File_Button_SendStop.Size = new System.Drawing.Size(75, 23);
            this.File_Button_SendStop.TabIndex = 7;
            this.File_Button_SendStop.Text = "停止";
            this.File_Button_SendStop.UseVisualStyleBackColor = true;
            this.File_Button_SendStop.Click += new System.EventHandler(this.File_Button_SendStop_Click);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 288);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 6;
            this.label18.Text = "总进度：";
            // 
            // File_ProgressBar_AllProg
            // 
            this.File_ProgressBar_AllProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.File_ProgressBar_AllProg.Location = new System.Drawing.Point(80, 279);
            this.File_ProgressBar_AllProg.Name = "File_ProgressBar_AllProg";
            this.File_ProgressBar_AllProg.Size = new System.Drawing.Size(271, 23);
            this.File_ProgressBar_AllProg.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 5;
            this.label17.Text = "当前进度：";
            // 
            // File_ProgressBar_CurrProg
            // 
            this.File_ProgressBar_CurrProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.File_ProgressBar_CurrProg.Location = new System.Drawing.Point(80, 250);
            this.File_ProgressBar_CurrProg.Name = "File_ProgressBar_CurrProg";
            this.File_ProgressBar_CurrProg.Size = new System.Drawing.Size(271, 23);
            this.File_ProgressBar_CurrProg.TabIndex = 4;
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitContainer2.Location = new System.Drawing.Point(4, 3);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.File_TreeView_LocalShow);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.File_ListView_NetTask);
            this.SplitContainer2.Size = new System.Drawing.Size(428, 241);
            this.SplitContainer2.SplitterDistance = 211;
            this.SplitContainer2.SplitterWidth = 2;
            this.SplitContainer2.TabIndex = 2;
            // 
            // File_TreeView_LocalShow
            // 
            this.File_TreeView_LocalShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.File_TreeView_LocalShow.ImageKey = "Folder";
            this.File_TreeView_LocalShow.ImageList = this.File_ImageList_Icon;
            this.File_TreeView_LocalShow.Location = new System.Drawing.Point(0, 0);
            this.File_TreeView_LocalShow.Name = "File_TreeView_LocalShow";
            treeNode1.Name = "Folder_Windows";
            treeNode1.Text = "Windows";
            treeNode2.ImageKey = "Drive";
            treeNode2.Name = "Drive_C";
            treeNode2.SelectedImageKey = "Drive";
            treeNode2.Text = "本地磁盘（C:）";
            treeNode3.ImageKey = "Drive";
            treeNode3.Name = "Drive_D";
            treeNode3.SelectedImageKey = "Drive";
            treeNode3.Text = "本地磁盘（D:）";
            treeNode4.ImageKey = "Computer";
            treeNode4.Name = "Computer";
            treeNode4.SelectedImageKey = "Computer";
            treeNode4.StateImageKey = "(无)";
            treeNode4.Text = "此电脑";
            this.File_TreeView_LocalShow.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.File_TreeView_LocalShow.SelectedImageKey = "Folder";
            this.File_TreeView_LocalShow.Size = new System.Drawing.Size(207, 237);
            this.File_TreeView_LocalShow.TabIndex = 0;
            this.File_TreeView_LocalShow.Enter += new System.EventHandler(this.File_TreeView_LocalShow_Enter);
            // 
            // File_ImageList_Icon
            // 
            this.File_ImageList_Icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("File_ImageList_Icon.ImageStream")));
            this.File_ImageList_Icon.TransparentColor = System.Drawing.Color.Transparent;
            this.File_ImageList_Icon.Images.SetKeyName(0, "Computer");
            this.File_ImageList_Icon.Images.SetKeyName(1, "Drive");
            this.File_ImageList_Icon.Images.SetKeyName(2, "Folder");
            // 
            // File_ListView_NetTask
            // 
            this.File_ListView_NetTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.File_ListView_NetTask.HideSelection = false;
            this.File_ListView_NetTask.Location = new System.Drawing.Point(0, 0);
            this.File_ListView_NetTask.Name = "File_ListView_NetTask";
            this.File_ListView_NetTask.Size = new System.Drawing.Size(211, 237);
            this.File_ListView_NetTask.TabIndex = 0;
            this.File_ListView_NetTask.UseCompatibleStateImageBehavior = false;
            // 
            // TabPage_Shell
            // 
            this.TabPage_Shell.Controls.Add(this.Shell_RichTextBox_CMDBox);
            this.TabPage_Shell.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Shell.Name = "TabPage_Shell";
            this.TabPage_Shell.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Shell.Size = new System.Drawing.Size(435, 309);
            this.TabPage_Shell.TabIndex = 1;
            this.TabPage_Shell.Text = "反弹Shell";
            this.TabPage_Shell.UseVisualStyleBackColor = true;
            // 
            // Shell_RichTextBox_CMDBox
            // 
            this.Shell_RichTextBox_CMDBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.Shell_RichTextBox_CMDBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Shell_RichTextBox_CMDBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Shell_RichTextBox_CMDBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.Shell_RichTextBox_CMDBox.Location = new System.Drawing.Point(3, 3);
            this.Shell_RichTextBox_CMDBox.Name = "Shell_RichTextBox_CMDBox";
            this.Shell_RichTextBox_CMDBox.Size = new System.Drawing.Size(429, 303);
            this.Shell_RichTextBox_CMDBox.TabIndex = 0;
            this.Shell_RichTextBox_CMDBox.Text = "This is a Command Box\n\nC:\\Users\\Administrator>_";
            this.Shell_RichTextBox_CMDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Shell_RichTextBox_CMDBox_KeyPress);
            // 
            // MainWin_CheckBox_TopWindow
            // 
            this.MainWin_CheckBox_TopWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MainWin_CheckBox_TopWindow.AutoSize = true;
            this.MainWin_CheckBox_TopWindow.Checked = true;
            this.MainWin_CheckBox_TopWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainWin_CheckBox_TopWindow.Location = new System.Drawing.Point(15, 398);
            this.MainWin_CheckBox_TopWindow.Name = "MainWin_CheckBox_TopWindow";
            this.MainWin_CheckBox_TopWindow.Size = new System.Drawing.Size(96, 16);
            this.MainWin_CheckBox_TopWindow.TabIndex = 6;
            this.MainWin_CheckBox_TopWindow.Text = "窗口置于顶层";
            this.MainWin_CheckBox_TopWindow.UseVisualStyleBackColor = true;
            this.MainWin_CheckBox_TopWindow.CheckStateChanged += new System.EventHandler(this.CheckBox_TopWindow_CheckStateChanged);
            // 
            // MainWin_Label_Time
            // 
            this.MainWin_Label_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MainWin_Label_Time.BackColor = System.Drawing.Color.LightGray;
            this.MainWin_Label_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainWin_Label_Time.Font = new System.Drawing.Font("宋体", 10F);
            this.MainWin_Label_Time.Location = new System.Drawing.Point(298, 395);
            this.MainWin_Label_Time.Name = "MainWin_Label_Time";
            this.MainWin_Label_Time.Size = new System.Drawing.Size(155, 19);
            this.MainWin_Label_Time.TabIndex = 5;
            this.MainWin_Label_Time.Text = "2020/12/26  21:06:29";
            this.MainWin_Label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWin_TextBox_Log
            // 
            this.MainWin_TextBox_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainWin_TextBox_Log.BackColor = System.Drawing.Color.Wheat;
            this.MainWin_TextBox_Log.ContextMenuStrip = this.RightClick_ContextMenuStrip_LogTextBox;
            this.MainWin_TextBox_Log.Font = new System.Drawing.Font("宋体", 10F);
            this.MainWin_TextBox_Log.Location = new System.Drawing.Point(459, 47);
            this.MainWin_TextBox_Log.Multiline = true;
            this.MainWin_TextBox_Log.Name = "MainWin_TextBox_Log";
            this.MainWin_TextBox_Log.ReadOnly = true;
            this.MainWin_TextBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MainWin_TextBox_Log.Size = new System.Drawing.Size(399, 367);
            this.MainWin_TextBox_Log.TabIndex = 7;
            this.MainWin_TextBox_Log.WordWrap = false;
            // 
            // RightClick_ContextMenuStrip_LogTextBox
            // 
            this.RightClick_ContextMenuStrip_LogTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_LogTextBox_Clear,
            this.ToolStripMenuItem_LogTextBox_ExpLog});
            this.RightClick_ContextMenuStrip_LogTextBox.Name = "ContextMenuStrip_LogTextBox";
            this.RightClick_ContextMenuStrip_LogTextBox.Size = new System.Drawing.Size(125, 48);
            // 
            // ToolStripMenuItem_LogTextBox_Clear
            // 
            this.ToolStripMenuItem_LogTextBox_Clear.Name = "ToolStripMenuItem_LogTextBox_Clear";
            this.ToolStripMenuItem_LogTextBox_Clear.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_LogTextBox_Clear.Text = "清空";
            this.ToolStripMenuItem_LogTextBox_Clear.Click += new System.EventHandler(this.ToolStripMenuItem_LogTextBox_Clear_Click);
            // 
            // ToolStripMenuItem_LogTextBox_ExpLog
            // 
            this.ToolStripMenuItem_LogTextBox_ExpLog.Name = "ToolStripMenuItem_LogTextBox_ExpLog";
            this.ToolStripMenuItem_LogTextBox_ExpLog.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_LogTextBox_ExpLog.Text = "导出日志";
            // 
            // MainWin_MenuStrip
            // 
            this.MainWin_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File,
            this.MenuItem_Setting,
            this.MenuItem_About});
            this.MainWin_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainWin_MenuStrip.Name = "MainWin_MenuStrip";
            this.MainWin_MenuStrip.Size = new System.Drawing.Size(864, 25);
            this.MainWin_MenuStrip.TabIndex = 8;
            this.MainWin_MenuStrip.Text = "menuStrip1";
            // 
            // MenuItem_File
            // 
            this.MenuItem_File.Name = "MenuItem_File";
            this.MenuItem_File.Size = new System.Drawing.Size(44, 21);
            this.MenuItem_File.Text = "文件";
            // 
            // MenuItem_Setting
            // 
            this.MenuItem_Setting.Name = "MenuItem_Setting";
            this.MenuItem_Setting.Size = new System.Drawing.Size(44, 21);
            this.MenuItem_Setting.Text = "设置";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.Size = new System.Drawing.Size(44, 21);
            this.MenuItem_About.Text = "关于";
            this.MenuItem_About.Click += new System.EventHandler(this.MenuItem_About_Click);
            // 
            // Back_Timer_GetSystemTime
            // 
            this.Back_Timer_GetSystemTime.Enabled = true;
            this.Back_Timer_GetSystemTime.Interval = 500;
            this.Back_Timer_GetSystemTime.Tick += new System.EventHandler(this.Timer_GetSystemTime_Tick);
            // 
            // File_ContextMenuStrip_Treeview
            // 
            this.File_ContextMenuStrip_Treeview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fresh});
            this.File_ContextMenuStrip_Treeview.Name = "File_ContextMenuStrip_Treeview";
            this.File_ContextMenuStrip_Treeview.Size = new System.Drawing.Size(101, 26);
            // 
            // Fresh
            // 
            this.Fresh.Name = "Fresh";
            this.Fresh.Size = new System.Drawing.Size(100, 22);
            this.Fresh.Text = "刷新";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(864, 421);
            this.Controls.Add(this.MainWin_MenuStrip);
            this.Controls.Add(this.MainWin_TextBox_Log);
            this.Controls.Add(this.MainWin_CheckBox_TopWindow);
            this.Controls.Add(this.MainWin_Label_Time);
            this.Controls.Add(this.TabControl1);
            this.MainMenuStrip = this.MainWin_MenuStrip;
            this.Name = "MainForm";
            this.Text = "极域电子教室V6.0--学生端辅助";
            this.TabControl1.ResumeLayout(false);
            this.tabPage_RunInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage_Functions.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.Usual_TabControl_ProtectInfo.ResumeLayout(false);
            this.TabPage_Power.ResumeLayout(false);
            this.TabPage_Power.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage_NetScan.ResumeLayout(false);
            this.tabPage_NetScan.PerformLayout();
            this.Right_ClickContextMenuStrip_NetShow.ResumeLayout(false);
            this.tabPage_NetCom.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.TabPage_Msg.ResumeLayout(false);
            this.TabPage_Msg.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chat_NumUpDown_SendLoop)).EndInit();
            this.TabPage_File.ResumeLayout(false);
            this.TabPage_File.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.TabPage_Shell.ResumeLayout(false);
            this.RightClick_ContextMenuStrip_LogTextBox.ResumeLayout(false);
            this.MainWin_MenuStrip.ResumeLayout(false);
            this.MainWin_MenuStrip.PerformLayout();
            this.File_ContextMenuStrip_Treeview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage_RunInfo;
        private System.Windows.Forms.TabPage tabPage_Functions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RunState_Label_State;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RunState_TextBox_LocalIP;
        private System.Windows.Forms.TextBox RunState_TextBox_LocalMac;
        private System.Windows.Forms.Label RunState_Label_FireWallState;
        private System.Windows.Forms.TextBox RunState_TextBox_LocalGateWay;
        private System.Windows.Forms.Label RunState_Label_WebState;
        private System.Windows.Forms.Label RunState_Label_NetState;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox MainWin_CheckBox_TopWindow;
        private System.Windows.Forms.Label MainWin_Label_Time;
        private System.Windows.Forms.TextBox MainWin_TextBox_Log;
        private System.Windows.Forms.ContextMenuStrip RightClick_ContextMenuStrip_LogTextBox;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_LogTextBox_Clear;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_LogTextBox_ExpLog;
        private System.Windows.Forms.Button Usual_Button_WritePasswd;
        private System.Windows.Forms.Button Usual_Button_ReadPasswd;
        private System.Windows.Forms.TextBox Usual_TextBox_ShowPasswd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Usual_Button_ShutdownTask;
        private System.Windows.Forms.Button Usual_Button_StartTask;
        private System.Windows.Forms.MenuStrip MainWin_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.Button RunState_Button_StateFresh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl Usual_TabControl_ProtectInfo;
        private System.Windows.Forms.TabPage TabPage_Control;
        private System.Windows.Forms.TabPage TabPage_Power;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage_NetCom;
        private System.Windows.Forms.TabPage tabPage_NetScan;
        private System.Windows.Forms.ComboBox Net_ComboBox_Card;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView Net_ListView_DevShow;
        private System.Windows.Forms.ColumnHeader PC_IP;
        private System.Windows.Forms.ColumnHeader PC_Name;
        private System.Windows.Forms.ColumnHeader PC_State;
        private System.Windows.Forms.Button Net_Button_CardFresh;
        private System.Windows.Forms.Button Net_Button_Scan;
        private System.Windows.Forms.ContextMenuStrip Right_ClickContextMenuStrip_NetShow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NetShow_Clear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Net_Label_IPPart;
        private System.Windows.Forms.Timer Back_Timer_GetSystemTime;
        private System.Windows.Forms.TabControl TabControl2;
        private System.Windows.Forms.TabPage TabPage_Msg;
        private System.Windows.Forms.TabPage TabPage_Shell;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.CheckBox Chat_CheckBox_SendMode_Loop;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown Chat_NumUpDown_SendLoop;
        private System.Windows.Forms.CheckBox Chat_CheckBox_SendMode_IsBack;
        private System.Windows.Forms.RadioButton Chat_RadioButton_SendMode_UnAnonymous;
        private System.Windows.Forms.RadioButton Chat_RadioButton_SendMode_Anonymous;
        private System.Windows.Forms.TabPage TabPage_File;
        private System.Windows.Forms.RichTextBox Chat_RichTextBox_Show;
        private System.Windows.Forms.TextBox Chat_TextBox_Input;
        private System.Windows.Forms.Button Chat_Button_Send;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Setting;
        private System.Windows.Forms.SplitContainer SplitContainer2;
        private System.Windows.Forms.ProgressBar File_ProgressBar_CurrProg;
        private System.Windows.Forms.ProgressBar File_ProgressBar_AllProg;
        private System.Windows.Forms.TreeView File_TreeView_LocalShow;
        private System.Windows.Forms.ListView File_ListView_NetTask;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button File_Button_SendStart;
        private System.Windows.Forms.Button File_Button_SendStop;
        private System.Windows.Forms.RichTextBox Shell_RichTextBox_CMDBox;
        private System.Windows.Forms.ImageList File_ImageList_Icon;
        private System.Windows.Forms.ContextMenuStrip File_ContextMenuStrip_Treeview;
        private System.Windows.Forms.ToolStripMenuItem Fresh;
        private System.Windows.Forms.Label Net_Label_IPMask;
        private System.Windows.Forms.Label label9;
    }
}

