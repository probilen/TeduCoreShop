﻿using ShopCoreTedu.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopCoreTedu.Data.Entities
{
    [Table("Permissions")]
    public class Permission :DomainEntity<int>
    {
        [StringLength(128)]
        [Required]
        public string FunctionId { get; set; }
        [StringLength(128)]
        [Required]
        public string RoleId { get; set; }
        public bool CanCreate { get; set; }
        public bool CanRead { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        [ForeignKey("RoleId")]
        public virtual AppRole AppRole { get; set; }
        [ForeignKey("FunctionId")]
        public virtual Function Function { get; set; }
    }
}
