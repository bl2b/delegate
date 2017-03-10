
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasActionFunct
{
    //Singleton class
    public sealed class Mediator
    {
        //static members
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { } // hide constructor

        public static Mediator GetInstance() {
            return _Instance;
        }

        //Instance Functionality
        public event EventHandler<CustomerChangedEventArgs> CustomerChanged;
        public void OnCustomerChanged(object sender, Customer customer)
        {
            var customerChangeDelegate = CustomerChanged as EventHandler<CustomerChangedEventArgs>;
            if (customerChangeDelegate != null)
            {
                customerChangeDelegate(sender, new CustomerChangedEventArgs { Customer = customer });
            }
        }
    }
}
