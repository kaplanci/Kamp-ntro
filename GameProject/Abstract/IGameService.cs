using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameService
    {
        void Sell(Gamer gamer);
        void SellWithCampaign(Gamer gamer, Campaign campaign);
    }
}
