using ShopCoreTedu.Infrastructure.Interfaces;

namespace ShopCoreTedu.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public EFUnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
