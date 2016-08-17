using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pet_rescue.Models
{
    public enum Color
    {
        Brown,
        Red,
        Gold,
        Cream,
        Fawn,
        Black,
        Blue,
        Grey,
        White
    }
    public enum DogSize 
    {
        [Display(Name = "X-Small")]
        XSmall, // Under 10 lbs
        [Display(Name = "Small")]
        Small,  // 10-25 lbs
        [Display (Name = "Medium")]
        Medium, // 20-50 lbs
        [Display (Name = "Large")]
        Large,  // 50-75 lbs
        [Display(Name = "X-Large")]
        XLarge, // 75-90 lbs
        [Display(Name = "XX-Large")]
        XXLarge, // 90 lbs +
    }
    public class Dog : Animal
    {
        public Color Color { get; set; }
        public DogSize Size { get; set; }

        // Implement abstract property from base class
        public override string Breed { get; set; }
    }
}