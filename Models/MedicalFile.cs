using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class MedicalFile
    {
        public MedicalFile()
        {
            PetMed = new HashSet<PetMed>();
        }

        [Display(Name = "Medical File Id #")]
        public int MedicalFileId { get; set; }
        [Display(Name = "Pet Id #")]
        public int? PetId { get; set; }
        [Display(Name = "Vaccination Id #")]
        public int? VaccinationId { get; set; }
        [Display(Name = "Medication Id #")]
        public int? MedicationId { get; set; }
        [Display(Name = "Procedure Id #")]
        public int? ProcedureId { get; set; }
        [Display(Name = "Appointment Id #")]
        public int? AppointmentId { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual Medication Medication { get; set; }
        public virtual Pet Pet { get; set; }
        public virtual MedicalProcedure Procedure { get; set; }
        public virtual Vaccination Vaccination { get; set; }
        public virtual ICollection<PetMed> PetMed { get; set; }
    }
}
