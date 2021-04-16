using System;
using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string Type { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }

    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }
  }
}