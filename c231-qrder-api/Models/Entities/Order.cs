﻿using Amazon.DynamoDBv2.DataModel;
using System.Collections.Generic;

namespace c231_qrder.Models
{
    [DynamoDBTable("restaurants")]
    public class Order
    {
        [DynamoDBHashKey]
        public string RestaurantId { get; set; }
        [DynamoDBRangeKey("SortKey")]
        public string OrderId { get; set; }
        [DynamoDBProperty]
        public string TableGuid { get; set; }
        public string OrderGuid { get; set; }
        public bool IsArchived { get; set; }
        public List<MenuItem> OrderedItems { get; set; }

        [DynamoDBIgnore]
        public static string orderSortKeyPrefix = "ORDER#";
    }
}
