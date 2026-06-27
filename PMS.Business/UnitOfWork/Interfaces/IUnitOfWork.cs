using PMS.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Business.UnitOfWork.Interfaces
{
    /// <summary>
    /// Defines the contract for a unit of work, which is responsible for
    /// coordinating the work of multiple repositories and
    /// ensuring that all operations are completed successfully before committing changes to the database.
    /// </summary>
    public interface IUnitOfWork: IDisposable
    {
        IProductRepository ProductRepository { get; }

        Task<int> SaveChanges(CancellationToken cancellationToken=default);
    }
}
