﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class CategoryBonus
    {
        public Guid Id { get; set; }
        public string BonusDescription { get; set; }
        public int BonusAmount { get; set; }
    }
}
