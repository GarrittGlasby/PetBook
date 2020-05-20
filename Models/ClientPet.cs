using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class ClientPet
    {
        public int IdexNumber { get; set; }
        [Display(Name = "Client Id #")]
        public int? ClientId { get; set; }
        [Display(Name = "Pet Id #")]
        public int? PetId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Pet Pet { get; set; }

        internal object Select(Func<object, object> p, int idexNumber, int? clientId)
        {
            throw new NotImplementedException();
        }
    }
}
