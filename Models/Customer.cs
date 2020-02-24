using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace C_Sharp_ECommerce.Models 
{
    public class Customer 
    {
        [Key]
        public int CustomerId {get;set;}
        [Required]
        [MinLength(4, ErrorMessage = "Name must be 4 characters or longer!")]
        public string Name {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        List<Order> UserOrder {get;set;}

    }
}