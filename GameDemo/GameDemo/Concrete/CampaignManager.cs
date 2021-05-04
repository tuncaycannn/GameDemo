﻿using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni Kampanya Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(" Kampanya Silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(" Kampanya Güncellendi.");
        }
    }
}
