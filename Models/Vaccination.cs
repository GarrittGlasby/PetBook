using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class Vaccination
    {
        public Vaccination()
        {
            MedicalFile = new HashSet<MedicalFile>();
        }
        [Display(Name = "Vaccination Id #")]
        public int VaccinationId { get; set; }

        [Required]
        [Display(Name = "Name of Vaccination")]
        public string VaccinationName { get; set; }

        [Required]
        [Display(Name = "Date of Vaccination")]
        public DateTime? VaccinationDate { get; set; }

        [Required]
        [Display(Name = "Type of Vaccination")]
        public string VaccinationType { get; set; }

        [Required]
        [Display(Name = "Vaccination Expiry Date")]
        public DateTime? VaccinationExpiryDate { get; set; }

        [Required]
        [Display(Name = "Vaccination Notes")]
        public string VaccinationNotes { get; set; }

        public virtual ICollection<MedicalFile> MedicalFile { get; set; }
    }
}
