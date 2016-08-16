using System;
using System.Collections.Generic;
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
        XSmall, // Under 10 lbs
        Small,  // 10-25 lbs
        Medium, // 20-50 lbs
        Large,  // 50-75 lbs
        XLarge, // 75-90 lbs
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