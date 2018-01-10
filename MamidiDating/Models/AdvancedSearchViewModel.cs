using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamidiDating.Models
{
    public class AdvancedSearchViewModel
    {
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Age Range")]
        public string AgeRange { get; set; }

        [Display(Name = "Relationship Type")]
        public string RelationshipType { get; set; }

        [Display(Name = "Relationship Requirements")]
        public string RelationshipRequirements { get; set; }

        [Display(Name = "Ethnicity")]
        public string Ethnicity { get; set; }

        [Display(Name = "Education")]
        public string Education { get; set; }

        [Display(Name = "Profession")]
        public string Profession { get; set; }

        [Display(Name = "Body Type")]
        public string BodyType { get; set; }

        [Display(Name = "Smoking Status")]
        public string SmokingStatus { get; set; }
        public bool IsSmoker { get; set; }
        public bool IsNonSmoker { get; set; }
        public bool IsSmokerNonSmoker { get; set; }

        [Display(Name = "Illicit Drug User")]
        public string IllicitDrugUser { get; set; }
        public bool IsIllicitDrugUser { get; set; }
        public bool IsNonIllicitDrugUser { get; set; }
        public bool IsIllicitNonIllicitDrugUser { get; set; }

        [Display(Name = "Marijuana User")]
        public string MarijuanaUser { get; set; }
        public bool IsMarijuanaUser { get; set; }
        public bool IsNonMarijuanaUser { get; set; }
        public bool IsMarijuanaNonMarijuanaUser { get; set; }

        [Display(Name = "Drinking Status")]
        public string DrinkingStatus { get; set; }

        [Display(Name = "Interests")]
        public string Interests { get; set; }
        
        [Display(Name = "Deal Breakers")]
        public string DealBreakers { get; set; }

        [Display(Name = "Height")]
        public string Height { get; set; }

        [Display(Name = "Religion")]
        public string Religion { get; set; }

        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Hair Length")]
        public string HairLength { get; set; }

        [Display(Name = "Hair Color")]
        public string HairColor { get; set; }

        [Display(Name = "Eye Color")]
        public string EyeColor { get; set; }

        [Display(Name = "Body Art")]
        public string BodyArt { get; set; }

        [Display(Name = "Piercings")]
        public string Piercings { get; set; }

        [Display(Name = "Has Pets")]
        public string HasPets { get; set; }

        [Display(Name = "Wants Pets")]
        public string WantPets { get; set; }

        [Display(Name = "Has Children")]
        public string HasChildren { get; set; }

        [Display(Name = "Wants Children")]
        public string WantChildren { get; set; }

        [Display(Name = "Date Someone With Children")]
        public string DateSomeoneChildren { get; set; }

        [Display(Name = "My Longest Relationship Was...")]
        public string LongestRelationship { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Distance (miles)")]
        public int Distance { get; set; }

        //[Display(Name = "Other Specified")]
        //public string OtherSpecified { get; set; }

        public bool IsYes { get; set; }
        public bool IsNo { get; set; }
        public bool IsYesNo { get; set; }
        public bool IsMaybe { get; set; }
        public bool IsYesNoMaybe { get; set; }
        
    }
}