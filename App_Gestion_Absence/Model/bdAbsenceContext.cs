using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Absence.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class bdAbsenceContext : DbContext
    {

        public bdAbsenceContext() : base("bdAbsenceContext") 
        {
        }
        public DbSet<Matiere> Matieres{ get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Salles> Salles { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Professeur> Professeur { get; set; }

    }
}
