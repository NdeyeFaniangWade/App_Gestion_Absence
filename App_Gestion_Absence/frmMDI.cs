using App_Gestion_Absence.View;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Gestion_Absence
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);

        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmConnexion f = new FrmConnexion();
            f.Show();
            this.Hide();
        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ; ; FrmMatiere f = new FrmMatiere();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClasse f = new FrmClasse();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;


        }

        private void coursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCours f = new FrmCours();   
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void salleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmSalle f = new FrmSalle();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;


        }

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfesseur f = new FrmProfesseur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;


        }
    }
}
