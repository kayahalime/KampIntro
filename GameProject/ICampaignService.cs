﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Create(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
        bool Add(Game game);

    }
}
