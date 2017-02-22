using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Diner2;
using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models
{
    public class Cart
    {
        [Required(ErrorMessage = "enter you name")]
        public string  CustomerName { get; set; }
        public int Phone { get; set; }
        public FoodItem Food { get; set; }
    }
}