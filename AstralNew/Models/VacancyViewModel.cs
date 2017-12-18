using AstralNew.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstralNew.Models
{
    public class VacancyViewModel
    {
        public string Search { get; set; }
        public List<Vacancy> Vacancies { get; set; }
    }
}
