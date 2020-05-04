using System;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public class ErrorViewModel
    {
        [Display(Name = "Requested Id #")]
        public string RequestId { get; set; }
        [Display(Name = "Id #")]

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
