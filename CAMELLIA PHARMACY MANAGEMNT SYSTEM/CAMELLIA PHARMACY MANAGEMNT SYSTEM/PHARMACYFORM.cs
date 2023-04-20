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
    public partial class PHARMACYFORM : Form
    {
        public PHARMACYFORM()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1F1EMTT\SQLEXPRESS;Initial Catalog=PHARMACYDB;Integrated Security=True");
        private void logout_Click(object sender, EventArgs e)
        {
            LOGINFORM login = new LOGINFORM();
            login.Show();
            this.Hide();
        }

        private void PHARMACYFORM_Load(object sender, EventArgs e)
        {
            populatedrug();
            lblpharmacist.Text = LOGINFORM.pharmacist;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            populatedrug();
        }

        int stockperqty = 0;
        private void clear()
        {
            //lblamnt.ResetText();
            txtcash.Clear();
            txtchange.Clear();
            PHARMACYFORM salse = new PHARMACYFORM();
            salse.Show();
            this.Hide();


            string insertquery = "INSERT INTO BILLS_TBL VALUES(" + lblqtysold.Text + ",'" + lblamnt.Text+ "')";
            SqlCommand command = new SqlCommand(insertquery, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            command.ExecuteNonQuery();
            con.Close();
        }
        private void populatedrug()
        {

            con.Open();
            string query = "SELECT drug_name,price FROM MEDICINE_TBL";
            SqlDataAdapter adapater = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapater);
            var ds = new DataSet();
            adapater.Fill(ds);
            drugDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void drugDGV_Click(object sender, EventArgs e)
        {
            txtname.Text = drugDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtprice.Text = drugDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("G");
        }

        private void btnclearorderdgv_Click(object sender, EventArgs e)
        {
            clear();
        }

        int N = 0;
        int no_of_item;
        int no_of_sale;
        int grandtotall = 0;
        int quaty = 0, qtyno;

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtname.Text == "" || txtqty.Text == "")
                {
                    MessageBox.Show("missing iformation", "information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    qtyno = Convert.ToInt32(txtqty.Text);
                    int total = Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text);
                    DataGridViewRow addRow = new DataGridViewRow();
                    addRow.CreateCells(orderDGV);
                    addRow.Cells[0].Value = N + 1;
                    addRow.Cells[1].Value = txtname.Text;
                    addRow.Cells[2].Value = txtprice.Text;
                    addRow.Cells[3].Value = Convert.ToInt32(txtqty.Text);
                    addRow.Cells[4].Value = Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text);
                    orderDGV.Rows.Add(addRow);
                    N++;
                    grandtotall = grandtotall + total;
                    lblamnt.Text = "" + grandtotall;
                    quaty = quaty + qtyno;
                    lblqtysold.Text = "" + quaty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         

        }
        int change, cash;
        int amt = 0;

        private void changebtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (cbomode_pay.SelectedIndex == -1)
                {
                    MessageBox.Show("please select mode of payment!!", "missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int tot = Convert.ToInt32(txtprice.Text)
                        * Convert.ToInt32(txtqty.Text);
                cash = Convert.ToInt32(txtcash.Text);
                amt = Convert.ToInt32(lblamnt.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(orderDGV);
                addRow.Cells[0].Value = N + 1;
                addRow.Cells[1].Value = txtname.Text;
                addRow.Cells[2].Value = txtprice.Text;
                addRow.Cells[3].Value = txtqty.Text;
                addRow.Cells[4].Value = Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text);
                no_of_item = N++;
                N++;

                if (cash < amt)
                {
                    MessageBox.Show("insufficient funds to purchase the drug", "information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cbomode_pay.SelectedIndex == 0)
                    {
                        change = cash - amt;
                        txtchange.Text = string.Format("{0:0.00}", change);
                    }
                    else if (cbomode_pay.SelectedIndex == 1)
                    {
                        change = cash - amt;
                        txtchange.Text = string.Format("{0:0.00}", change);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void medicine_Click(object sender, EventArgs e)
        {
            MEDICINEFORM medicine = new MEDICINEFORM();
            medicine.Show();
            this.Hide();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            try
            {
                /* -------------/reciept----------------*/
                Graphics graphics = e.Graphics;
                Font font = new Font("courier new", 20, FontStyle.Bold);
                Font font2 = new Font("Italic", 15, FontStyle.Bold);
                float fontheight = font.GetHeight();
                int startx = 190;
                int starty = 40;
                int offset = 20;
                float leftmargin = e.MarginBounds.Left;
                float topmargin = e.MarginBounds.Top;
                float bottommargin = e.MarginBounds.Bottom;
                float rightmargin = e.MarginBounds.Right;
                offset = offset + (int)fontheight;
                graphics.DrawString("CAMELLIA PHARMACY", new Font("courier new", 30, FontStyle.Bold), new SolidBrush(Color.Black), startx, starty);
                offset = offset + 30;
                graphics.DrawString("------start of legal receipt------", font2, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 40;
                string top = "Date:" + lbldate.Text.PadRight(10);
                graphics.DrawString(top, font, new SolidBrush(Color.Black), startx, starty + offset);
                //offset = offset + (int)fontheight;
                offset = offset + 30;// this creates a space below the DATE
                graphics.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
                //offset = offset + 10;// this creates space below the dotted line

                /* -------printing datagridview contents*/
                Bitmap objbitmap = new Bitmap(this.orderDGV.Width, this.orderDGV.Height);
                orderDGV.DrawToBitmap(objbitmap, new Rectangle(0, 0, this.orderDGV.Width, this.orderDGV.Height));
                e.Graphics.DrawImage(objbitmap, 180, 250);
                if (orderDGV.ScrollBars == ScrollBars.Vertical)
                {
                    orderDGV.ScrollBars = ScrollBars.None;
                    orderDGV.Height = 200;
                }
                offset = offset + 310;



                offset = offset + (int)fontheight + 5;
                graphics.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 25;


                graphics.DrawString("GRAND TOTAL       Ksh:     " + lblamnt.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 40;
                if (cbomode_pay.SelectedItem.ToString() == "CASH")
                {
                    graphics.DrawString("PAID CASH         Ksh:    " + txtcash.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
                    offset = offset + 40;
                    graphics.DrawString("MPESA PAY         Ksh:    " + "0.00", font, new SolidBrush(Color.Black), startx, starty + offset);
                    offset = offset + 40;
                }
                else
                {
                    graphics.DrawString("MPESA PAY         Ksh:    " + txtcash.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
                    offset = offset + 40;
                    graphics.DrawString("PAID CASH         Ksh:    " + "0.00", font, new SolidBrush(Color.Black), startx, starty + offset);
                    offset = offset + 40;
                }
                graphics.DrawString("CHANGE            Ksh:    " + txtchange.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 40;

                graphics.DrawString("TOTAL ITEMS BOUGHT:     #" + no_of_item, font, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 40;


                graphics.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 40;


                graphics.DrawString("YOU WERE SERVED BY: " + lblpharmacist.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 40;
                graphics.DrawString("QUICK RECOVERY!!!!!", font, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 50;

                graphics.DrawString("------End of legal receipt------", font2, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 40;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
