using App_Gestion_Absence.Model;
using App_Gestion_Absence.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Gestion_Absence.Report;


namespace App_Gestion_Absence.View
{
    public partial class FrmImprimerlisteSalle1 : Form
    {
        public FrmImprimerlisteSalle1()
        {
            InitializeComponent();
        }
        bdAbsenceContext dbAbsenceContext = new bdAbsenceContext();

        private void FrmImprimerlisteSalle1_Load(object sender, EventArgs e)
        {
            rptlisteSalle objRpt = new rptlisteSalle();
            objRpt.SetDataSource(GetTableListeSalle());
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }

        public DataTable GetTableListeSalle()
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdSalle", typeof(int));
            table.Columns.Add("LibelleSalle", typeof(string));
            table.Columns.Add("Batiment", typeof(string));
            

            var list = dbAbsenceContext.Salles.ToList();
            foreach (var item in list)
            {
                table.Rows.Add(item.IdSalle, item.LibelleSalle, item.Batiment );
            }

            return table;
        }
    }
}
