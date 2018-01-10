using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamidiDating.Models
{
    public class BasicSearchViewModel
    {
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Age Range")]
        public string AgeRange { get; set; }

        [Display(Name = "Relationship Type")]
        public string RelationshipType { get; set; }

        //[Display(Name = "If Other, Please Specify")]
        //public string OtherSpecified { get; set; }

        [Display(Name = "Relationship Requirements")]
        public string RelationshipRequirements { get; set; }

        [Display(Name = "Ethnicity")]
        public string Ethnicity { get; set; }

        [Display(Name = "Body Type")]
        public string BodyType { get; set; }

        [Display(Name = "Smoking Status")]
        public string SmokingStatus { get; set; }
        public bool IsSmoker { get; set; }
        public bool IsNonSmoker { get; set; }
        public bool IsSmokerNonSmoker { get; set; }

        [Display(Name = "Illicit Drug Use")]
        public string IllicitDrugUser { get; set; }
        public bool IsIllicitDrugUser { get; set; }
        public bool IsNonIllicitDrugUser { get; set; }
        public bool IsIllicitNonIllicitDrugUser { get; set; }


        [Display(Name = "Marijuana Use")]
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

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Distance (miles)")]
        public int Distance { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }
}