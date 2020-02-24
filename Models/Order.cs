using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace C_Sharp_ECommerce.Models 
{
    public class Order
    {
        [Key]
        public int OrderId {get;set;}
        public int CustomerId {get;set;}
        public Customer Buyer {get;set;}
        public int ProductId {get;set;}
        public Product Purchase {get;set;}
        [Display(Name="Order Quantity")]
        [Required(ErrorMessage = "Quantity could not be 0!")]
        [Range(1,100000000, ErrorMessage = "Quantity could not be 0!")]

        public int OrderQuantity {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;



    }
}