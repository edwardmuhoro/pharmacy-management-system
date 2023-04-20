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
    public partial class PHARMACISTFORM : Form
    {
        public PHARMACISTFORM()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1F1EMTT\SQLEXPRESS;Initial Catalog=PHARMACYDB;Integrated Security=True");

        private void medicine_Click(object sender, EventArgs e)
        {
            MEDICINEFORM medicine = new MEDICINEFORM();
            medicine.Show();
            this.Hide();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            SUPPLIERFORM suplier = new SUPPLIERFORM();
            suplier.Show();
            this.Hide();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            LOGINFORM login = new LOGINFORM();
            login.Show();
            this.Hide();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            getpharmacisttable();
        }

        private void PHARMACISTFORM_Load(object sender, EventArgs e)
        {
            getpharmacisttable();
        }
        private void getpharmacisttable()
        {
            con.Open();
            SqlCommand command = new SqlCommand("SELECT *  FROM PHARMACIST_TBL", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            pharmacistDGV.DataSource = table;
            con.Close();
        }
        private void clear()
        {
            txtid.Clear();
            txtname.Clear();
            txtpassword.Clear();
            txtphone.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("missing information", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertquery = "INSERT INTO PHARMACIST_TBL VALUES(" + txtid.Text + ",'" + txtname.Text + "','" + txtphone.Text + "','" + txtpassword.Text + "')";
                    SqlCommand command = new SqlCommand(insertquery, con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("pharmacist added successfuly!!!", "message information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    getpharmacisttable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("missing information", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updatequery = "UPDATE PHARMACIST_TBL SET name = '" + txtname.Text + "',phone='" + txtphone.Text + "',password='" + txtpassword.Text + "'WHERE pharmacist_id=" + txtid.Text + "";
                    SqlCommand command = new SqlCommand(updatequery, con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("pharmacist updated successfuly!!!", "message information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    getpharmacisttable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pharmacistDGV_Click(object sender, EventArgs e)
        {
            txtid.Text = pharmacistDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = pharmacistDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtphone.Text = pharmacistDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtpassword.Text = pharmacistDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show("missing information to delete", " Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete This Record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM PHARMACIST_TBL WHERE pharmacist_id=" + txtid.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, con);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        MessageBox.Show("pharmarcist deleted successfuly!!", "delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        getpharmacisttable();
                        clear();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
