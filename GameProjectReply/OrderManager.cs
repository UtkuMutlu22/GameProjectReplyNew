using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectReply
{
    class OrderManager : IOrderService
    {
        public void Sell(Gamer gamer)
        {
            Console.WriteLine("Satış Yapıldı.");
        }
    }
}
