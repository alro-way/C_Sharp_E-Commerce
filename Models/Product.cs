using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace C_Sharp_ECommerce.Models 
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "Prodcut Name must be 2 characters or longer!")]
        public string ProductName {get;set;}
        public string Img {get;set;}
        [Required]
        [MinLength(10, ErrorMessage = "Prodcut Description must be 10 characters or longer!")]
        public string Desc {get;set;}
        [Required]
        
        [Range(1,100000000, ErrorMessage = "Quantity could not be 0!")]
        public int Quant {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        List<Order> ProductOrder {get;set;}

    }
}