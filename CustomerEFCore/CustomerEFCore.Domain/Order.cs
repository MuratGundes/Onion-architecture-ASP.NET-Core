﻿using System;
using System.Collections.Generic;

namespace CustomerEFCore.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customers { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}