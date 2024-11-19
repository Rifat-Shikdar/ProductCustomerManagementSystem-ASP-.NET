using ProductCustomerManagementSystem.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductCustomerManagementSystem.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z.-]+$", ErrorMessage = "Name can only contain alphabetic character ")]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required(ErrorMessage ="Please provide the price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please provide the Quantity")]
        public int StockQuantity { get; set; }

        [Required(ErrorMessage = "Please provide the Category")]
        public string Category { get; set; }


        public int CategoryId { get; set; }

        public virtual Category Category1 { get; set; }
    }
}