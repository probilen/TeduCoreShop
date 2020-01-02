using ShopCoreTedu.Data.Enums;
using ShopCoreTedu.Data.Interfaces;
using ShopCoreTedu.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopCoreTedu.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public DateTime DateCreated { get;set; }
        public DateTime DateModified { get;set; }
        public int SortOrder { get;set; }
        public Status Status { get;set; }
        [StringLength(255)]
        public string SeoPageTitle { get;set; }
        [StringLength(255)]
        public string SeoAlias { get;set; }
        [StringLength(255)]
        public string SeoKeywords { get;set; }
        [StringLength(255)]
        public string SeoDescription { get;set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
