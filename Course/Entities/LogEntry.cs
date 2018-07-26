using System;

namespace Course.Entities {
    class LogEntry {

        public string Username { get; set; }
        public DateTime Moment { get; set; }

        public LogEntry(string username, DateTime moment) {
            Username = username;
            Moment = moment;
        }
    }
}
