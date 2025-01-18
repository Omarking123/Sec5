using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec5.Sealed
{
    internal sealed class PaymentProcessor
    {
        public void ProccessPayment(decimal Amount)
        {
            Console.WriteLine($"Amount {Amount}");

        }
    }

    //internal class MyPayymentProcessor : PaymentProcessor
    //{
    //    public void ProccessPayment(decimal Amount)
    //    {
    //        Console.WriteLine($"Amount : {Amount + 20}");
    //    }
    //}
}
