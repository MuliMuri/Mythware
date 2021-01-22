using System.Windows.Forms;

namespace ClassManager_StudentCrack._Function
{
    /// <summary>
    /// 日志定义
    /// </summary>
    class Logs
    {
        private static readonly string[] Functions = { "读取 极域电子教室 密码", "写入 极域电子教室 密码", "启动 极域电子教室 进程", "结束 极域电子教室 进程" };
        private static TextBox textBox = null;

        /// <summary>
        /// 设置日志框
        /// </summary>
        /// <param name="_textBox">TextBox 变量</param>
        public static void SetTextBox(TextBox _textBox)
        {
            textBox = _textBox;
        }

        /// <summary>
        /// 初始化日志段头部
        /// </summary>
        /// <param name="Function">
        /// 功能选择：
        /// <para>0: 读取 极域电子教室 密码</para>
        /// <para>1: 写入 极域电子教室 密码</para>
        /// <para>2: 启动 极域电子教室 进程</para>
        /// <para>3: 结束 极域电子教室 进程</para>
        /// </param>
        /// <param name="textBox">TextBox 实例化变量</param>
        public static void WriteLogHead(int Function)
        {
            textBox.AppendText("================" + Functions[Function] + "================\r\n");
        }

        /// <summary>
        /// 写入一行日志
        /// </summary>
        /// <param name="WriteText">日志内容</param>
        /// <param name="textBox">TextBox 实例化变量</param>
        public static void WriteLog(string WriteText)
        {
            textBox.AppendText(WriteText + "\r\n");
        }

        /// <summary>
        /// 格式化日志尾部
        /// </summary>
        /// <param name="textBox">TextBox 实例化变量</param>
        public static void WriteLogEnd()
        {
            textBox.AppendText("\r\n\r\nDone...\r\n=====================================================\r\n");
        }
    }
}
