using System.Net.Http;
using System.Threading.Tasks;
using AstralNew.DAL.Interfaces;
using AstralNew.DAL.Models;
using AstralNew.DAL.Models.Json.hh;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;

namespace AstralNew.DAL.Repositories
{
    public class VacancyRepository : IVacancy
    {
        private readonly AstralNewContext _astralNewContext;
        public VacancyRepository(AstralNewContext astralNewContext) => _astralNewContext = astralNewContext;
        public async Task<List<Vacancy>> GetAllAsync(string search)
        {
            try {
                return await GetFromApi(search);
            }
            catch {
                return await GetAllFromDb(search);
            }
        }

                
        public async Task InsertRangeAsync(List<Vacancy> vacancies)
        {
            var allFromDb = await GetAllFromDb();
            foreach(var vacancy in vacancies)
            {
                if(!allFromDb.Any(afd=>afd.VacancyId == vacancy.VacancyId))
                {
                    _astralNewContext.Vacancy.Add(vacancy);
                }
            }
        }

        private async Task<List<Vacancy>> GetFromApi(string text)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", "test-app");
            var url = "https://api.hh.ru/vacancies/?per_page=50&text=" + text;
            var task = await client.GetAsync(url);
            return RootObject.FromJson(task.Content.ReadAsStringAsync().Result).Items.Select(i => new Vacancy()
            {
                Name = i.Name,
                Requirement = i.Snippet.Requirement,
                Responsibility = i.Snippet.Responsibility,
                SalaryTo = i.Salary?.To,
                SalaryFrom = i.Salary?.From,
                Currency = i.Salary?.Currency,
                Employer = i.Employer?.Name,
                CreatedDate = i.PublishedAt,
                VacancyId = i.Id,
            }).ToList();
        }
        private async Task<List<Vacancy>> GetAllFromDb()
        {
            return await _astralNewContext.Vacancy.ToListAsync();
        }
        private async Task<List<Vacancy>> GetAllFromDb(string search)
        {
            IQueryable<Vacancy> resultEmployer = _astralNewContext.Vacancy.Where(p => p.Employer.ToLower().Contains(search));
            IQueryable<Vacancy> resultRequirement = _astralNewContext.Vacancy.Where(p => p.Requirement.ToLower().Contains(search));
            IQueryable<Vacancy> resultResponsibility = _astralNewContext.Vacancy.Where(p => p.Responsibility.ToLower().Contains(search));
            return await resultEmployer.Concat(resultRequirement).Concat(resultResponsibility).Distinct().Take(50).ToListAsync();
        }
    }
}
