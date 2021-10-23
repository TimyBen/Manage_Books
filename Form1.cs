using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txt_UserID;
            txt_UserID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=VIBEZ; Initial Catalog=LAB_2; Integrated Security=True";
            cnn.Open();

            string user_id = txt_UserID.Text;
            string password = txt_Password.Text;
            string sql = "Select UserID, Password FROM tblUsers WHERE UserID='" + txt_UserID.Text + "' AND Password='" + txt_Password.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful !");
                using (frmMain frmM = new frmMain())
                {
                    frmM.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid Login!, please Check your Username and Password.");
            }
            //MessageBox.Show("Conncetion Open !");
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_UserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_Password.Focus();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }
    }
}
