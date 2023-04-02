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
using System.Data.Sql;

namespace ZaverecnyProjektIT4_2023_Nemec
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employees;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void Signup_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPrihlasit_Click(object sender, EventArgs e)
        {
            String username, user_password, role;

            username = txtUsername.Text;
            user_password = txtPassword.Text;
            

            try 
            {
                String querry = "SELECT * FROM Users WHERE Username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtTable = new DataTable();
                sda.Fill(dtTable);


                if(dtTable.Rows.Count > 0)
                {
                    if (user.Role == "admin") { 
                        username = txtUsername.Text;
                        user_password = txtPassword.Text;

                        Form1 adminpanel = new Form1();
                        adminpanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        username = txtUsername.Text;
                        user_password = txtPassword.Text;

                        Uzivatel uzzivatel = new Uzivatel();
                        uzzivatel.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Neplatné jmémo nebo heslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Chyba");
            }
            finally
            {
                conn.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnOdejit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Chcete odejít?", "Odejít", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            
            }
        }
    }
}
