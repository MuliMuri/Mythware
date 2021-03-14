

using System;
using System.Collections.Generic;
using System.IO;

namespace ClassManager_StudentCrack._Module
{
    //TODO: ?自动捕获异常
    /// <summary>
    /// 日志类定义
    /// <para></para>
    /// </summary>
    class Loger
    {
        public static bool MainThreadDied { get; set; } = false;

        public Loger()
        {
            
        }

        /// <summary>
        /// 日志等级
        /// </summary>
        public static LevelDefine Level { get; set; } = LevelDefine.INFO;

        /// <summary>
        /// 线程管理器
        /// </summary>
        private TaskCore.ThreadManager ThreadManager = new TaskCore.ThreadManager();

        /// <summary>
        /// 日志列队
        /// </summary>
        private static List<LogInfoTab> LogTaskList = new List<LogInfoTab>();

        /// <summary>
        /// 日志等级定义
        /// </summary>
        public enum LevelDefine
        {
            ALL,
            DEBUG,
            INFO,
            WARN,
            ERROR,
            FATAL,
            OFF
        }

        /// <summary>
        /// 单例实例
        /// </summary>
        /// <returns>Logger 对象</returns>
        private static Loger Instance()
        {
            return new Loger();
        }

        /// <summary>
        /// 日志表模板
        /// </summary>
        class LogInfoTab
        {
            public int Level { get; set; }
            public string Msg { get; set; }
            public string Time { get; set; }
            public Exception Exception { get; set; }
        }

        /// <summary>
        /// 初始化
        /// <para>注: 首次调用即可</para>
        /// </summary>
        public void Init()
        {
            ThreadManager.Add("Logger", ListTasks);
        }

        #region LevelFunc

        /// <summary>
        /// 等级: 调试
        /// </summary>
        /// <param name="Msg">日志信息</param>
        /// <param name="e">异常类</param>
        public static void Debug(string Msg, Exception e = null)
        {
            if (e == null)
            {
                e = new Exception();
            }
            Instance().AddLog(Msg, e, LevelDefine.DEBUG);
        }

        /// <summary>
        /// 等级: 信息
        /// </summary>
        /// <param name="Msg">日志信息</param>
        /// <param name="e">异常类</param>
        public static void Info(string Msg, Exception e = null)
        {
            if (e == null)
            {
                e = new Exception();
            }
            Instance().AddLog(Msg, e, LevelDefine.INFO);
        }

        /// <summary>
        /// 等级: 警告
        /// </summary>
        /// <param name="Msg">日志信息</param>
        /// <param name="e">异常类</param>
        public static void Warn(string Msg, Exception e = null)
        {
            if (e == null)
            {
                e = new Exception();
            }
            Instance().AddLog(Msg, e, LevelDefine.WARN);
        }

        /// <summary>
        /// 等级: 错误
        /// </summary>
        /// <param name="Msg">日志信息</param>
        /// <param name="e">
        /// <para>异常类</para>
        /// <para>注: 此等级不能省略此参数</para>
        /// </param>
        public static void Error(string Msg, Exception e)
        {
            Instance().AddLog(Msg, e, LevelDefine.ERROR);
        }

        /// <summary>
        /// 等级: 致命
        /// </summary>
        /// <param name="Msg">日志信息</param>
        /// <param name="e">
        /// <para>异常类</para>
        /// <para>注: 此等级不能省略此参数</para>
        /// </param>
        public static void Fatal(string Msg, Exception e)
        {
            Instance().AddLog(Msg, e, LevelDefine.FATAL);
        }

        #endregion









        /// <summary>
        /// 向日志表添加日志条目
        /// </summary>
        /// <param name="Msg">日志信息</param>
        /// <param name="e">异常类</param>
        /// <param name="level">日志级别</param>
        private void AddLog(string Msg, Exception e, LevelDefine level = LevelDefine.OFF)
        {
            LogInfoTab logInfoTab = new LogInfoTab();

            if (level == LevelDefine.OFF)
            {
                return;
            }

            logInfoTab.Level = (int)level;
            logInfoTab.Msg = Msg;
            logInfoTab.Time = DateTime.Now.ToString("G");
            logInfoTab.Exception = e;

            LogTaskList.Add(logInfoTab);
        }

        
        /// <summary>
        /// 列表任务处理
        /// </summary>
        private void ListTasks()
        {
            while (true)
            {
                Timer.Sleep(200);
                lock (LogTaskList)
                {
                    for (int i = 0; i < LogTaskList.Count; i++)
                    {
                        WriteLog
                            (
                            LogTaskList[i].Msg,
                            LogTaskList[i].Level,
                            LogTaskList[i].Time,
                            LogTaskList[i].Exception
                            );
                    }
                    LogTaskList.Clear();
                    if (MainThreadDied)
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 日志写入文件
        /// </summary>
        /// <param name="Msg">日志信息</param>
        /// <param name="Level">日志级别</param>
        /// <param name="Time">时间戳</param>
        /// <param name="e">异常类</param>
        private void WriteLog(string Msg, int Level, string Time, Exception e)
        {
            string Log =
                "========================================\r\n" +
                "Time: \t\t[{0}]\r\n" +
                "Level: \t\t[{1}]\r\n" +
                "Message: \t\t{2}\r\n" +
                "\t\t{3}\r\n" +
                "Stack: \t\t{4}\r\n" +
                "========================================\r\n";
            
            string strLevel;

            switch (Level)
            {
                case 1:
                    strLevel = "DEBUG";
                    break;
                case 2:
                    strLevel = "INFO";
                    break;
                case 3:
                    strLevel = "WARN";
                    break;
                case 4:
                    strLevel = "ERROR";
                    break;
                case 5:
                    strLevel = "FATAL";
                    break;

                default:
                    return;
            }

            Log = string.Format(Log, Time, strLevel, Msg, e.Message, e.TargetSite);
            string fileName = string.Format("{0}.log", DateTime.Now.ToString("yyyy-MM-dd"));
            File.AppendAllText(fileName, Log);
        }


    }
}
