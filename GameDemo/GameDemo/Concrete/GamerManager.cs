using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GamerManager : IGamerServices
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Müşteri Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
}
