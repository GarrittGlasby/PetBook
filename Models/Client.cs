﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;


namespace PetBook.Models
{
    public class Client
    {
        public Client()
        {
            ClientPet = new HashSet<ClientPet>();
            ClientVet = new HashSet<ClientVet>();
        }

        [Display(Name = "Client Id #")]
        public int ClientId { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail Address")]
        public string UserEMail { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string UserStreetAddress { get; set; }

        [Required]
        [Display(Name = "Town or City")]
        public string TownOrCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }


        [Display(Name = "Date Joined PetBook")]
        public DateTime? DateOfProfileCreation { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string ClientPhoneNumber { get; set; }


        public string ClientProfileImagePath { get; set; }

        public virtual ICollection<ClientPet> ClientPet { get; set; }
        public virtual ICollection<ClientVet> ClientVet { get; set; }
    
       
 
        
        
        
     
       
    }
}
