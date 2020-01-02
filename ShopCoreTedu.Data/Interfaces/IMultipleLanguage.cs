using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCoreTedu.Data.Interfaces
{
    public interface IMultipleLanguage<T>
    {
        T LangguageId { get; set; }
    }
}
