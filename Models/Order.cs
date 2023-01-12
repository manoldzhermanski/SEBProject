using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SEBProject.Models
{
    public enum OrderCategory
    {
        DONATION,
        FOR_COMSUMATION
    }
    public class Order
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string OrderID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required, StringLength(50)]
        public string Address { get; set; }

        public double Total { get; set; }

        public OrderCategory OrderCategory { get; set; }

        public List<Food> FoodOrder { get; set; }
    }
}