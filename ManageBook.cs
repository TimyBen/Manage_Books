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
    public partial class ManageBook : Form
    {
        public ManageBook()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       /* public class Books
        {
            public string BookID { get; set; }
            public string BookTitle { get; set; }
            public string Autor { get; set; }
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=VIBEZ; Initial Catalog=LAB_2; Integrated Security=True";
            cnn.Open();

            string sql = "Select * FROM tblBooks WHERE BookTitle='" + txtBook_Name.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Book Available.");
            }
            else
            {
                MessageBox.Show("Book Not Found!");
            }
            //MessageBox.Show("Conncetion Open !");
            cnn.Close();

        }

        private void txtBook_Name_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();

            }
        }

        private void ManageBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab_2DataSet.tblBooks' table. You can move, or remove it, as needed.
            this.tblBooksTableAdapter.Fill(this.lab_2DataSet.tblBooks);

        }
    }
}
