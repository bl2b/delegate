using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasActionFunct
{
    public delegate int BizRulesDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            //lambdas delegate
            var data = new ProcessData();
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;
            data.ProcessDelegate(2, 4, addDel);
            data.ProcessDelegate(2, 4, multiplyDel);

            //Action of T
            Action<int, int> myAddAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);
            data.ProcessAction(2, 4, myAddAction);
            data.ProcessAction(2, 4, myMultiplyAction);
            Action<string> actionEmpty;
            //actionEmpty = Console.WriteLine;
            //actionEmpty("Hi");
            actionEmpty = data.Process;
            actionEmpty("Hello");

            //Func of T(parameter) TResult(result)
            Func<int, int, int> myAddFunc = (x, y) => x + y;
            Func<int, int, int> myMultiplyFunc = (x, y) => x * y;
            data.ProcessFunct(5, 5, myAddFunc);
            data.ProcessFunct(5, 5, myMultiplyFunc);

            //Lambdas and Func of T TResult to query objects
            var custs = new List<Customer>
            {
                new Customer { City = "Phoenix", FirstName = "John", LastName = "Doe", Id = 1},
                new Customer { City = "Phoenix", FirstName = "Jane", LastName = "Doe", Id = 2}
            };

            var phxCusts = custs
                .Where(c => c.City == "Phoenix")
                .OrderBy(c => c.Id);
            foreach (var cust in phxCusts)
            {
                Console.WriteLine(cust.FirstName);
                Mediator.GetInstance().OnCustomerChanged(null, cust);
                Mediator.GetInstance().CustomerChanged += (s, e) =>
                {
                    Console.WriteLine(e.Customer);
                };
            }

            

            Console.ReadLine();
        }
    }
}

