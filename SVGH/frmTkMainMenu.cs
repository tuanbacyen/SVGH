using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVGH
{
    public partial class frmTkMainMenu : Form
    {
        public frmTkMainMenu()
        {
            InitializeComponent();
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
