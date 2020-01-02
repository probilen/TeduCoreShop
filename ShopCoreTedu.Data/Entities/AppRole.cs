using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopCoreTedu.Data.Entities
{
    [Table("AppRoles")]
    public class AppRole : IdentityRole<Guid>
    {
        [StringLength(250)]
        public string Description { get; set; }
        public AppRole() : base()
        {

        }
        public AppRole(string name, string description) : base(name)
        {
            this.Description = description;
        }
    }
}
