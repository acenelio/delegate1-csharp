using System;
using System.IO;
using Course.Services;

namespace Course {

    class Program {
        static void Main(string[] args) {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            LogService batchService = new LogService(path);
            PrintService printService = new PrintService();

            Console.WriteLine("Process start...");
            try {
                int result = batchService.CountLogUsers(printService.Print);
                Console.WriteLine("Total: " + result + " users");
            }
            catch (IOException e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
