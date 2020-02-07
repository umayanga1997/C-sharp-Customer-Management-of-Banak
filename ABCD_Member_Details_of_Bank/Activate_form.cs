using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCD_Member_Details_of_Bank
{
    public partial class Activate_form : Form
    {
        public Activate_form()
        {
            InitializeComponent();
        }
        const int ProductCode = 1;
        private void ok_btn_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(productid_lbl.Text);
            string productKey = productkey_txt.Text;
            //Check valid
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                //Decrypt license key
                if (km.DisassembleKey(productKey, ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "ABCD BANK";
                   
                    //Save license key to file
                    km.SaveSuretyFile(string.Format(@"{0}\active.lic", Application.StartupPath), lic);
                    MessageBox.Show("You have been successfully registered.", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    Login_form lgf = new Login_form();
                    lgf.Show();
                    
                    
                }
            }
            else
                MessageBox.Show("Your product key is invalid.", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Activate_form_Load(object sender, EventArgs e)
        {
            productid_lbl.Text = ComputerInfo.GetComputerId();
        }

        private void Activate_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
