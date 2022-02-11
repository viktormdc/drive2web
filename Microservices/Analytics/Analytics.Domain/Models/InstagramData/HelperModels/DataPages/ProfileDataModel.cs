﻿using Analytics.Domain.Models.InstagramData.HelperModels.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytics.Domain.Models.InstagramData.HelperModels.DataPages
{
   public class ProfileDataModel
    {
        public string name { get; set; }
        public string period { get; set; }
        public ValuesModel[] values { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string id { get; set; }
    }
}
