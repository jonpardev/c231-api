﻿using System.Collections.Generic;
namespace c231_qrder.Models
{
    public class OrderDto
    {
        public string RestaurantId { get; set; }
        public string TableGuid { get; set; }
        public string OrderGuid { get; set; }
        public bool IsArchived { get; set; }
        public List<MenuItem> OrderedItems { get; set; }
    }
}
