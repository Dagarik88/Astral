using System;
using System.Collections.Generic;
using System.Text;

namespace AstralNew.DAL.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public int VacancyId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal? SalaryFrom { get; set; }
        public decimal? SalaryTo { get; set; }
        public string Currency { get; set; }
        public string Employer { get; set; }
        public string Requirement { get; set; }
        public string Responsibility { get; set; }
    }
}
