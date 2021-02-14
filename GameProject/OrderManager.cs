using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;
        public OrderManager(ICampaignService campaignService)
        {
            campaignService = _campaignService;
                
        }
        public void Create( Game game)
        {
            if (_campaignService.Add(game)==true)
            {
                Console.WriteLine("Kampanya'dan Faydalanıyorsunuz.");
            }
            else
            {
                Console.WriteLine("Siparişiniz kampanya koşullarına uygun olmadığı için kampanyadan faydalanamıyorsunuz..");
            }
        }
    }
}
