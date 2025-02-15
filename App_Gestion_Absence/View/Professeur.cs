using App_Gestion_Absence.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Gestion_Absence.View
{
    public partial class FrmProfesseur : Form
    {
        public FrmProfesseur()
        {
            InitializeComponent();
        }

        bdAbsenceContext db = new bdAbsenceContext();

        public void Effacer()
        {

            
                txtNom.Text = string.Empty;
                txtPrenom.Text = string.Empty;
                txtSpecialite.Text = string.Empty;
                dgProfesseur.DataSource = db.Professeur.ToList();
                txtNom.Focus();
            }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Professeur professeur = new Professeur();
            professeur.NomProfesseur=txtNom.Text;
            professeur.PrenomProfesseur = txtPrenom.Text;
            professeur.SpecialiteProfesseur =txtSpecialite.Text;
            db.Professeur.Add(professeur);
            db.SaveChanges();
            Effacer();


            db.SaveChanges();
            Effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProfesseur.CurrentRow.Cells[0].Value.ToString());
            var p = db.Professeur.Find(id);
            p.NomProfesseur = txtNom.Text;
            p.PrenomProfesseur = txtPrenom.Text;
            p.SpecialiteProfesseur = txtSpecialite.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProfesseur.CurrentRow.Cells[0].Value.ToString());
            var p = db.Professeur.Find(id);
            db.Professeur.Remove(p);
            db.SaveChanges();
            Effacer();

        }

        private void FrmProfesseur_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNom.Text = dgProfesseur.CurrentRow.Cells[3].Value.ToString();
            txtPrenom.Text = dgProfesseur.CurrentRow.Cells[1].Value.ToString();
            txtSpecialite.Text = dgProfesseur.CurrentRow.Cells[2].Value.ToString();
        }
    }


        
    }

