using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {Id = 1, BirthYear = 1999,FirstName = "Halime", LastName = "Kaya",IdendityNumber = 12345});
            gamerManager.Add(new Gamer { Id = 2, BirthYear = 1995, FirstName = "Ceren", LastName = "Bingöl", IdendityNumber = 123456 });

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { Id = 1,GameName = "PUBG", UnitPrice = 50 });
            gameManager.Add(new Game {Id = 2,GameName = "GTA5", UnitPrice=50});

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Create(new Campaign {Id=1, CampaignName= "Pubg indirimi", Discount=10 });

            OrderManager order = new OrderManager(new CampaignManager());
            order.Create(new Game {Id=1, GameName= "PUBG"  });
            



        }
    }
}
