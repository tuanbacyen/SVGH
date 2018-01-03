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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.PrimaryScreen;
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
        }

        private void thoátKhỏiTrươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thựcĐơnChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTkMainMenu tkMainMenu1 = new frmTkMainMenu();
            tkMainMenu1.ShowDialog();
        }
    }
}
