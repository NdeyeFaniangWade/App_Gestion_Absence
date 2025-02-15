using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Absence.Model
{
    public class Cours
    {
        [Key]
        public int IdCours { get; set; }

        [Required(ErrorMessage = "*")]
        public string NomCours { get; set; }

        [Required(ErrorMessage = "*")]
        public TimeSpan HeureDebut { get; set; }

        [Required(ErrorMessage = "*")]
        public TimeSpan HeureFin { get; set; }

        [Required(ErrorMessage = "*")]
        public DateTime DateCours { get; set; }

        public int? IdClasse { get; set; }
        [ForeignKey("IdClasse")]
        public virtual Classe Classe { get; set; }

        public int? IdMatiere { get; set; }
        [ForeignKey("IdMatiere")]
        public virtual Matiere Matiere { get; set; }

        public int? IdSalle { get; set; }
        [ForeignKey("IdSalle")]
        public virtual Salles Salle { get; set; }

    }
}
