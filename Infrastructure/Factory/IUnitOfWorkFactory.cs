using Infrastructure.UnitOfWork;

namespace Infrastructure.Factory
{
    interface IUnitOfWorkFactory
    {
        IUnitOfWork GetUnitOfWork();
    }
}
