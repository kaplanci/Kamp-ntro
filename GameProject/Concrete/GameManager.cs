using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject
{
    class GameManager :IGameService
    {
        public void Sell(Gamer gamer)
        {
            Console.WriteLine("oyun satış yapıldı." + " " + gamer.FirstName);
        }

        public void SellWithCampaign(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("kampanyalı fiyattan satış yapıldı.");
        }
    }
}
