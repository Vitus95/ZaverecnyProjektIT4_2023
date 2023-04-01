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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
       
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employees;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open ();
            GetAllEmployeeRecord();
        }

        private void GetAllEmployeeRecord()
        {
            cmd = new SqlCommand ("Select * FROM Zamestnanci",con);
            da = new SqlDataAdapter (cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataZamestnanci.DataSource = dt;

                
        }
        private void btnPridatZ_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "") 
            {
            SaveInfo(); 
            }
            else
            {
                MessageBox.Show("ID nemá být prázdné.");
                txtID.Focus();
            }
            GetAllEmployeeRecord ();
        }

        protected void SaveInfo()
        {
            string QUERY = "INSERT INTO Zamestnanci " +
            "(Id, Jmeno, Prijmeni, Narozeni, Email, Tel) " +
            "VALUES (@Id, @Jmeno, @Prijmeni, @Narozeni, @Email, @Tel)";

            SqlCommand CMD = new SqlCommand(QUERY,con);
            CMD.Parameters.AddWithValue("@Id", txtID.Text);
            CMD.Parameters.AddWithValue("@Jmeno", txtJmeno.Text);
            CMD.Parameters.AddWithValue("@Prijmeni", txtPrijmeni.Text);
            CMD.Parameters.AddWithValue("@Narozeni", txtNarozeni.Value);
            CMD.Parameters.AddWithValue("@Email", txtEmail.Text);
            CMD.Parameters.AddWithValue("@Tel", txtTel.Text);
            CMD.ExecuteNonQuery();
        }
        protected void UpdateInfo()
        {
            string QUERY = "Update Zamestnanci " +
            "Set Jmeno = @Jmeno, Prijmeni = @Prijmeni, Narozeni = @Narozeni, Email = @Email, Tel = @Tel " +
            "where Id = @Id";

            SqlCommand CMD = new SqlCommand(QUERY, con);
            CMD.Parameters.AddWithValue("@Id", txtID.Text);
            CMD.Parameters.AddWithValue("@Jmeno", txtJmeno.Text);
            CMD.Parameters.AddWithValue("@Prijmeni", txtPrijmeni.Text);
            CMD.Parameters.AddWithValue("@Narozeni", txtNarozeni.Value);
            CMD.Parameters.AddWithValue("@Email", txtEmail.Text);
            CMD.Parameters.AddWithValue("@Tel", txtTel.Text);
            CMD.ExecuteNonQuery();
        }
        protected void DeleteInfo()
        {
            string QUERY = "Delete from Zamestnanci " +
            "where Id = @Id";

            SqlCommand CMD = new SqlCommand(QUERY, con);
            CMD.Parameters.AddWithValue("@Id", txtID.Text);
            CMD.ExecuteNonQuery();
        }

        private void btnNajdiZ_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * FROM Zamestnanci where ID =" + txtID.Text, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataZamestnanci.DataSource = dt;

            btnEditujZ.Visible = true;
            btnVymazZ.Visible = true;

        }

        private void btnEditujZ_Click(object sender, EventArgs e)
        {
            UpdateInfo();
            GetAllEmployeeRecord();
        }

        private void btnVymazZ_Click(object sender, EventArgs e)
        {
            DeleteInfo();
            GetAllEmployeeRecord();
        }
        private void GetAllUserRecord()
        {
            cmd = new SqlCommand("Select * FROM Zamestnanci", con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataZamestnanci.DataSource = dt;


        }
    }
}
