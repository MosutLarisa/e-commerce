using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    internal class OrderProcessor
    {
        public void FulfillOrder(Order order, PaymentSystem paymentSystem)
        {
            paymentSystem.Payment(order.Total);

        }

    }
}
