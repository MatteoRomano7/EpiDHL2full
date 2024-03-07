using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpiDHL.Models
{
    public class Cliente
    {
        [Key]
        public int Cliente_ID { get; set; }

        //Azienda
        [Display(Name = "Azienda")]
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public bool Azienda { get; set; }


        //Codice Fiscale
        [Display(Name = "Codice Fiscale")]
        [StringLength(16, MinimumLength =16, ErrorMessage ="Il codice fiscale deve avere 16 caratteri.")]
        public string Cod_Fisc { get; set; }


        //Partita IVA
        [Display(Name = "Partita IVA")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "La partita IVA deve avere 11 caratteri.")]
        public string PI { get; set; }

        //Email 
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(255, MinimumLength =3, ErrorMessage = "Inserisci almeno 3 caratteri")]
        public string Email { get; set; }

        //Cellulare 
        [Display(Name = "Cellulare")]        
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Inserisci almeno 7 caratteri")]
        public string Tel { get; set; }

        //Nome
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Inserisci massimo 50 caratteri ")]
        public string Nome { get; set; }


        //Cognome
        [Display(Name = "Cognome")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Inserisci massimo 50 caratteri ")]
        public string Cognome { get; set; }
    }
}