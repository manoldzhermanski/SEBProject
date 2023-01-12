using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEBProject.Models
{
    public enum FoodCategory
    {
       SALAD,
       MAIN,
    }
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodId { get; set; }

        [Required, StringLength(30), Display(Name = "Name")]
        public string Name { get; set; }

        [Required, Display(Name = "Price")]
        [RegularExpression(@"^\d+(,\d{3})*(\.\d{1,2})?$")]
        public double Price { get; set; }

        [Required, Range(0, 200), Display(Name = "Quantity")]
        public int Quantity { get; set; }
        public string Image { get; set; }

        public List<string> Ingredients { get; set; }

        [Required, Display(Name = "Category")]
        public FoodCategory FoodCategory { get; set; }

    }
}