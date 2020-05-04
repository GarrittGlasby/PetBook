using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class Medication
    {
        public Medication()
        {
            MedicalFile = new HashSet<MedicalFile>();
        }
        [Display(Name = "Medication Id #")]
        public int MedicationId { get; set; }

        [Required]
        [Display(Name = "Name of Medication")]
        public string MedicationName { get; set; }

        [Required]
        [Display(Name = "Medication Issue Date")]
        public DateTime? MedicationIssueDate { get; set; }

        [Required]
        [Display(Name = "Medication Refil Date")]
        public DateTime? MedicationsRefillDate { get; set; }

        [Required]
        [Display(Name = "Medication Description")]
        public string MedicationDescription { get; set; }

        [Required]
        [Display(Name = "Medication Directions")]
        public string MedicationDirections { get; set; }

        public virtual ICollection<MedicalFile> MedicalFile { get; set; }
    }
}
