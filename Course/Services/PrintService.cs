using System;
using Course.Entities;

namespace Course.Services {
    class PrintService {

        public void Print(LogEntry entry) {
            Console.WriteLine("[" + entry.Username + "]" + entry.Moment.ToString("dd/MM/yyyy"));
        }
    }
}
