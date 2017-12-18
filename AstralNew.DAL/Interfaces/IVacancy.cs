using AstralNew.DAL.Models;
using AstralNew.DAL.Models.Json.hh;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AstralNew.DAL.Interfaces
{
    public interface IVacancy
    {
        Task<List<Vacancy>> GetAllAsync(string text);
        Task InsertRangeAsync(List<Vacancy> vacancies);
    }
}
