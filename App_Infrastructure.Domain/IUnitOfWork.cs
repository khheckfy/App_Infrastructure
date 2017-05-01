using App_Infrastructure.Domain.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace App_Infrastructure.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties

        IOrderRepository OrderRepository { get; }

        #endregion

        #region Methods

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        #endregion
    }
}
