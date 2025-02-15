using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Absence.Model
{
    public class ClassReportProfesseur
    {
        [Key]
        public int IdProfesseur { get; set; }


        [Required(ErrorMessage = "*"), MaxLength(60, ErrorMessage = "La Taille maximale est de 60")]
        public string NomProfesseur { get; set; }


        [Required(ErrorMessage = "*"), MaxLength(60, ErrorMessage = "La Taille maximale est de 60")]
        public string PrenomProfesseur { get; set; }
        [Required(ErrorMessage = "*"), MaxLength(50, ErrorMessage = "La Taille maximale est de 50")]

        public string SpecialiteProfesseur { get; set; }
    }
}
