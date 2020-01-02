using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ShopCoreTedu.Data.Enums;
using ShopCoreTedu.Data.Interfaces;
using ShopCoreTedu.Infrastructure.SharedKernel;
namespace ShopCoreTedu.Data.Entities
{
    
    public class Product : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public Product()
        {
            ProductTags = new List<ProductTag>();
        }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }
        //Giá khuyến mãi
        public decimal? PromotionPrice { get; set; }
        //Giá gốc
        public decimal OrginalPrice { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }
        public string Tags { get; set; }
        public string Unit { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ProductTag> ProductTags { get; set; }
        public string SeoPageTitle { get;set; }
        [Column(TypeName ="varchar")]
        [StringLength(255)]
        public string SeoAlias { get;set; }
        [StringLength(255)]
        public string SeoKeywords { get;set; }
        [StringLength(255)]
        public string SeoDescription { get;set; }
        public Status Status { get;set; }
        public int SortOrder { get;set; }
        public DateTime DateCreated { get;set; }
        public DateTime DateModified { get;set; }
    }
}
