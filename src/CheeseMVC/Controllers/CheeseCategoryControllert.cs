using CheeseMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;

namespace CheeseMVC.Controllers
{
    public class CheeseCategoryController : Controller
    {
        private readonly CheeseDbContext context;

        public CheeseCategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<CheeseCategory> category = context.CheeseCategories.ToList();

            return View(category);

        }

        public IActionResult Add()
        {
            AddCheeseCategoryViewModel addCheeseCategoryViewModel = new AddCheeseCategoryViewModel();
            return View(addCheeseCategoryViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCheeseCategoryViewModel addCheeseCategoryViewModel)
        {
            if (ModelState.IsValid)
            {

                CheeseCategory newCheeseCategory = new CheeseCategory
                {
                    Name = addCheeseCategoryViewModel.Name,
                };

                context.CheeseCategories.Add(newCheeseCategory);
                context.SaveChanges();

                return Redirect("/CheeseCategory");
            }

            return View(addCheeseCategoryViewModel);
        }


    }
}
