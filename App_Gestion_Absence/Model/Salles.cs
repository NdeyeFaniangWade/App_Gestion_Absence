using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Absence.Model
{
    public class Salles
    {
        [Key]
        public int IdSalle { get; set; }


        [Required(ErrorMessage = "*"), MaxLength(60, ErrorMessage = "La Taille maximale est de 60")]
        public string LibelleSalle { get; set; }
        [Required(ErrorMessage = "*"), MaxLength(60, ErrorMessage = "La Taille maximale est de 60")]

        public string Batiment { get; set; }

    }

}
