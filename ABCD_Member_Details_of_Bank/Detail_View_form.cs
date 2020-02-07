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

namespace ABCD_Member_Details_of_Bank
{
    public partial class Detail_View_form : Form
    {
        //SqlConnection connection = new SqlConnection("Server= localhost; Database= samupakara_bank;Integrated Security = SSPI;");//sql connection
        //SqlConnection connection = new SqlConnection("Server=(localdb);Database= samupakara_bank;Integrated Security = SSPI;");//sql connection
        
        //SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=samupakara_bank;Integrated Security=True;MultipleActiveResultSets=True");//sql connection
        
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CRO4EQ0\AVISQL;Initial Catalog=samupakara_bank;User ID=sa;Password=avishka.1997");//sql connection
        public Detail_View_form()
        {
            InitializeComponent();
            GrideLoad();
            SearchBoxValue();
            this.ActiveControl = searching_txt;
        }

        private void detaileviewgride_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detaileviewgride.ReadOnly = true;
        }

        private void searching_txt_Enter(object sender, EventArgs e)
        {
            if(searching_txt.Text == "Search")
            {
                searching_txt.Text = "";
                searching_txt.ForeColor = Color.Lime;
            }
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Detaild_add_form daf = new Detaild_add_form();
            daf.Show();
            this.Dispose();
        }

        private void searching_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string checkQuery = "select * from member_register_table where Member_No LIKE '%" + searching_txt.Text + "%' or Name_with_Initials LIKE '%" + searching_txt.Text + "%' or Full_Name LIKE '%" + searching_txt.Text + "%' or NIC LIKE '%" + searching_txt.Text + "%'";
                DataSet dataSet = new DataSet();
                SqlCommand cmdCheck = new SqlCommand(checkQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdCheck);
                adapter.Fill(dataSet);
                int recordCount = dataSet.Tables[0].Rows.Count;

                if (recordCount ==0 && searching_txt.Text != "")
                {
                    detaileviewgride.Rows.Clear();
                    //GrideLoad();
                    member_no_lbl.Text = "";
                    reciept_no_lbl.Text = "";
                    date_of_register_lbl.Text = "";
                    name_with_initials_lbl.Text = "";
                    full_name_lbl.Text = "";
                    nic_lbl.Text = "";
                    residential_address_lbl.Text = "";
                    house_base_number_lbl.Text = "";
                }else if(searching_txt.Text =="")
                {
                    ClearText();
                }else
                {
                    DeatailsReader();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ClearText()
        {
            detaileviewgride.Rows.Clear();
            GrideLoad();
            member_no_lbl.Text = "";
            reciept_no_lbl.Text = "";
            date_of_register_lbl.Text = "";
            name_with_initials_lbl.Text = "";
            full_name_lbl.Text = "";
            nic_lbl.Text = "";
            residential_address_lbl.Text = "";
            house_base_number_lbl.Text = "";
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
                string loadQuery = "select * from member_register_table where Member_No ='" + searching_txt.Text + "' or Name_with_Initials = '" + searching_txt.Text + "' or Full_Name ='" + searching_txt.Text + "' or NIC ='" + searching_txt.Text + "'";
                SqlCommand cmdLoad = new SqlCommand(loadQuery, connection);
                connection.Open();
                SqlDataReader reader = cmdLoad.ExecuteReader();
                while (reader.Read())
                {
                    var date = Convert.ToDateTime(reader[2]).ToString("yyyy-MM-dd");//set date only
                    member_no_lbl.Text = reader[0].ToString();
                    reciept_no_lbl.Text = reader[1].ToString();
                    date_of_register_lbl.Text = date.ToString();
                    name_with_initials_lbl.Text = reader[3].ToString();
                    full_name_lbl.Text = reader[4].ToString();
                    nic_lbl.Text = reader[5].ToString();
                    residential_address_lbl.Text = reader[6].ToString();
                    house_base_number_lbl.Text = reader[7].ToString();
                    
                    detaileviewgride.Rows.Add(reader[0], reader[1], date, reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SearchBoxValue()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            try
            {
                string col = "SELECT * FROM member_register_table";
                SqlCommand cmdCollection = new SqlCommand(col, connection);
                connection.Open();
                SqlDataReader reader = cmdCollection.ExecuteReader();
                
                while (reader.Read())
                {
                    
                    collection.Add(reader.GetString(0)).ToString();
                    collection.Add(reader.GetString(3)).ToString();
                    collection.Add(reader.GetString(4)).ToString();
                    collection.Add(reader.GetString(5)).ToString();
                }
                reader.Close();
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            searching_txt.AutoCompleteCustomSource = collection;
            connection.Close();
        }

        private void Detail_View_form_Load(object sender, EventArgs e)
        {
            //SearchBoxValue();
        }

        private void Detail_View_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Exit..", "ABCD BANK", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                Login_form lg = new Login_form();
                lg.Show();
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

        private void detaileviewgride_Click(object sender, EventArgs e)
        {
            try
            {
                if(detaileviewgride.Rows.Count != 0)
                {
                    member_no_lbl.Text = detaileviewgride.CurrentRow.Cells[0].Value.ToString();
                    reciept_no_lbl.Text = detaileviewgride.CurrentRow.Cells[1].Value.ToString();
                    date_of_register_lbl.Text = detaileviewgride.CurrentRow.Cells[2].Value.ToString();
                    name_with_initials_lbl.Text = detaileviewgride.CurrentRow.Cells[3].Value.ToString();
                    full_name_lbl.Text = detaileviewgride.CurrentRow.Cells[4].Value.ToString();
                    nic_lbl.Text = detaileviewgride.CurrentRow.Cells[5].Value.ToString();
                    residential_address_lbl.Text = detaileviewgride.CurrentRow.Cells[6].Value.ToString();
                    house_base_number_lbl.Text = detaileviewgride.CurrentRow.Cells[7].Value.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Detail_View_form_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                Detaild_add_form daf = new Detaild_add_form();
                daf.Show();
                this.Dispose();
            }
            if (e.Shift && e.KeyCode == Keys.Down)
            {
                detaileviewgride.Focus();
            }
            if (e.Shift && e.KeyCode == Keys.Up)
            {
                searching_txt.Focus();
            }
        }
    }
}
