using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Absence.Model
{
    public class Utlisateurs
    {
        public int IdU { get; set; }


        [Required(ErrorMessage = "*"), MaxLength(60, ErrorMessage = "La Taille maximale est de 60")]
        public string NomPrenom { get; set; }


        [Required(ErrorMessage = "*"), MaxLength(60, ErrorMessage = "La Taille maximale est de 60")]
        public string Maricule { get; set; }
        [Required(ErrorMessage = "*"), MaxLength(50, ErrorMessage = "La Taille maximale est de 50")]

        public string Identifiant { get; set; }
        public string MotDePasse { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
    }
}
