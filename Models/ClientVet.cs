using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class ClientVet
    {
        public int IdexNumber { get; set; }
        [Display(Name = "Client Id #")]
        public int? ClientId { get; set; }
        [Display(Name = "Pet Id #")]
        public int? VetId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Veterinarian Vet { get; set; }
    }
}
