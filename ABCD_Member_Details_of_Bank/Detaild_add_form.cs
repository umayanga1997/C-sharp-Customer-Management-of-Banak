using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Details;
using System.Data.SqlClient;

namespace ABCD_Member_Details_of_Bank
{
    public partial class Detaild_add_form : Form
    {
        SqlConnection connection = new SqlConnection("Server= localhost; Database= samupakara_bank;Integrated Security = SSPI;");//sql connection
        abcd abcd = new abcd();// make object for details library has class
        public Detaild_add_form()
        {
            InitializeComponent();
            GrideLoad();//loading details in to the datagrideview
            this.ActiveControl = member_no_txt;
        }
        public void InsertDetails()
        {
            try
            {
                string checkQuery = "select * from member_register_table where Member_No='" + member_no_txt.Text + "'";
                DataSet dataSet = new DataSet();
                SqlCommand cmdCheck = new SqlCommand(checkQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdCheck);
                adapter.Fill(dataSet);
                int recordCount = dataSet.Tables[0].Rows.Count;

                if (recordCount == 1)
                {
                    MessageBox.Show("This Record is alredy exist...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (member_no_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Membership Number...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (reciept_no_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Reciept Number...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Please Enter Register Date...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (name_with_initials_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Name with Initials...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (full_name_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Full Name...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (nic_txt.Text == "")
                {
                    MessageBox.Show("Please Enter NIC...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (residential_address_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Residential Address...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (house_base_number_txt.Text == "")
                {
                    MessageBox.Show("Please Enter House Base Number...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    abcd.InsertData("insert into member_register_table(Member_No,Reciept_No,Date_of_Register,Name_with_Initials,Full_Name,NIC,Residential_Address,House_base_Number)values('" + member_no_txt.Text + "','" + reciept_no_txt.Text + "','" + dateTimePicker1.Value.Date + "','" + name_with_initials_txt.Text + "','" + full_name_txt.Text + "','" + nic_txt.Text + "','" + residential_address_txt.Text + "','" + house_base_number_txt.Text + "')");
                    MessageBox.Show("Record is Inserted...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateDetails()
        {
            try
            {
                string checkQuery = "select * from member_register_table where Member_No='" + member_no_txt.Text + "'";
                DataSet dataSet = new DataSet();
                SqlCommand cmdCheck = new SqlCommand(checkQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdCheck);
                adapter.Fill(dataSet);
                int recordCount = dataSet.Tables[0].Rows.Count;

                if (recordCount == 0)
                {
                    MessageBox.Show("This Record is not exist...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (member_no_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Membership Number...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (reciept_no_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Reciept Number...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Please Enter Register Date...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (name_with_initials_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Name with Initials...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (full_name_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Full Name...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (nic_txt.Text == "")
                {
                    MessageBox.Show("Please Enter NIC...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (residential_address_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Residential Address...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (house_base_number_txt.Text == "")
                {
                    MessageBox.Show("Please Enter House Base Number...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    abcd.UpdateData("update member_register_table set Reciept_No='" + reciept_no_txt.Text + "',Date_of_Register='" + dateTimePicker1.Value.Date + "',Name_with_Initials='" + name_with_initials_txt.Text + "',Full_Name='" + full_name_txt.Text + "',NIC='" + nic_txt.Text + "',Residential_Address='" + residential_address_txt.Text + "',House_base_Number='" + house_base_number_txt.Text + "' where Member_No='" + member_no_txt.Text + "'");
                    MessageBox.Show("Record is Updated...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteDetails()
        {
            try
            {
                string checkQuery = "select * from member_register_table where Member_No='" + member_no_txt.Text + "'";
                DataSet dataSet = new DataSet();
                SqlCommand cmdCheck = new SqlCommand(checkQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdCheck);
                adapter.Fill(dataSet);
                int recordCount = dataSet.Tables[0].Rows.Count;

                if (recordCount == 0)
                {
                    MessageBox.Show("This Record is not exist...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    abcd.DeleteData("delete from member_register_table where Member_No='" + member_no_txt.Text + "'");
                    MessageBox.Show("Record is Deleted...", "ABCD BANK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DeleteDetails();
        }
        public void ClearText()
        {
            try
            {
                detaileviewgride.Rows.Clear();
                GrideLoad();
                member_no_txt.Text = "";
                reciept_no_txt.Text = "";
                dateTimePicker1.Value = DateTime.Now.Date;
                name_with_initials_txt.Text = "";
                full_name_txt.Text = "";
                nic_txt.Text = "";
                residential_address_txt.Text = "";
                house_base_number_txt.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GrideLoad()
        {
            try
            {
                detaileviewgride.Rows.Clear();
                string loadQuery = "select * from member_register_table";
                SqlCommand cmdLoad = new SqlCommand(loadQuery, connection);
                connection.Open();
                SqlDataReader reader = cmdLoad.ExecuteReader();
                while (reader.Read())
                {
                    var date = Convert.ToDateTime(reader[2]).ToString("yyyy-MM-dd");//set date only
                    detaileviewgride.Rows.Add(reader[0], reader[1], date, reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void DeatailsReader()
        {
            try
            {
                detaileviewgride.Rows.Clear();
                string loadQuery = "select * from member_register_table where Member_No = '" + member_no_txt.Text + "'";
                SqlCommand cmdLoad = new SqlCommand(loadQuery, connection);
                connection.Open();
                SqlDataReader reader = cmdLoad.ExecuteReader();
                while (reader.Read())
                {

                    // Cast instead of using ToString
                    DateTime sdate = (DateTime)reader["Date_of_Register"];
                    // Then format it as desired. Example:
                    string formattedDate = sdate.ToString("yyyy-MM-dd");

                    //member_no_txt.Text = reader[0].ToString();
                    reciept_no_txt.Text = reader[1].ToString();
                    dateTimePicker1.Text = formattedDate;
                    name_with_initials_txt.Text = reader[3].ToString();
                    full_name_txt.Text = reader[4].ToString();
                    nic_txt.Text = reader[5].ToString();
                    residential_address_txt.Text = reader[6].ToString();
                    house_base_number_txt.Text = reader[7].ToString();                    
                    detaileviewgride.Rows.Add(reader[0], reader[1], formattedDate, reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void member_no_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(member_no_txt.Focused == true)
                {
                    string checkQuery = "select * from member_register_table where Member_No LIKE '%" + member_no_txt.Text + "%'";
                    DataSet dataSet = new DataSet();
                    SqlCommand cmdCheck = new SqlCommand(checkQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdCheck);
                    adapter.Fill(dataSet);
                    int recordCount = dataSet.Tables[0].Rows.Count;

                    if (recordCount == 0 && member_no_txt.Text != "")
                    {
                        //member_no_txt.Text = "";
                        detaileviewgride.Rows.Clear();
                        reciept_no_txt.Text = "";
                        dateTimePicker1.Value = DateTime.Now.Date;
                        name_with_initials_txt.Text = "";
                        full_name_txt.Text = "";
                        nic_txt.Text = "";
                        residential_address_txt.Text = "";
                        house_base_number_txt.Text = "";
                    }
                    else if (member_no_txt.Text == "")
                    {
                        ClearText();
                    }
                    else
                    {

                        DeatailsReader();
                    }
                }               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void detaileviewgride_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (detaileviewgride.Rows.Count != 0)
                {
                    member_no_txt.Text = detaileviewgride.CurrentRow.Cells[0].Value.ToString();
                    reciept_no_txt.Text = detaileviewgride.CurrentRow.Cells[1].Value.ToString();
                    dateTimePicker1.Text = detaileviewgride.CurrentRow.Cells[2].Value.ToString();
                    name_with_initials_txt.Text = detaileviewgride.CurrentRow.Cells[3].Value.ToString();
                    full_name_txt.Text = detaileviewgride.CurrentRow.Cells[4].Value.ToString();
                    nic_txt.Text = detaileviewgride.CurrentRow.Cells[5].Value.ToString();
                    residential_address_txt.Text = detaileviewgride.CurrentRow.Cells[6].Value.ToString();
                    house_base_number_txt.Text = detaileviewgride.CurrentRow.Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Detaild_add_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Exit..", "ABCD BANK", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                Detail_View_form dvf = new Detail_View_form();
                dvf.Show();
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void detaileviewgride_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detaileviewgride.ReadOnly = true;
        }

        private void member_no_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                reciept_no_txt.Focus();
            }
        }

        private void reciept_no_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }else if(reciept_no_txt.Text == "")
            {
                if(e.KeyCode == Keys.Back)
                {
                    member_no_txt.Focus();
                }
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name_with_initials_txt.Focus();
            }
            else if (e.KeyCode == Keys.Back)
            {
                reciept_no_txt.Focus();
            }
        }

        private void name_with_initials_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                full_name_txt.Focus();
            }
            else if (name_with_initials_txt.Text == "")
            {
                if (e.KeyCode == Keys.Back)
                {
                    dateTimePicker1.Focus();
                }
            }
        }

        private void full_name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nic_txt.Focus();
            }
            else if (full_name_txt.Text == "")
            {
                if (e.KeyCode == Keys.Back)
                {
                    name_with_initials_txt.Focus();
                }
            }
        }

        private void nic_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                residential_address_txt.Focus();
                residential_address_txt.DeselectAll();
            }
            else if (nic_txt.Text == "")
            {
                if (e.KeyCode == Keys.Back)
                {
                    full_name_txt.Focus();
                }
            }
        }
        
        private void residential_address_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                house_base_number_txt.Focus();
            }
            else if (residential_address_txt.Text == "")
            {
                if (e.KeyCode == Keys.Back)
                {
                    nic_txt.Focus();
                }
            }
        }

        private void house_base_number_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (house_base_number_txt.Text == "")
            {
                if (e.KeyCode == Keys.Back)
                {
                    residential_address_txt.Focus();
                    residential_address_txt.SelectAll();
                }
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            InsertDetails();
        }

        private void Detaild_add_form_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                InsertDetails();
            }
            if (e.Control && e.KeyCode == Keys.U)
            {
                UpdateDetails();
            }
            if (e.Control && e.KeyCode == Keys.D )
            {
                DeleteDetails();
            }
            if(e.Shift && e.KeyCode == Keys.Down)
            {
                detaileviewgride.Focus();
            }
            if (e.Shift && e.KeyCode == Keys.Up)
            {
                member_no_txt.Focus();
            }
        }
    }
}
