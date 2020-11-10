using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Console4NothingLoader
{
    public class Logger
    {
        internal static bool loggerDone = true;
        
        private static readonly List<string> Queue = new List<string>();

        private static string _logFile = string.Empty;

        private readonly Thread _queueHandler = new Thread(() =>
        {
            while (true)
            {
                if (Queue.Count != 0)
                {
                    loggerDone = false;
                    if (Queue[0] == "empty")
                    {
                        File.AppendAllText(_logFile, Environment.NewLine);
                        Queue.Remove(Queue[0]);
                    }
                    else
                    {
                        File.AppendAllText(_logFile, Queue[0] + Environment.NewLine);
                        Queue.Remove(Queue[0]);
                    }
                }
                else
                {
                    loggerDone = true;
                }

                Thread.Sleep(1000);
            }
        });

        public void Init()
        {
            Directory.CreateDirectory("Logs");
            _logFile = Path.Combine("Logs",
                (DateTime.Now + ".log").Replace('/', '-').Replace(':', '-').Replace(' ', '_'));
            _queueHandler.Start();
            AddLines(new[]
            {
                "<=================================================================>",
                "                           Log start",
                "<=================================================================>"
            });
            AddEmpty();
        }

        public void AddEmpty()
        {
            Queue.Add("empty");
            //File.AppendAllText(_logFile, Environment.NewLine);
        }

        private void AddLines(string[] lines, [CallerMemberName] string callerName = "",
            [CallerLineNumber] int callerLine = 0, [CallerFilePath] string callerPath = "")
        {
            var pos = callerPath.LastIndexOf(@"\", StringComparison.Ordinal) + 1;
            callerPath = callerPath.Substring(pos, callerPath.Length - pos);
            foreach (var line in lines)
                Queue.Add($"[{DateTime.Now:hh.mm.ss.ffffff}] : [{callerPath}/{callerName}/{callerLine}] {line}");
            //File.AppendAllText(_logFile, $"[{DateTime.Now.ToString("hh.mm.ss.ffffff")}] : [{callerPath}/{callerName}/{callerLine}] {line}" + Environment.NewLine);
        }

        public void AddLine(string line, [CallerMemberName] string callerName = "",
            [CallerLineNumber] int callerLine = 0, [CallerFilePath] string callerPath = "")
        {
            var pos = callerPath.LastIndexOf(@"\", StringComparison.Ordinal) + 1;
            callerPath = callerPath.Substring(pos, callerPath.Length - pos);
            Queue.Add($"[{DateTime.Now:hh.mm.ss.ffffff}] : [{callerPath}/{callerName}/{callerLine}] {line}");
            //File.AppendAllText(_logFile, $"[{DateTime.Now.ToString("hh.mm.ss.ffffff")}] : [{callerPath}/{callerName}/{callerLine}] {line}" + Environment.NewLine);
        }
    }
}