using System;
using System.IO;
using System.Text;

namespace Logger
{
    public sealed class Log : ILog
    {
        //Lazy<T> objects are thread safe
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());

        private Log()
        {

        }

        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Exception", DateTime.Now.ToString("dd-MM-yy"));
            string logFilePath = string.Format(@"{0}\{1}", @"D:\PoC\DesignPatternSample\DesignPattern.Presentation\Log\", fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
