using ShopCoreTedu.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopCoreTedu.Data.Entities
{
    [Table("BlogTags")]
    public class BlogTag : DomainEntity<int>
    {
        public int BlogId { set; get; }


        public string TagId { set; get; }

        [ForeignKey("BlogId")]
        public virtual Blog Blog { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
