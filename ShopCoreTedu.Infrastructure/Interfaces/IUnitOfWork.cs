using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCoreTedu.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call Save change from db context
        /// </summary>
        void Commit();
    }
}
