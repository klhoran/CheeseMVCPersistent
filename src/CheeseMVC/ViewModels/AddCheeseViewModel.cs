using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Cheese Category")]
        public int CheeseCategoryID { get; set; }

        public List<SelectListItem> CheeseCategories { get; set; }

        public AddCheeseViewModel() { }

        public AddCheeseViewModel(IEnumerable<CheeseCategory> cheesecategories)
        { 

            CheeseCategories = new List<SelectListItem>();

            foreach (var cheesecategory in cheesecategories)
            {
                CheeseCategories.Add(new SelectListItem
                {
                    Value = (cheesecategory.ID).ToString(),
                    Text = cheesecategory.Name
                });
            }

        }
    }
}
