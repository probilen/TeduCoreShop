using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCoreTedu.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
