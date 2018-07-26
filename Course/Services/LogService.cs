using System;
using System.IO;
using System.Collections.Generic;
using Course.Entities;

namespace Course.Services {
    class LogService {

        private string _filePath;
        private PrintService _printService;

        public LogService(string filePath, PrintService printService) {
            _filePath = filePath;
            _printService = printService;
        }

        public int CountLogUsers() {
            using (StreamReader sr = File.OpenText(_filePath)) {
                HashSet<LogEntry> set = new HashSet<LogEntry>(); 
                while (!sr.EndOfStream) {
                    string[] line = sr.ReadLine().Split(' ');
                    LogEntry entry = new LogEntry(line[0], DateTime.Parse(line[1]));
                    set.Add(entry);
                    _printService.Print(entry);
                }
                return set.Count;
            }
        }
    }
}
