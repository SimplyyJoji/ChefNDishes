using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefNDishes.Models
{
    public class Dish
    {
         [Key] // denotes PK, not needed if named ModelNameId
        public int DishId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Calories")]
        public int Calories { get; set; }

        [Required(ErrorMessage = "is required.")]
        public int Taste { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* Relationship properties: Foreign Keys & Navigation Properties */
        public int UserId { get; set; } // FK 1 User : Many Post
        // Navigation Property for 1 User : Many Post
        public User Author { get; set; }
        
    }
}