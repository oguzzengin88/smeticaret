﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
    public class OrderEntity : EntityBase
    {
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DeliveryAddress { get; set; }


    }
}
