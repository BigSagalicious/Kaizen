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

namespace KaizenMain
{
    public partial class frmCustomers : Form
    {

        SqlDataAdapter daCustomer;
        DataSet dsKaizen = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String connStr, sqlCustomer;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void Display_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabCustomer.SelectedIndex;
            tabCustomer.TabPages[tabCustomer.SelectedIndex].Focus();
            tabCustomer.TabPages[tabCustomer.SelectedIndex].CausesValidation = true;

            if (dvgCustomers.SelectedRows.Count == 0 && tabCustomer.SelectedIndex == 2)
                tabCustomer.TabPages[tabCustomer.SelectedIndex].CausesValidation = true;
            else
            {
                switch (tabCustomer.SelectedIndex)
                {
                    case 0:
                        {
                            dsKaizen.Tables["Customer"].Clear();
                            daCustomer.Fill(dsKaizen, "Customer");

                            break;
                        }
                    case 1:
                        {
                            int noRows = dsKaizen.Tables["Customer"].Rows.Count;

                            if (noRows == 0)
                                lblAddCustNo.Text = "10000";
                            else
                            {
                                getNumber(noRows);
                            }

                            errP.Clear();
                            clearAddForm();
                            break;

                        }
                    case 2:
                        {
                            if (custNoSelected == 0)
                            {
                                tabCustomer.SelectedIndex = 0;
                                break;
                            }
                            else
                            {
                                lblEdCustNo.Text = custNoSelected.ToString();

                                drCustomer = dsKaizen.Tables["Customer"].Rows.Find(lblEdCustNo.Text);
                               
                                txtEdForename.Text = drCustomer["Forename"].ToString();
                                txtEdSurname.Text = drCustomer["Surname"].ToString();
                                txtEdAddress.Text = drCustomer["Street"].ToString();
                                txtEdTown.Text = drCustomer["Town"].ToString();
                                txtEdCounty.Text = drCustomer["County"].ToString();
                                txtEdPostcode.Text = drCustomer["Postcode"].ToString();
                                txtEdTelNo.Text = drCustomer["TelNo"].ToString();
                                txtEdEmail.Text = drCustomer["Email"].ToString();
                                break;

                            }



                        }



                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        //Add Address
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (txtAddAddress.Text.Length >= 2 && txtAddAddress.Text.Length <= 15)
                txtAddAddress.BackColor = Color.White;
            else
                txtAddAddress.BackColor = Color.LightCoral;
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabDisplay_Click(object sender, EventArgs e)
        {

        }

        private void listViewEquip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabSearch_Click(object sender, EventArgs e)
        {

        }

        private void pBIcon_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void tabAdd_Click(object sender, EventArgs e)
        {

        }
        //Add Telephone Number
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtAddTel.Text.Length >= 2 && txtAddTel.Text.Length <= 15)
                txtAddTel.BackColor = Color.White;
            else
                txtAddTel.BackColor = Color.LightCoral;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Add Email
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtAddEmail.Text.Length >= 2 && txtAddEmail.Text.Length <= 40)
                txtAddEmail.BackColor = Color.White;
            else
                txtAddEmail.BackColor = Color.LightCoral;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //AddPostcode
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtAddPostcode.Text.Length >= 2 && txtAddPostcode.Text.Length <= 15)
                txtAddPostcode.BackColor = Color.White;
            else
                txtAddPostcode.BackColor = Color.LightCoral;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Add County
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txtAddCounty.Text.Length >= 2 && txtAddCounty.Text.Length <= 15)
                txtAddCounty.BackColor = Color.White;
            else
                txtAddCounty.BackColor = Color.LightCoral;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Add Town/City
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (txtAddTown.Text.Length >= 2 && txtAddTown.Text.Length <= 15)
                txtAddTown.BackColor = Color.White;
            else
                txtAddTown.BackColor = Color.LightCoral;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Add Surname
        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (txtAddSurname.Text.Length >= 2 && txtAddSurname.Text.Length <= 15)
                txtAddSurname.BackColor = Color.White;
            else
                txtAddSurname.BackColor = Color.LightCoral;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
        //Add Forename
        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (txtAddForename.Text.Length >= 2 && txtAddForename.Text.Length <= 15)
                txtAddForename.BackColor = Color.White;
            else
                txtAddForename.BackColor = Color.LightCoral;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabEdit_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void tabDelete_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void dvgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void getNumber(int noRows)
        {
            drCustomer = dsKaizen.Tables["Customer"].Rows[noRows - 1];
            lblAddCustNo.Text = (int.Parse(drCustomer["CustomerNo"].ToString()) + 1).ToString();
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                custSelected = false;
                custNoSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {

                custSelected = true;
                custNoSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            }
        
       
        }

        void clearAddForm()
        {
            
            txtAddForename.Clear();
            txtAddSurname.Clear();
            txtAddAddress.Clear();
            txtAddTown.Clear();
            txtAddCounty.Clear();
            txtAddPostcode.Clear();
            txtAddTel.Clear();
            txtAddEmail.Clear();

        }
    }
}
