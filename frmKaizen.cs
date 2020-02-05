using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaizenMain
{
    public partial class frmKaizen : Form
    {
        int MenuWidth;
        bool MenuVisable;
        public frmKaizen()
        {
            InitializeComponent();
            MenuWidth = pnlMenu.Width;
            MenuVisable = true;

        }

        private void frmKaizen_Load(object sender, EventArgs e)
        {
            
        }

        private void pBEquip_Click(object sender, EventArgs e)
        {
            resetIndicators();
            pnlIndEquipment.BackColor = Color.FromArgb(26, 103, 147);
            frmEquip frm = new frmEquip();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlForms.Controls.Add(frm);
            frm.Show();
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Menu Slider

        private void pBMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MenuVisable is false)
            {

                pnlMenu.Width = pnlMenu.Width + 8;
               //              pnlForms.Width = pnlForms.Width - 8;
                if (pnlMenu.Width > 195)
                {
                    timer1.Stop();
                    MenuVisable = true;
                    pBIcon.Visible = true;
                    this.Refresh();
                }
            }

            else {
                pnlMenu.Width = pnlMenu.Width - 8;
              //  pnlForms.Width = pnlForms.Width + 8;
                if (pnlMenu.Width <= 78)
                {
                    timer1.Stop();
                    pBIcon.Visible = false;
                    MenuVisable = false;
                }
            }
        }

        //Menu Click events

        private void pBService_Click(object sender, EventArgs e)
        {
            resetIndicators();
            pnlIndService.BackColor = Color.FromArgb(26, 103, 147);
            frmService frm = new frmService();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlForms.Controls.Add(frm);
            frm.Show();
        }

        private void pBRentals_Click(object sender, EventArgs e)
        {
            resetIndicators();
            pnlIndRentals.BackColor = Color.FromArgb(26, 103, 147);
            frmRentals frm = new frmRentals();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlForms.Controls.Add(frm);
            frm.Show();
        }

        private void pBCustomer_Click(object sender, EventArgs e)
        {
            resetIndicators();
            pnlIndCustomers.BackColor = Color.FromArgb(26, 103, 147);
            frmCustomers frm = new frmCustomers();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlForms.Controls.Add(frm);
            frm.Show();
        }

        private void pBInvoice_Click(object sender, EventArgs e)
        {
            resetIndicators();
            pnlIndInvoicing.BackColor = Color.FromArgb(26, 103, 147);
            frmInv frm = new frmInv();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlForms.Controls.Add(frm);
            frm.Show();
        }

        private void pBQuotes_Click(object sender, EventArgs e)
        {
            resetIndicators();
            pnlIndQuotes.BackColor = Color.FromArgb(26, 103, 147);
            frmQuotes frm = new frmQuotes();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlForms.Controls.Add(frm);
            frm.Show();
        }

        private void pBReports_Click(object sender, EventArgs e)
        {
            resetIndicators();
            pnlIndReports.BackColor = Color.FromArgb(26, 103, 147);
            frmReports frm = new frmReports();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlForms.Controls.Add(frm);
            frm.Show();
        }

        private void pBStock_Click(object sender, EventArgs e)
        {
            resetIndicators();
            pnlIndStock.BackColor = Color.FromArgb(26, 103, 147);
            frmStock frm = new frmStock();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlForms.Controls.Add(frm);
            frm.Show();
        }

        private void pBSuppliers_Click(object sender, EventArgs e)
        {
            resetIndicators();
            pnlIndSuppliers.BackColor = Color.FromArgb(26, 103, 147);
            frmSuppliers frm = new frmSuppliers();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlForms.Controls.Add(frm);
            frm.Show();
        }
        private void resetIndicators()
        {
            pnlIndEquipment.BackColor = Color.FromArgb(88, 193, 238);
            pnlIndService.BackColor = Color.FromArgb(88, 193, 238);
            pnlIndRentals.BackColor = Color.FromArgb(88, 193, 238);
            pnlIndCustomers.BackColor = Color.FromArgb(88, 193, 238);
            pnlIndInvoicing.BackColor = Color.FromArgb(88, 193, 238);
            pnlIndQuotes.BackColor = Color.FromArgb(88, 193, 238);
            pnlIndReports.BackColor = Color.FromArgb(88, 193, 238);
            pnlIndStock.BackColor = Color.FromArgb(88, 193, 238);
            pnlIndSuppliers.BackColor = Color.FromArgb(88, 193, 238);

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlIndReports_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}