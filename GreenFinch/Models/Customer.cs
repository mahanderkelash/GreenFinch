using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreenFinch.Models
{
    public class Customer
    {
        public int   Id { get; set; }

        [Required(ErrorMessage = "Please provide username", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
        ErrorMessage = "Please provide valid email id")]
        [Required(ErrorMessage = "Please provide email", AllowEmptyStrings = false)]
        public string Email { get; set; } 
        public heared heare { get; set; }
    }

    public enum heared {
        wordofmouth ,
        advert ,
        other

    }

    
}