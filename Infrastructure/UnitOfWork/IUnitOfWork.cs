using System;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //IRepository<Enrollment> EnrollmentRepository { get; }

        void Save();
        Task<int> SaveAsync();
        Task<bool> SaveAsyncBool();
    }
}
