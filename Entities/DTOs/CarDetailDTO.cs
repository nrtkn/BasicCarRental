﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDTO : IDTO
    {
        public string BrandName { get; set; }
        public string  ColorName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }



    }
}
