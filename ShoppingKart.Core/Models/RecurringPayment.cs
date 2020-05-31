﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
    public class RecurringPayment
    {
        public int Id { get; set; }
        public int InitialOrderId { get; set; }
        public int CycleLength { get; set; }
        public int CyclePeriodId { get; set; }
        public int TotalCycles { get; set; }
        public DateTime StartDateUtc { get; set; }
        public bool IsActive { get; set; }
        public bool LastPaymentFailed { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
    public class RecurringPaymentHistory
    {
        public int Id { get; set; }
        public int RecurringPaymentId { get; set; }
        public int OrderId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

    }
}
