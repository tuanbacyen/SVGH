using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVGH
{
    public class mySys
    {
        public static void ExitApp()
        {
            database_helper.DisConnection();
            Application.Exit();
        }
    }
}
