﻿using System;
using System.Collections.Generic;

namespace Email.MyModel.Models
{
    public partial class SellSecondStepCustomer
    {
        public int SecondStepCustomerId { get; set; }
        public int? SecondStepCustomerForeignId { get; set; }
        public string? FullName { get; set; }
        public string? Number { get; set; }
        public DateTime? DirectCustomerDate { get; set; }
        public string? Email { get; set; }
        public bool? IsTake { get; set; }

        public virtual Sell? SecondStepCustomerForeign { get; set; }
    }
}
