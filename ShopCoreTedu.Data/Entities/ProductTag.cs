﻿using ShopCoreTedu.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopCoreTedu.Data.Entities
{
    public class ProductTag:DomainEntity<int>
    {
        public int ProductId { get; set; }
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string TagId { set; get; }
        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
