﻿using System.ComponentModel.DataAnnotations;

namespace RentCar.Data.Common.BaseModels
{
    public abstract class BaseModel<TKey> : IAuditInfo
    {
        [Key]
        public TKey Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
