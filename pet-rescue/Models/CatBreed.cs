using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pet_rescue.Models
{
    public class CatBreed
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        // Check the navigatins keys 

        // A cat breed will map to a collections of cat instance
        public ICollection<Cat> Cats { get; set; }
    }
}