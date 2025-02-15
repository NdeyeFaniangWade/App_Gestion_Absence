using App_Gestion_Absence.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace App_Gestion_Absence.View
{
    public partial class FrmClasse : Form
    {
        private bdAbsenceContext db = new bdAbsenceContext();

        public FrmClasse()
        {
            InitializeComponent();
        }

        private void FrmClasse_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        /// <summary>
        /// Charge les données dans la DataGridView et réinitialise les champs
        /// </summary>
        private void ChargerDonnees()
        {
            dgClasse.DataSource = db.Classe
                .Select(c => new { c.IdClasse, c.LibelleClasse, c.NiveauClasse, c.Annee })
                .ToList();

            txtLibelle.Focus();
        }

        /// <summary>
        /// Ajoute une nouvelle classe
        /// </summary>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLibelle.Text) ||
                string.IsNullOrWhiteSpace(txtNiveau.Text) ||
                string.IsNullOrWhiteSpace(txtAnnee.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var classe = new Classe
            {
                LibelleClasse = txtLibelle.Text.Trim(),
                NiveauClasse = txtNiveau.Text.Trim(),
                Annee = txtAnnee.Text.Trim()
            };

            db.Classe.Add(classe);
            db.SaveChanges();

            MessageBox.Show("Classe ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChargerDonnees();
        }

        /// <summary>
        /// Modifie une classe sélectionnée
        /// </summary>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgClasse.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une classe à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgClasse.CurrentRow.Cells[0].Value;
            var classe = db.Classe.Find(id);

            if (classe != null)
            {
                classe.LibelleClasse = txtLibelle.Text.Trim();
                classe.NiveauClasse = txtNiveau.Text.Trim();
                classe.Annee = txtAnnee.Text.Trim();

                db.SaveChanges();
                MessageBox.Show("Classe modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerDonnees();
            }
        }

        /// <summary>
        /// Supprime une classe sélectionnée
        /// </summary>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgClasse.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une classe à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgClasse.CurrentRow.Cells[0].Value;
            var classe = db.Classe.Find(id);

            if (classe != null)
            {
                var result = MessageBox.Show("Voulez-vous vraiment supprimer cette classe ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.Classe.Remove(classe);
                    db.SaveChanges();
                    MessageBox.Show("Classe supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerDonnees();
                }
            }
        }

        /// <summary>
        /// Remplit les champs avec les données de la classe sélectionnée
        /// </summary>
        private void dgClasse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClasse.CurrentRow != null)
            {
                txtLibelle.Text = dgClasse.CurrentRow.Cells["LibelleClasse"].Value?.ToString() ?? "";
                txtNiveau.Text = dgClasse.CurrentRow.Cells["NiveauClasse"].Value?.ToString() ?? "";
                txtAnnee.Text = dgClasse.CurrentRow.Cells["Annee"].Value?.ToString() ?? "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtLibelle.Text = dgClasse.CurrentRow.Cells[3].Value.ToString();
            txtNiveau.Text = dgClasse.CurrentRow.Cells[1].Value.ToString();
            txtAnnee.Text = dgClasse.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {

            FrmImprimerListeClasse f = new FrmImprimerListeClasse();
            f.Show();

        }
    }
}
