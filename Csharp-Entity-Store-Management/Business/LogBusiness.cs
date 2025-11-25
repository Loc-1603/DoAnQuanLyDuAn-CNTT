using System;
using System.IO;
using System.Text;

namespace Csharp_Entity_Store_Management.Business
{
    public class LogBusiness
    {
        private readonly string _logFilePath;
        private readonly object _lockObject = new object();

        public LogBusiness()
        {
            // Tạo thư mục Logs nếu chưa tồn tại
            string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            // Tạo tên file log theo ngày
            string fileName = $"Log_{DateTime.Now:yyyy-MM-dd}.txt";
            _logFilePath = Path.Combine(logDirectory, fileName);
        }

        public void WriteLog(string action, string details, string username)
        {
            try
            {
                string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] - User: {username} - Action: {action} - Details: {details}";
                
                lock (_lockObject)
                {
                    File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                // Ghi lỗi vào console nếu không thể ghi file
                Console.WriteLine($"Error writing log: {ex.Message}");
            }
        }

        public void WriteErrorLog(string action, string errorMessage, string username)
        {
            try
            {
                string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] - User: {username} - Action: {action} - ERROR: {errorMessage}";
                
                lock (_lockObject)
                {
                    File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing error log: {ex.Message}");
            }
        }

        public string ReadLogs(DateTime date)
        {
            try
            {
                string fileName = $"Log_{date:yyyy-MM-dd}.txt";
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs", fileName);

                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                return "No logs found for the specified date.";
            }
            catch (Exception ex)
            {
                return $"Error reading logs: {ex.Message}";
            }
        }

        public string ReadLogsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                StringBuilder allLogs = new StringBuilder();
                string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    string fileName = $"Log_{date:yyyy-MM-dd}.txt";
                    string filePath = Path.Combine(logDirectory, fileName);

                    if (File.Exists(filePath))
                    {
                        allLogs.AppendLine($"=== Logs for {date:yyyy-MM-dd} ===");
                        allLogs.AppendLine(File.ReadAllText(filePath));
                        allLogs.AppendLine();
                    }
                }

                return allLogs.ToString();
            }
            catch (Exception ex)
            {
                return $"Error reading logs: {ex.Message}";
            }
        }
    }
} 