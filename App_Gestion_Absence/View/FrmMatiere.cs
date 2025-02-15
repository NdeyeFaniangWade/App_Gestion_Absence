using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Gestion_Absence.Model;

namespace App_Gestion_Absence.View
{
    public partial class FrmMatiere : Form
    {
        public FrmMatiere()
        {
            InitializeComponent();
        }

        bdAbsenceContext db=new bdAbsenceContext();

        public void Effacer()
        {
            txtFiliere.Text= string.Empty;
            txtLibelle.Text= string.Empty;
            txtNiveau.Text= string.Empty;
            dgMatiere.DataSource= db.Matieres.ToList();
            txtLibelle.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Matiere matiere = new Matiere();
            matiere.LibelleMatiere=txtLibelle.Text;
            matiere.NiveauMatiere=txtNiveau.Text;
            matiere.FiliereMatiere=txtFiliere.Text;
            db.Matieres.Add(matiere);
            db.SaveChanges();
            Effacer(); 
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMatiere.CurrentRow.Cells[0].Value.ToString());
            var m = db.Matieres.Find(id);
            m.LibelleMatiere = txtLibelle.Text;
            m.NiveauMatiere = txtNiveau.Text;
            m.FiliereMatiere = txtFiliere.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMatiere.CurrentRow.Cells[0].Value.ToString());
            var m = db.Matieres.Find(id);
            db.Matieres.Remove(m);
            db.SaveChanges();
            Effacer();

        }

        private void FrmMatiere_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtFiliere.Text = dgMatiere.CurrentRow.Cells[3].Value.ToString();
            txtLibelle.Text = dgMatiere.CurrentRow.Cells[1].Value.ToString();
            txtNiveau.Text = dgMatiere.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            FrmImprimerlisteMatiere  f = new FrmImprimerlisteMatiere();
            f.Show();

        }
    }
}
