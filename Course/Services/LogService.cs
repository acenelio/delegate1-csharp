using System;
using System.IO;
using System.Collections.Generic;
using Course.Entities;

namespace Course.Services {
    class LogService {

        private string _filePath;

        public LogService(string filePath) {
            _filePath = filePath;
        }

        public int CountLogUsers(Action<LogEntry> callback) {
            using (StreamReader sr = File.OpenText(_filePath)) {
                HashSet<LogEntry> set = new HashSet<LogEntry>(); 
                while (!sr.EndOfStream) {
                    string[] line = sr.ReadLine().Split(' ');
                    LogEntry entry = new LogEntry(line[0], DateTime.Parse(line[1]));
                    set.Add(entry);
                    callback?.Invoke(entry);
                }
                return set.Count;
            }
        }
    }
}
