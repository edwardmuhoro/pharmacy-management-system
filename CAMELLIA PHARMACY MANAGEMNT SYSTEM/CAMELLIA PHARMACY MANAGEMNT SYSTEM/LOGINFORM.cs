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

namespace CAMELLIA_PHARMACY_MANAGEMNT_SYSTEM
{
    public partial class LOGINFORM : Form
    {
        public LOGINFORM()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1F1EMTT\SQLEXPRESS;Initial Catalog=PHARMACYDB;Integrated Security=True");
        public static string pharmacist = "";
        public static string stockmanager = "";
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnlogin1_Click(object sender, EventArgs e)
        {

            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("please enter username and password", "missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbousertypes.SelectedIndex > -1)
            {
                if (cbousertypes.SelectedItem.ToString() == "Owner")
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM USERS_TBL WHERE username = '" + txtusername.Text + "' AND" +
                    " password = '" + txtpassword.Text + "'", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("you are login as an the Owner", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        PHARMACISTFORM pharmacist = new PHARMACISTFORM();
                        pharmacist.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("If You Are The Owner,Please enter the Correct username and password", "missing informatio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();

                }
               
                else if (cbousertypes.SelectedItem.ToString() == "Pharmacist")
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM PHARMACIST_TBL WHERE name = '" + txtusername.Text + "' AND" +
                    " password = '" + txtpassword.Text + "'", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("you are login as a Pharmacist", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        pharmacist = txtusername.Text;
                        PHARMACYFORM pharmacy = new PHARMACYFORM();
                        pharmacy.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username OR Password", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();


                }
                else if (cbousertypes.SelectedItem.ToString() == "Stock Manager")
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM USERS_TBL WHERE username = '" + txtusername.Text + "' AND" +
                    " password = '" + txtpassword.Text + "'", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("you are login as a Stock Manager", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        stockmanager = txtusername.Text;
                        MEDICINEFORM medicine = new MEDICINEFORM();
                        medicine.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User name OR Password", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();


                }
            }
            else
            {
                MessageBox.Show("please select role", "wrong information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void seepasschk_Click(object sender, EventArgs e)
        {
            if (seepasschk.Checked == true)
            {
                txtpassword.PasswordChar = '*';

            }
            else
            {
                txtpassword.PasswordChar = '\0';               
            }
        }
    }
}
