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
    public partial class FrmConnexion : Form
    {
        

        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            frmMDI f = new frmMDI();
            f.Show();
            this.Hide();
            
      
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
