using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Vereniging
    {
        public int Id { get; set; }
        public string Dbname { get; set; }
        public string DbPasswoord { get; set; }
        [Required(ErrorMessage = "This field can not be empty.")]
        [MinLength(1)]
        [Display(Name = "Naam van de vereniging")]
        public string VerenigingNaam { get; set; }

        [Required(ErrorMessage = "This field can not be empty.")]
        [MinLength(1)]
        [Display(Name = "Straat + NR")]
        public string StraatNr { get; set; }

        [Required(ErrorMessage = "This field can not be empty.")]
        [MinLength(1)]
        [Display(Name = "Postcode")]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "This field can not be empty.")]
        [MinLength(1)]
        [Display(Name = "Plaats")]
        public string Locatie { get; set; }

        [Required(ErrorMessage = "This field can not be empty.")]
        [MinLength(1)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field can not be empty.")]
        [MinLength(1)]
        [Display(Name = "Telefoon nummer")]
        public string Telefoon { get; set; }

        [Required(ErrorMessage = "This field can not be empty.")]
        [Display(Name = "Login naam")]
        public string login { get; set; }

        [Required(ErrorMessage = "This field can not be empty.")]
        [MinLength(1)]
        [Display(Name = "Paswoord")]
        public string Passwoord { get; set; }
    }
}