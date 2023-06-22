using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teste__BDLivro
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\0050538\\Documents\\teste.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text;
            String senha = textBox2.Text;

            con.Open();
            String query = "SELECT * FROM Users";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

            }
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
