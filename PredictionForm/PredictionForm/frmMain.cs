using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredictionForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGotoTeam_Click(object sender, EventArgs e)
        {
            Form frm = new frmTeam();
            frm.Show();
        }

        private void btnGotoExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
