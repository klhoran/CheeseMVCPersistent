using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        
        public int CheeseCategoryID { get; set; }
        public CheeseCategory CheeseCategory { get; set; }

        public IList<CheeseMenu> CheeseMenus { get; set; }
    }
}
