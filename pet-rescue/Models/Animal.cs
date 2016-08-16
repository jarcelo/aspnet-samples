using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pet_rescue.Models
{
    public enum Gender
    {
        Male, Female
    }
    public abstract class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public double Weight { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime EnteredShelterDate { get; set; }
        public string Description { get; set; }
        public bool IsNeuteredOrSpayed { get; set; }
        public DateTime EnteredDataDate { get; set; }
        public abstract string Breed { get; set; }
    }
}