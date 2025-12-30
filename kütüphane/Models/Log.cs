using System;

namespace UniversityLibrarySystem.Models
{
    public class Log
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }

        public Log(string message)
        {
            Date = DateTime.Now;
            Message = message;
        }

        public override string ToString()
        {
            return $"{Date:dd.MM.yyyy HH:mm:ss} - {Message}";
        }
    }
}
