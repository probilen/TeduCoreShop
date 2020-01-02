using Microsoft.AspNetCore.Identity;
using ShopCoreTedu.Data.Enums;
using ShopCoreTedu.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopCoreTedu.Data.Entities
{
    [Table("AppUser")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }
        public DateTime? BirthDay { get; set; }
        public decimal Balance { get; set; }
        public string Avatar { get; set; }
        public DateTime DateCreated { get;set; }
        public DateTime DateModified { get;set; }
        public Status Status { get;set; }
    }
}
