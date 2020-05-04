using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class MedicalProcedure
    {
        public MedicalProcedure()
        {
            MedicalFile = new HashSet<MedicalFile>();
        }
        [Display(Name = "Procedure Id #")]
        public int ProcedureId { get; set; }

        [Required]
        [Display(Name = "Type of Procedure")]
        public string ProcedureType { get; set; }

        [Required]
        [Display(Name = "Date of Procedure")]
        public DateTime? ProcedureDate { get; set; }

        [Required]
        [Display(Name = "Procedure Notes")]
        public string ProcedureNotes { get; set; }

        [Required]
        [Display(Name = "Date for Procedure follow up")]
        public DateTime? ProcedureFollowUp { get; set; }

        public virtual ICollection<MedicalFile> MedicalFile { get; set; }
    }
}
