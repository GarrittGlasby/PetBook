using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class Calendar
    {
        public Calendar()
        {

        }
        
        [Display(Name = "Calendar Id #")]
        public int CalendarId { get; set; }
        [Display(Name = "Date Entry Created")]
        public DateTime? EntryCreated { get; set; }
        [Display(Name = "Entry Title")]
        public string EntryTitle { get; set; }
        [Display(Name = "Date Entry Actioned")]
        public DateTime? EntryActionDate { get; set; }
        [Display(Name = "Enrty Notes")]
        public string EntryNotes { get; set; }

    }
}
