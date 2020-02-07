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
    public partial class Login_form : Form
    {
        string getLicenKey = "";

        public Login_form()
        {
            InitializeComponent();
        
        }
        const int ProductCode = 1;

        public void LicenKey()
        {
            
            KeyManager km = new KeyManager(ComputerInfo.GetComputerId());
            LicenseInfo lic = new LicenseInfo();
            //Get license information from license file
            int value = km.LoadSuretyFile(string.Format(@"{0}\active.lic", Application.StartupPath), ref lic);
            string productKey = lic.ProductKey;
            //Check valid
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                //Decrypt license key
                if (km.DisassembleKey(productKey, ref kv))
                {
                    
                    getLicenKey = productKey;
                   
                }
            }
        }
        private void username_txt_Enter(object sender, EventArgs e)
        {
            if (username_txt.Text == "Enter Username")
            {
                username_txt.Text = "";
                username_txt.ForeColor = Color.Lime;
            }
            if (password_txt.Text == "")
            {
                password_txt.Text = "Enter Password";
                password_txt.ForeColor = Color.Gray;
                password_txt.PasswordChar = (char)0;
            }
        }

        private void password_txt_Enter(object sender, EventArgs e)
        {
            if(password_txt.Text == "Enter Password")
            {
                password_txt.Text = "";
                password_txt.ForeColor = Color.Lime;
                password_txt.PasswordChar = '*';
            }
            if (username_txt.Text == "")
            {
                username_txt.Text = "Enter Username";
                username_txt.ForeColor = Color.Gray;
            }
        }
   
        public void login()
        {
            try
            {
                if ((username_txt.Text == "") | (username_txt.Text == "Enter Username"))
                {

                    username_txt.Text = "Enter Username";
                    username_txt.ForeColor = Color.Gray;
                    MessageBox.Show("Please Enter Username...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (username_txt.Text != "admin")
                {

                    MessageBox.Show("Username is Invalied...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if ((password_txt.Text == "") | (password_txt.Text == "Enter Password"))
                {
                    password_txt.Text = "Enter Password";
                    password_txt.ForeColor = Color.Gray;
                    password_txt.PasswordChar = (char)0;
                    MessageBox.Show("Please Enter Password...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }               
                else if (password_txt.Text != "ssd")
                {

                    MessageBox.Show("Password is Invalied...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    Detail_View_form df = new Detail_View_form();
                    df.Show();
                    this.Hide();

                }


            }
            catch (Exception ex)
            {

            }
        }

        private void Login_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Exit..", "ABCD BANK", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(result== DialogResult.Yes)
            {
                Application.ExitThread();

            }
            else if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login();
            }
            else if(password_txt.Text == "")
            {
                if(e.KeyCode == Keys.Back)
                {
                    username_txt.Focus();
                }
            }
        }

        private void username_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_txt.Focus();
            }
           
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            LicenKey();
            if (getLicenKey == "")
            {
                Activate_form acf = new Activate_form();
                acf.Show();
                this.Hide();
            }

        }
    }
}
