using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models
{
    public partial class Pet
    {
        public Pet()
        {
            ClientPet = new HashSet<ClientPet>();
            MedicalFile = new HashSet<MedicalFile>();
            PetMed = new HashSet<PetMed>();
        }
        [Display(Name = "Pet Id #")]
        public int PetId { get; set; }

        [Required]
        [Display(Name = "Pet Name")]
        public string PetName { get; set; }

        [Required]
        [Display(Name = "Pet Species")]
        public string PetSpecies { get; set; }

        [Required]
        [Display(Name = "Pet Breed")]
        public string PetBreed { get; set; }

        [Required]
        [Display(Name = "Pet Sex")]
        public string PetSex { get; set; }

        [Required]
        [Display(Name = "Pet Age")]
        public int? Age { get; set; }

        public string PetImage { get; set; }
        public string PetProfileImagePath { get; set; }

        public virtual ICollection<ClientPet> ClientPet { get; set; }
        public virtual ICollection<MedicalFile> MedicalFile { get; set; }
        public virtual ICollection<PetMed> PetMed { get; set; }
    }
}
