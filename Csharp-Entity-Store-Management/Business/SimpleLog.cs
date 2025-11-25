using System;
using System.IO;

namespace Csharp_Entity_Store_Management.Business
{
    public class SimpleLog
    {
        private static readonly string LogFile = "transaction_log.txt";

        public static void WriteLog(string message)
        {
            try
            {
                string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
                File.AppendAllText(LogFile, logEntry + Environment.NewLine);
            }
            catch
            {
                // Bỏ qua lỗi để không ảnh hưởng đến chương trình chính
            }
        }
    }
} 