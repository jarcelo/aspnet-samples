using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pet_rescue.Models
{
    public class Donor : ApplicationUser
    {
        // Contraint: Donor can donate one or more pets at a time
        //TODO: Check the design
        public DateTime? PetDonationDate { get; set; }
        public string Notes { get; set; }

        // Navigation properties
        public virtual ICollection<Pet> DonatedPets { get; set; }

    }
}