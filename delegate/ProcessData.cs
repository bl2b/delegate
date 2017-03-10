using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasActionFunct
{
    public class ProcessData
    {
        public void Process(string msg)
        {
            //var result = x + y;
            Console.WriteLine(msg);
        }

        public void ProcessDelegate(int x, int y, BizRulesDelegate del)
        {
            var result = del(x, y);
            Console.WriteLine(result);
        }

        public void ProcessAction(int x, int y, Action<int, int> action)
        {
            action(x, y);
            Console.WriteLine("Action has been processed");
        }

        public void ProcessFunct(int x, int y, Func<int, int, int> func)
        {
            var result = func(x, y);
            Console.WriteLine(result);
        }
    }
}
