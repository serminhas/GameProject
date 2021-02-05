using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {

        public void Buy()
        {
            Console.WriteLine("Sipariş alındı. Kampanya uygulandı");
        }
    }
}
