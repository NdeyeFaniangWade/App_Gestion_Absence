using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_Gestion_Absence.Model
{
    public class Matiere
    {
        [Key]
        public int IdMatiere { get; set; }


        [Required(ErrorMessage ="*"),MaxLength(60, ErrorMessage ="La Taille maximale est de 60")]
        public string LibelleMatiere { get; set; }
        [Required(ErrorMessage = "*"), MaxLength(40, ErrorMessage = "La Taille maximale est de 40")]

        public string NiveauMatiere { get; set; }
        [Required(ErrorMessage = "*"), MaxLength(40, ErrorMessage = "La Taille maximale est de 40")]

        public string FiliereMatiere { get; set; }
        

    }
}
