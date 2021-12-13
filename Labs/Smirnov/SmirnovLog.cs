using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using core;

namespace Smirnov
{
    public class SmirnovLog : LogAbstract, ILogInterface
    {
        private List<string> logs;
        private SmirnovLog()
        {
            logs = new List<string>();
        }
        public static SmirnovLog I()
        {
            return LazySingleton.instance;
        }
        public ILogInterface Log(string str)
        {
            logs.Add(str);
            return this;
        }
        public ILogInterface Write()
        {
            WriteConsole(logs.ToArray());
            string fileName = @"log\" + DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss.ms") + ".log";
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\log");
            string[] output = logs.ToArray();
            using (var sw = new StreamWriter(fileName,true ,Encoding.UTF8))
            {
                sw.WriteLine(FormatLog(output));

            }
            return this;
        }
        private class LazySingleton
        {
            static LazySingleton() { }

            internal static readonly SmirnovLog instance = new SmirnovLog();
        }
    }
}