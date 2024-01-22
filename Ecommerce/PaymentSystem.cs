using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    abstract class PaymentSystem
    {
        public abstract void Payment(decimal a);

    }
    class Card : PaymentSystem
    {
        public override void Payment(decimal a) 
        {
            Console.WriteLine();
        }

    }

    class PayPal : PaymentSystem
    {
        public override void Payment(decimal a)
        {
            Console.WriteLine();
        }

    }

    class Crypto : PaymentSystem
    {
        public override void Payment(decimal a)
        {
            Console.WriteLine();
        }

    }
}
