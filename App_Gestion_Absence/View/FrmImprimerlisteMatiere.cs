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
using static Mysqlx.Notice.Warning.Types;
using App_Gestion_Absence.Report;


namespace App_Gestion_Absence.View
{
    public partial class FrmImprimerlisteMatiere : Form
    {
        public FrmImprimerlisteMatiere()
        {
            InitializeComponent();
        }

        private void FrmImprimerlisteMatiere_Load(object sender, EventArgs e)
        {
            rptListeMatiere objRpt = new rptListeMatiere();
            objRpt.SetDataSource(GetTableListeMatiere());
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();

        }
        bdAbsenceContext dbAbsenceContext = new bdAbsenceContext();


        public DataTable GetTableListeMatiere()
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdMatiere", typeof(int));
            table.Columns.Add("LibelleMatiere", typeof(string));
            table.Columns.Add("NiveauMatiere", typeof(string));
            table.Columns.Add("FiliereMatiere", typeof(string));

            var list = dbAbsenceContext.Matieres.ToList(); 
            foreach (var item in list) 
            {
                table.Rows.Add(item.IdMatiere, item.LibelleMatiere, item.NiveauMatiere, item.FiliereMatiere);
            }

            return table;
        }
    }
}
