﻿using System.ComponentModel.DataAnnotations;

namespace PricatApp.Domain.Common
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
