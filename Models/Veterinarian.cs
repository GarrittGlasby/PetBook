using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class Veterinarian
    {
        public Veterinarian()
        {
            ClientVet = new HashSet<ClientVet>();
        }
        [Display(Name = "Vet Id #")]
        public int VetId { get; set; }

        [Required]
        [Display(Name = "Vet Name")]
        public string VetName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Vet E-mail Address")]
        public string VetEMail { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string VetStreetAddress { get; set; }

        [Required]
        [Display(Name = "Town or City")]
        public string TownOrCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string VetPhoneNumber { get; set; }
        public string VetProfileImagePath { get; set; }

        public virtual ICollection<ClientVet> ClientVet { get; set; }
    }
}
