using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Absence.Model
{
    public class ClassReportListeMatiere
    {

        [Key]
        public int IdMatiere { get; set; }


       
        public string LibelleMatiere { get; set; }
        

        public string NiveauMatiere { get; set; }
        

        public string FiliereMatiere { get; set; }
    }
}
