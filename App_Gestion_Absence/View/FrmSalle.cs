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
    public partial class FrmSalle : Form
    {
        public FrmSalle()
        {
            InitializeComponent();
        }
        bdAbsenceContext db = new bdAbsenceContext();

        public void Effacer()
        {
            txtLibelle.Text = string.Empty;
            txtBatiment.Text = string.Empty;
            dgSalles.DataSource= db.Salles.ToList();
            txtLibelle.Focus();
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Salles salles = new Salles();
            salles.LibelleSalle=txtLibelle.Text;
            salles.Batiment=txtBatiment.Text;
            db.Salles.Add(salles);
            db.SaveChanges();
            Effacer();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSalles.CurrentRow.Cells[0].Value.ToString());
            var s = db.Salles.Find(id);
            s.LibelleSalle = txtLibelle.Text;
            s.Batiment = txtBatiment.Text;
            db.SaveChanges();
            Effacer();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSalles.CurrentRow.Cells[0].Value.ToString());
            var s = db.Salles.Find(id);
           db.Salles.Remove(s);
            db.SaveChanges();
            Effacer();
        }

        private void FrmSalle_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtBatiment.Text = dgSalles.CurrentRow.Cells[2].Value.ToString();
            txtLibelle.Text = dgSalles.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            FrmImprimerlisteSalle1 f = new FrmImprimerlisteSalle1();
            f.Show();
        }
    }
}
