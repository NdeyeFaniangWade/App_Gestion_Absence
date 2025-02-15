using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Absence.Model
{
    public class Classe
    {
        [Key]
        public int IdClasse { get; set; }


        [Required(ErrorMessage = "*"), MaxLength(60, ErrorMessage = "La Taille maximale est de 60")]
        public string LibelleClasse { get; set; }
        [Required(ErrorMessage = "*"), MaxLength(40, ErrorMessage = "La Taille maximale est de 40")]

        public string NiveauClasse { get; set; }

        [Required(ErrorMessage = "*"), MaxLength(40, ErrorMessage = "La Taille maximale est de 40")]

        public string Annee { get; set; }



    }
}
