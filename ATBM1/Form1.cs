using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace ATBM1
{
    public partial class Form1 : Form
    {
        OracleConnection con = null;
        public Form1()
        {
            this.setConnection();
            InitializeComponent();
            this.updateDataGridView();
        }

        private void setConnection()
        {
            con = new OracleConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            try
            {
                con.Open();
            }
            catch (Exception exp) { }
        }

        private void updateDataGridView()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM ALL_USERS";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dgv_userlist.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dgv_userlist.Rows.Add();
                dgv_userlist.Rows[n].Cells[0].Value = row[0].ToString();
                dgv_userlist.Rows[n].Cells[1].Value = row[1].ToString();
                dgv_userlist.Rows[n].Cells[2].Value = row[2].ToString();
            }    
        }

        private void btn_createuser_Click(object sender, EventArgs e)
        { 
            if (txtbx_user.Text == "")
            {
                MessageBox.Show("Please enter username first!");
                return;
            } 
            
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = " CREATE USER " + txtbx_user.Text.ToString() + " IDENTIFIED BY " + txtbx_password.Text.ToString();
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Create user successed!");
                }    
            }catch(Exception exp) { MessageBox.Show(exp.Message); }
            resetAll();
        }

        private void btn_updateuser_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = " ALTER USER " + txtbx_user.Text.ToString() + " IDENTIFIED BY " + txtbx_password.Text.ToString();
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Alter user successed!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            resetAll();
        }

        private void btn_dropuser_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "DROP USER " + txtbx_user.Text.ToString();
            cmd.CommandType = CommandType.Text;
      
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Drop user successed!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            this.resetAll();
        }

        private void dgv_userlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = this.dgv_userlist.Rows[e.RowIndex];
            txtbx_user.Text = row.Cells[0].Value.ToString();
            btn_createuser.Enabled = false;
            btn_updateuser.Enabled = true;
            btn_dropuser.Enabled = true;
        }

        private void btn_role_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void resetAll()
        {
            txtbx_user.Text = "";
            txtbx_password.Text = "";
            this.updateDataGridView();

            btn_createuser.Enabled = true;
            btn_updateuser.Enabled = false;
            btn_dropuser.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.resetAll();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtbx_user_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_user.Text =="")
            {
                btn_createuser.Enabled = true;
                btn_updateuser.Enabled = false;
                btn_dropuser.Enabled = false;
            }    
        }

        private void dgv_userlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            Form3 f = new Form3();
            f.username = this.dgv_userlist.Rows[e.RowIndex].Cells[0].Value.ToString();
            f.ShowDialog();
        }
    }
}
