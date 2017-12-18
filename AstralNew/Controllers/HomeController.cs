using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AstralNew.Models;
using AstralNew.DAL.Interfaces;
using AstralNew.DAL.Models;

namespace AstralNew.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            VacancyViewModel vacancyViewModel = new VacancyViewModel() {
                Vacancies = await _unitOfWork.Vacancy.GetAllAsync("")
            };
            await _unitOfWork.Vacancy.InsertRangeAsync(vacancyViewModel.Vacancies);
            await _unitOfWork.SaveAsync();

            return View(vacancyViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(VacancyViewModel vacancyViewModel)
        {
            vacancyViewModel.Vacancies = await _unitOfWork.Vacancy.GetAllAsync(vacancyViewModel.Search.ToLower());
            await _unitOfWork.Vacancy.InsertRangeAsync(vacancyViewModel.Vacancies);
            await _unitOfWork.SaveAsync();

            return View(vacancyViewModel);
        }
    }
}
