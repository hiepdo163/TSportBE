﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSport.Api.Models.RequestModels.Order
{
    public class OrderModel
    {
        public int Id { get; set; }

        public string? Code { get; set; }

        public DateTime OrderDate { get; set; }

        public string Status { get; set; } = null!;

        public decimal Total { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedAccountId { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedAccountId { get; set; }
    }
}
