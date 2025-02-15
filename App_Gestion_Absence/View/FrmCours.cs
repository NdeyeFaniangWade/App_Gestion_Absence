using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using App_Gestion_Absence.Model;

namespace App_Gestion_Absence.View
{
    public partial class FrmCours : Form
    {
        public FrmCours()
        {
            InitializeComponent();
        }

        bdAbsenceContext bdAbsenceContext = new bdAbsenceContext();

        private void ResetForm()
        {
            txtDate.Text = DateTime.Now.ToString();
            txtHeureDebut.Text = string.Empty;
            txtHeureFin.Text = string.Empty;
            txtNom.Text = string.Empty;
            cbbClasse.Text = "Selectionner...";
            cbbMatiere.Text = "Selectionner...";
            cbbSalle.Text = "Selectionner...";

            // Chargement des combo box
            cbbMatiere.DataSource = LoadCbbMatiere();
            cbbMatiere.ValueMember = "Value";
            cbbMatiere.DisplayMember = "Text";

            cbbClasse.DataSource = LoadCbbClasse();
            cbbClasse.ValueMember = "Value";
            cbbClasse.DisplayMember = "Text";

            cbbSalle.DataSource = LoadCbbSalle();
            cbbSalle.ValueMember = "Value";
            cbbSalle.DisplayMember = "Text";

            // Chargement du GridView
            dgCours.DataSource = bdAbsenceContext.Cours
                .Select(a => new
                {
                    a.IdCours,
                    a.NomCours,
                    a.DateCours,
                    a.HeureDebut,
                    a.HeureFin,
                    Salle = a.Salle.LibelleSalle,
                    Matiere = a.Matiere.LibelleMatiere,
                    Classe = a.Classe.LibelleClasse
                })
                .ToList();
        }

        private List<SelectListViewModel> LoadCbbMatiere()
        {
            var matieres = bdAbsenceContext.Matieres.ToList();
            List<SelectListViewModel> list = new List<SelectListViewModel>();

            list.Add(new SelectListViewModel { Text = "Selectionner..", Value = "" });

            foreach (var item in matieres)
            {
                list.Add(new SelectListViewModel { Text = item.LibelleMatiere, Value = item.IdMatiere.ToString() });
            }
            return list;
        }

        private List<SelectListViewModel> LoadCbbClasse()
        {
            var classes = bdAbsenceContext.Classe.ToList();
            List<SelectListViewModel> list = new List<SelectListViewModel>();

            list.Add(new SelectListViewModel { Text = "Selectionner..", Value = "" });

            foreach (var item in classes)
            {
                list.Add(new SelectListViewModel { Text = item.LibelleClasse, Value = item.IdClasse.ToString() });
            }
            return list;
        }

        private List<SelectListViewModel> LoadCbbSalle()
        {
            var salles = bdAbsenceContext.Salles.ToList();
            List<SelectListViewModel> list = new List<SelectListViewModel>();

            list.Add(new SelectListViewModel { Text = "Selectionner..", Value = "" });

            foreach (var item in salles)
            {
                list.Add(new SelectListViewModel { Text = item.LibelleSalle, Value = item.IdSalle.ToString() });
            }
            return list;
        }

        private void FrmCours_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Cours newCours = new Cours
            {
                NomCours = txtNom.Text,
                DateCours = DateTime.Parse(txtDate.Text),
                HeureDebut = TimeSpan.Parse(txtHeureDebut.Text),
                HeureFin = TimeSpan.Parse(txtHeureFin.Text),
                IdMatiere = int.Parse(cbbMatiere.SelectedValue.ToString()),
                IdClasse = int.Parse(cbbClasse.SelectedValue.ToString()),
                IdSalle = int.Parse(cbbSalle.SelectedValue.ToString())
            };
            bdAbsenceContext.Cours.Add(newCours);
            bdAbsenceContext.SaveChanges();
            MessageBox.Show("Cours ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();


        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {

            FrmImprimerListeCours f = new FrmImprimerListeCours();
            f.Show();
        }
    }
}

