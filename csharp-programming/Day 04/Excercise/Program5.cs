using System;

namespace Excercise {
    static class Logger {
        public delegate void LogMessage(string str);
        public static void Log(string str, LogMessage log) { 
            if(str == null) {
                throw new Exception("String cannot be null...");
            }
            log(str);
        }
    }

    class Console_Dummy {
        public static void ConsoleLogger(string str) {
            Console.WriteLine(str);
        }
    }

    class File_Dummy {
        public static void FileLogger(string str) {
            string path = "E:/Training Pratiti/C#/dotnet-programming/csharp-programming/Day 04/Excercise/FileLogger.txt";
            File.WriteAllText(path, str);
        }
    }

    class Program {
        public static void Main(string[] args) {
            string str = "This string is gone be printed";
            Logger.LogMessage log = new Logger.LogMessage(Console_Dummy.ConsoleLogger);
            Logger.Log(str, log);
            Logger.Log(str, File_Dummy.FileLogger);
        }
    }
}