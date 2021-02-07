using System.Windows.Forms;

namespace ClassManager_StudentCrack._Function
{
    /// <summary>
    /// 日志类定义
    /// </summary>
    class Logs
    {
        public TextBox TextBox { get; set; }
        public Logs(TextBox textBox)
        {
            TextBox = textBox;
        }

        delegate void WriteLogCallback(object log);
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="log"></param>
        public void WriteLog(object log)
        {
            if (TextBox.InvokeRequired) // 此控件是否跨线程访问
            {
                WriteLogCallback writeLogCallback = new WriteLogCallback(WriteLog);
                TextBox.Invoke(writeLogCallback, log);  // 重新调用自身
            }
            else // 否则直接访问
            {
                TextBox.AppendText(string.Format(log.ToString(), "\r\n"));
            }
        }
    }
}
