using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public bool Add(Game game)
        {
            if (game.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void Create(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
