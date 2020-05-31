﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModificationDate { get; set; }

        public Guid CreatorId { get; set; }

        public Guid ModifierId { get; set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
