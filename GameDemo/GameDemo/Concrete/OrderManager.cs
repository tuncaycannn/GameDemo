using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class OrderManager : IOrderService
    {
        public void Sale(Order order, Gamer gamer )
        {
            Console.WriteLine("Ürün Satışı Yapıldı");
        }
    }
}
