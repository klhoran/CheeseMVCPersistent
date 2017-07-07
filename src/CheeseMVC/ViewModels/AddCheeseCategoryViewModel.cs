using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;


namespace CheeseMVC.ViewModels
{
    public class AddCheeseCategoryViewModel
    {
        [Required(ErrorMessage ="Cheese Category Needed")]
        [Display(Name = "Cheese Category Name")]
        public string Name { get; set; }
    }
}
