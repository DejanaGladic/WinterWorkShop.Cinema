﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterWorkShop.Cinema.Domain.Responses
{
    public class GetAllProjectionsResponses
    {
        public int Id { get; set; }

        public DateTime DateOfProjection { get; set; }

        public int Minutes { get; set; }
    }
}
