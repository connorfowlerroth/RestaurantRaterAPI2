using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterAPI.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForwignKey("Restaurant")]
        public int RestaurantId { get; set; }
        [Required]
        public double FoodScore { get; set; }
        [Required]
        public double CleanlinessScore { get; set; }
        [Required]
        public double AtmosphereScore { get; set; }
    }
}