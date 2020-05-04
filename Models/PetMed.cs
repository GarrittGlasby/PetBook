using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class PetMed
    {
        public int IdexNumber { get; set; }
        [Display(Name = "Medical File Id #")]
        public int? MedicalFileId { get; set; }
        [Display(Name = "Pet Id #")]
        public int? PetId { get; set; }
        [Display(Name = "Medical File")]

        public virtual MedicalFile MedicalFile { get; set; }
        [Display(Name = "Pet")]
        public virtual Pet Pet { get; set; }
    }
}
