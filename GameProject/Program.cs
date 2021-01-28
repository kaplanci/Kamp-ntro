using System;
using GameProject.Abstract;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewStateValidationManager());
            gamerManager.add(new Gamer{Id =1,BirthYear = 1984, FirstName = "Engin",LastName = "Demirog",IdentityNumber = 12345});

            Gamer gamer1 = new Gamer { Id = 1, FirstName = "Gizem", LastName = "Tok", IdentityNumber = 1234567899,BirthYear = 1995 };
           Gamer gamer2 = new Gamer { Id = 2, FirstName = "Murat", LastName = "Işık", IdentityNumber= 1234867099, BirthYear = 1998 };

            Game game1 = new Game { Id = 1, GameName = "FİFA", UnitPrice = 300 };
            Game game2 = new Game { Id = 2, GameName = "GTA", UnitPrice = 200 };

            IGameService gameService = new GameManager();
            gameService.Sell(gamer1);
            ICampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign { Id = 1, Name = "haftasonu indirimi", Discount = 0.2 };
            Campaign campaign2 = new Campaign { Id = 2, Name = "öğrenci indirimi", Discount = 0.5 };
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign1);


        }
    }
}
