using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pet_rescue.Models
{
    public enum CatSize
    {
        Kitten, // less than 6 months Old
        Small, // approximately 6 months old/ approximate 6-8 lbs
        Medium, // approximately 9-13 lbs
        Large  // Approximately 14lbs and up
    }
    public enum CatColor
    {
        Grey, White, Black, Orange, Buff
    }
    public class Cat : Animal
    {
        public CatSize Size { get; set; }
        public CatColor Color { get; set; }


        // Implement the abstract property from base class
        public override string Breed { get; set; }
    }
}