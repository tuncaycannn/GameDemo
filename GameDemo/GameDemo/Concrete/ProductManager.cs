using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine("Yeni Ürün Eklendi");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Ürün Silindi");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi");
        }
    }
}
