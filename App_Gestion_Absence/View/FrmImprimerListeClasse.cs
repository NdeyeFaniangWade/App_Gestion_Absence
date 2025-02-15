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
using App_Gestion_Absence.Report;

namespace App_Gestion_Absence.View
{
    public partial class FrmImprimerListeClasse : Form
    {
        public FrmImprimerListeClasse()
        {
            InitializeComponent();
        }

        private void FrmImprimerListeClasse_Load(object sender, EventArgs e)
        {

            rptListeClasse objRpt = new rptListeClasse();
            objRpt.SetDataSource(GetTableListeClasse());
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();

        }
        bdAbsenceContext dbAbsenceContext = new bdAbsenceContext();

        public DataTable GetTableListeClasse()
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdClasse", typeof(int));
            table.Columns.Add("LibelleClasse", typeof(string));
            table.Columns.Add("NiveauClasse", typeof(string));
            table.Columns.Add("Annee", typeof(string));

            var list = dbAbsenceContext.Classe.ToList();
            foreach (var item in list)
            {
                table.Rows.Add(item.IdClasse, item.LibelleClasse, item.NiveauClasse, item.Annee);
            }

            return table;
        }

    }
}
