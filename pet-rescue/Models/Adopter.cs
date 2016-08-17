using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pet_rescue.Models
{
    public enum Housing
    {
        House,
        [Display(Name = "Apartment/Condo")]
        ApartmentOrCondo,
        Townhouse 
    }
    public enum AdoptionReason
    {
        [Display(Name = "Companion for self")]
        CompanionForSelf,
        [Display(Name = "Companion for child")]
        CompanionForChild,
        [Display(Name = "Companion for another pet")]
        CompanionForAnotherPet,
        [Display(Name = "Companion for another household member")]
        CompanionForAnotherHouseholdMember,
        [Display(Name = "Gift to a loved one")]
        Gift,
        [Display(Name = "Watchdog")]
        WatchDog
    }
    public class Adopter : ApplicationUser
    {
        // Constraint: Adopter can adopt a pet one at a time
        public DateTime PetAdoptionDate { get; set; }
        public Housing Housing { get; set; }
        public AdoptionReason AdoptionReason { get; set; }

        // Navigation Properties
        public virtual ICollection<Pet> Animals { get; set; }

    }
}