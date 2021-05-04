using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entites;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerValidationService gamerValidationService = new GamerValidationManager();
            gamerValidationService.Validation(new Gamer { Id = 1, Name = "Tuncay", Surname ="CAN", TcNo = "55555455455", Birthday = "01.01.1998" });

            IGamerServices gamerServices = new GamerManager();
            gamerServices.Add(new Gamer { Id = 2, Name = "Emirhan", Surname = "CAN", TcNo = "5558886555885", Birthday = "01.01.1997" });
            gamerServices.Delete(new Gamer { Id = 2, Name = "Emirhan", Surname = "CAN", TcNo = "5558886555885", Birthday = "01.01.1997" });
            gamerServices.Update(new Gamer { Id = 2, Name = "Emirhan", Surname = "CAN", TcNo = "5558886555885", Birthday = "01.01.1997" });

            IProductService productService = new ProductManager();
            productService.Add(new Product { Id=1, ProductName="PES13", UnitPrice="135TL", UnitStock="352"});
            productService.Delete(new Product { Id = 1, ProductName = "PES13", UnitPrice = "135TL", UnitStock = "352" });
            productService.Update(new Product { Id = 1, ProductName = "PES19", UnitPrice = "289TL", UnitStock = "125" });

            IOrderService orderService = new OrderManager();
            orderService.Sale(new Order { Id = 1, OrderId = 1, OrderNo = "1", ProductName = "PES13", UnitPrice = "135TL", UnitStock = "352" }, 
                new Gamer { Id = 2, Name = "Emirhan", Surname = "CAN", TcNo = "5558886555885", Birthday = "01.01.1997" }); ; ;

            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(new Campaign { });
            campaignService.Delete(new Campaign{ });
            campaignService.Update(new Campaign { });


        }
    }
}
