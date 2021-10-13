using System.Collections.Generic;
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
            return this;
        }
        private class LazySingleton
        {
            static LazySingleton() { }

            internal static readonly SmirnovLog instance = new SmirnovLog();
        }
    }
}