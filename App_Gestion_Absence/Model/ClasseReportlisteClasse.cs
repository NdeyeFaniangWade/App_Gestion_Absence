using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Absence.Model
{
    public class ClasseReportlisteClasse
    {
        [Key]
        public int IdClasse { get; set; }


        
        public string LibelleClasse { get; set; }
        

        public string NiveauClasse { get; set; }

        

        public string Annee { get; set; }

    }
}
