﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CampaignPercentDiscount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
