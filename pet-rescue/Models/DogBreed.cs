using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pet_rescue.Models
{
    public class DogBreed
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Check the navigations keys

        // A dog breed will map to a collection of dog instance
        public ICollection<Dog> Dogs { get; set; }
    }
}