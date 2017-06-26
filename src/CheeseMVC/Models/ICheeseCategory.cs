using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public interface ICheeseCategory
    {
        IList<Cheese> Cheeses { get; set; }
        int ID { get; set; }
        string Name { get; set; }
    }
}