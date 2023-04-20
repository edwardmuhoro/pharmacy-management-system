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
    public partial class MEDICINEFORM : Form
    {
        DGVPrinter printer = new DGVPrinter();
        public MEDICINEFORM()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1F1EMTT\SQLEXPRESS;Initial Catalog=PHARMACYDB;Integrated Security=True");
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

        private void pharmacist_Click(object sender, EventArgs e)
        {
            PHARMACISTFORM pharmacist = new PHARMACISTFORM();
            pharmacist.Show();
            this.Hide();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            SUPPLIERFORM supplier = new SUPPLIERFORM();
            supplier.Show();
            this.Hide();
        }

        int totalstocquantity = 0;
        int currentsoldstock = 0;
        int stockremained;
        int x;

        private void MEDICINEFORM_Load(object sender, EventArgs e)
        {
            getmedicinetable();
            getbillstable();
            getstockperqtytable();
            lblstockmanager.Text = LOGINFORM.stockmanager;

            /* ------stock quantity will be displayed after form load*/

            for (int i = 0; i < drugDGV.Rows.Count; i++)
            {
                totalstocquantity = totalstocquantity + Convert.ToInt32(drugDGV.Rows[i].Cells[3].Value);
            }
            lblstockqty.Text = "" + totalstocquantity;

            /* ------the current sold stock by the exixting cashier/ seller  will be displayed after form load*/

            for (int i = 0; i < billdgv.Rows.Count; i++)
            {
                currentsoldstock += Convert.ToInt32(billdgv.Rows[i].Cells[0].Value);
            }
            lblcurrentsoldstock.Text = "" + currentsoldstock;


            /* ------the current balance of stock after sale by the cashier  will be displayed after form load*/

            stockremained = Convert.ToInt32(lblstockqty.Text) - Convert.ToInt32(lblcurrentsoldstock.Text);
            lblstockcurrentlyremaininginstore.Text = "" + stockremained;


            /*      ===== to raise alert to the stock manager if the stock is less than 20 items of 0 ==*/

            x = Convert.ToInt32(lblstockcurrentlyremaininginstore.Text);
            if (x <= 20)
            {
                lbloutofstocksignal.Visible = true;
            }
        }
        private void getmedicinetable()
        {
            con.Open();
            SqlCommand command = new SqlCommand("SELECT *  FROM MEDICINE_TBL", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            drugDGV.DataSource = table;
            con.Close();
        }
        private void getstockperqtytable()
        {
            con.Open();
            SqlCommand command = new SqlCommand("SELECT *  FROM DRUGQTY_TBL", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            stockperqtyDGV.DataSource = table;
            con.Close();
        }
        private void getbillstable()
        {
            con.Open();
            SqlCommand command = new SqlCommand("SELECT *  FROM BILLS_TBL", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            billdgv.DataSource = table;
            con.Close();
        }
        private void clear()
        {
            txtid.Clear();
            txtname.Clear();
            txtqty.Clear();
            txtprice.Clear();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            getmedicinetable();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtid.Text == "" || txtname.Text == "" || txtqty.Text == "" || txtprice.Text == "")
                {
                    MessageBox.Show("missing information", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertquery = "INSERT INTO MEDICINE_TBL VALUES(" + txtid.Text + ",'" + txtname.Text + "','" + txtprice.Text + "','" + txtqty.Text + "','" + Convert.ToInt32(txtqty.Text) * Convert.ToInt32(txtprice.Text) + "')";
                    SqlCommand command = new SqlCommand(insertquery, con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("medicine added successfuly!!!", "message information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    getmedicinetable();
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
                if (txtid.Text == "" || txtname.Text == "" || txtqty.Text == "" || txtprice.Text == "")
                {
                    MessageBox.Show("missing information", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updatequery = "UPDATE MEDICINE_TBL SET drug_name = '" + txtname.Text + "', price='" + txtprice.Text + "',qty='" + txtqty.Text + "',total_amount='" + Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text) + "'WHERE drug_id=" + txtid.Text + "";
                    SqlCommand command = new SqlCommand(updatequery, con);
                    if (con.State == ConnectionState.Closed) { 
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("medicine updated successfuly!!!", "message information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    getmedicinetable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void drugDGV_Click(object sender, EventArgs e)
        {
            txtid.Text = drugDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = drugDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtprice.Text = drugDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtqty.Text = drugDGV.SelectedRows[0].Cells[3].Value.ToString();
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
                        string deleteQuery = "DELETE FROM MEDICINE_TBL WHERE drug_id=" + txtid.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, con);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        MessageBox.Show("drug deleted successfuly!!", "delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        getmedicinetable();
                        clear();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                printer.PrintDataGridView(drugDGV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
