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
using System.Reflection;

using DGVPrinterHelper;

namespace CAMELLIA_PHARMACY_MANAGEMNT_SYSTEM
{
    public partial class SUPPLIERFORM : Form
    {
        DGVPrinter printer = new DGVPrinter();
        public SUPPLIERFORM()
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

        private void pharmacist_Click(object sender, EventArgs e)
        {
            PHARMACISTFORM pharmacist = new PHARMACISTFORM();
            pharmacist.Show();
            this.Hide();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            getsuppliertable();
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            LOGINFORM login = new LOGINFORM();
            login.Show();
            this.Hide();

        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SUPPLIERFORM_Load(object sender, EventArgs e)
        {
            getsuppliertable();
            lblstockmanager.Text = LOGINFORM.stockmanager;
        }
        private void getsuppliertable()
        {

            con.Open();
            SqlCommand command = new SqlCommand("SELECT *  FROM SUPPLIER_TBL", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            supplierDGV.DataSource = table;
            con.Close();
        }
        private void clear()
        {
            txtsupplierid.Clear();
            txtsuppliername.Clear();
            txtsupplierphone.Clear();
            txtsupplierlocation.Clear();
            txtdrugprice.Clear();
            txtdrugname.Clear();
            txtdrugqty.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsupplierid.Text == "" || txtsuppliername.Text == "" || txtsupplierphone.Text == "" || txtsupplierlocation.Text == "" || txtdrugprice.Text == "" || txtdrugqty.Text == "" || txtdrugname.Text == "" )
                {
                    MessageBox.Show("missing information", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertquery = "INSERT INTO SUPPLIER_TBL VALUES(" + txtsupplierid.Text + ",'" + txtsuppliername.Text + "','" + txtsupplierphone.Text + "','" + datepicker.Value + "','" + txtsupplierlocation.Text + "','" + txtdrugname.Text + "', '" + txtdrugqty.Text + "', '" + txtdrugprice.Text + "','" + Convert.ToInt32(txtdrugqty.Text) * Convert.ToInt32(txtdrugprice.Text) + "')";
                    SqlCommand command = new SqlCommand(insertquery, con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("supplier added successfuly!!!", "message information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    getsuppliertable();
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
                if (txtsupplierid.Text == "" || txtsuppliername.Text == "" || txtsupplierphone.Text == "" || txtsupplierlocation.Text == "" || txtdrugprice.Text == "" || txtdrugqty.Text == "" || txtdrugname.Text == "")
                {
                    MessageBox.Show("missing information", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updatequery = "UPDATE SUPPLIER_TBL SET supplier_name = '" + txtsuppliername.Text + "', supplier_phone='" + txtsupplierphone.Text + "',date='" + datepicker.Value + "',location='" + txtsupplierlocation.Text + "',drug_name='" + txtdrugname.Text + "',drug_qty='" + txtdrugqty.Text + "',drugprice='" + txtdrugprice.Text + "',TotAmount='" + Convert.ToInt32(txtdrugqty.Text) * Convert.ToInt32(txtdrugprice.Text) + "'WHERE supplier_id=" + txtsupplierid.Text + "";
                    SqlCommand command = new SqlCommand(updatequery, con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("supplier updated successfuly!!!", "message information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    getsuppliertable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void supplierDGV_Click(object sender, EventArgs e)
        {
            txtsupplierid.Text = supplierDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtsuppliername.Text = supplierDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtsupplierphone.Text = supplierDGV.SelectedRows[0].Cells[2].Value.ToString();
            datepicker.Text = supplierDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtsupplierlocation.Text = supplierDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtdrugname.Text = supplierDGV.SelectedRows[0].Cells[5].Value.ToString();
            txtdrugqty.Text = supplierDGV.SelectedRows[0].Cells[6].Value.ToString();
            txtdrugprice.Text = supplierDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsupplierid.Text == "")
                {
                    MessageBox.Show("missing information to delete", " Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete This Record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM SUPPLIER_TBL WHERE supplier_id=" + txtsupplierid.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, con);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        MessageBox.Show("Supplier deleted successfuly!!", "delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        getsuppliertable();
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int q = -1;
        int salescount;
        int countrows;
        int sum = 0;


        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string sqlquery = "SELECT * FROM SUPPLIER_TBL WHERE drug_name LIKE '%" + txtsearch.Text + "%'";
            con.Open();
            SqlCommand command = new SqlCommand(sqlquery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            supplierDGV.DataSource = table;
            con.Close();
        }

        private void btnprintinvoice_Click(object sender, EventArgs e)
        {
            try
            {
                printer.Title = "CAMELLIA PHARMACY";
                printer.SubTitle = "DATE            : " + DateTime.Today.ToString("G");
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Powered by Kenya pharmaceutical products";
                printer.FooterSpacing = 15;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(supplierDGV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
