using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ManageBook MB = new ManageBook())
            {
                MB.ShowDialog();
            }
        }
    }
}
