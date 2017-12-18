using System;
using System.Threading.Tasks;

namespace AstralNew.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IVacancy Vacancy { get; }
        Task SaveAsync();
    }
}
