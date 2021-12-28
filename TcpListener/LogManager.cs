using Bilibili.Common.Database;
using Serilog;
using Serilog.Core;
using System;
using System.IO;

namespace Bilibili.Common.Log
{
    public sealed class LogManager
    {
        private static LogManager _Instance;
        public static LogManager Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new LogManager();
                return _Instance;
            }
        }
        private bool EnableLogging { get; } = true;
        private Logger Logger { get; }
        private LogManager()
        {
            EnableLogging = SettingHelper.EnableLogging;
            var LogFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "bilibili_log", "log-.txt");
            Logger = new LoggerConfiguration().MinimumLevel.Debug()
                .WriteTo.Async(a => a.File(LogFile, rollingInterval: RollingInterval.Day))
                .CreateLogger();
        }
        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="messageTemplate">错误方法或者备注</param>
        /// <param name="exception">错误信息</param>
        /// <param name="Serious">是否严重错误</param>
        public void LogError(string messageTemplate, Exception exception, bool Serious = false)
        {
            if (!EnableLogging && !Serious) return;
            try
            {
                if (exception.IsNotEmpty())
                    Logger.Error(exception, messageTemplate);
            }
            catch { }
        }
        public void LogInfo(string messageTemplate)
        {
            if (!EnableLogging) return;
            try
            {
                Logger.Information(messageTemplate);
            }
            catch { }
        }
        public void LogInfo(string messageTemplate, params object[] propertyValues)
        {
            if (!EnableLogging) return;
            try
            {
                Logger.Information(messageTemplate, propertyValues);
            }
            catch { }
        }
    }
}