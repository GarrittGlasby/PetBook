using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            MedicalFile = new HashSet<MedicalFile>();
        }
        [Display(Name = "Appointment Id #")]
        public int AppointmentId { get; set; }
        [Display(Name = "Date of Appointment")]
        public DateTime? AppointmentDate { get; set; }
        [Display(Name = "Appointment Description")]
        public string AppointmentDescription { get; set; }


        public virtual ICollection<MedicalFile> MedicalFile { get; set; }
    }
}
