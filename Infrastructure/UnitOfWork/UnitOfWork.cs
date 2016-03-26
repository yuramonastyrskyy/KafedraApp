using System;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KafedraDatabaseContext _context = new KafedraDatabaseContext();
        private bool _disposed;

        //private IRepository<Ticket> _ticketRepository;//Тутка будуть репозиторії

        //public IRepository<Role> RoleRepository
        //{
        //    get
        //    {
        //        return _roleRepository ?? (_roleRepository = new EfRepository<Role>(_context));
        //    }
        //}

        public void Save()
        {
            _context.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        public async Task<bool> SaveAsyncBool()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
