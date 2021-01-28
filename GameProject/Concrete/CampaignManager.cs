using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager: ICampaignManager

    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " " + "Adlı kampanya eklendi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " " + "Adlı kampanya silindi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " " + "Adlı kampanya güncellendi.");
        }
    }
}
