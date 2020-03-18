using System.Collections.Generic;

namespace RestaurantTown.Models
{
    public class RestaurantTown
    {
        public RestaurantTown()
        {
            this.Cuisines = new HashSet<Cuisine>();
        }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Cuisine> Cuisines { get; set; }
    }
}