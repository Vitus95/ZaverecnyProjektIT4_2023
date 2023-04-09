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

namespace ZaverecnyProjektIT4_2023_Nemec
{
    public partial class Uzivatel : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Uzivatel()
        {
            InitializeComponent();
        }

        private void Uzivatel_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employees;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            GetAllContractRecord();

        }

        private void GetAllContractRecord()
        {
            cmd = new SqlCommand("Select * FROM Prace", con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataKontrakty.DataSource = dt;


        }
        protected void UpdatePrace()
        {
            string QUERY = "Update Prace " +
            "Set Hours = @Hours " +
            " where IdContract = @IdContract";

            SqlCommand CMD = new SqlCommand(QUERY, con);
            CMD.Parameters.AddWithValue("@IdContract", txtIdContract.Text);
            CMD.Parameters.AddWithValue("@Hours", txtHours.Text);
            CMD.ExecuteNonQuery();
        }

        private void btnNajitK_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * FROM Prace where IdContract =" + txtIdContract.Text, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataKontrakty.DataSource = dt;
        }

        private void btnPridejK_Click(object sender, EventArgs e)
        {
            UpdatePrace();
            GetAllContractRecord();
        }
    }
}
