using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Absence.Model
{
    public class ClassReportListeSalle
    {

        [Key]
        public int IdSalle { get; set; }


        
        public string LibelleSalle { get; set; }
        

        public string Batiment { get; set; }
    }
}
