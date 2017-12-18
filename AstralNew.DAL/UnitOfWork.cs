using AstralNew.DAL.Interfaces;
using AstralNew.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AstralNew.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AstralNewContext _astralNewContext;
        private VacancyRepository _vacancyRepository;
        public UnitOfWork(AstralNewContext astralNewContext) => _astralNewContext = astralNewContext;

        private bool disposed = false;

        public IVacancy Vacancy => _vacancyRepository??(_vacancyRepository = new VacancyRepository(_astralNewContext));


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            await _astralNewContext.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _astralNewContext.Dispose();
                }
                disposed = true;
            }
        }
    }
}
