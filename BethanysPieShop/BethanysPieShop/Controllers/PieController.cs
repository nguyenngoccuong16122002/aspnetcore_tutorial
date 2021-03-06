using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Cheese cakes";

            return View(_pieRepository.AllPies);
           // PiesListViewModel piesListViewModel = new PiesListViewModel();
           // piesListViewModel.Pies = _pieRepository.AllPies;

           // piesListViewModel.CurrentCategory = "Cheese cakes";
           // return View(piesListViewModel);
        }
    }
}
