using PMS.Business.UnitOfWork.Interfaces;
using PMS.Repository.PmsDbContext;
using PMS.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Business.UnitOfWork
{
    public class UnitOfWork(
        PmsDbContext context,
        IProductRepository productRepository
        ) : IUnitOfWork
    {
        public IProductRepository ProductRepository { get; } = productRepository;

        /// <summary>
        /// Disposes the unit of work and releases any resources held by the repositories.
        /// </summary>
        public void Dispose()
        {
            context.Dispose();
        }

        public async Task<int> SaveChanges(CancellationToken cancellationToken = default)
        {
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
