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
    public partial class Form3 : Form
    {
        public string username;
        OracleConnection con = null;
        public Form3()
        {
            this.setConnection();
            InitializeComponent();
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

        private void updateDataGridView1()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT PRIVILEGE FROM DBA_SYS_PRIVS WHERE GRANTEE ='" + this.username + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dgv_sysprivilegelist.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dgv_sysprivilegelist.Rows.Add();
                dgv_sysprivilegelist.Rows[n].Cells[0].Value = row[0].ToString();
            }
           
        }
        private void updateDataGridView2()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT PRIVILEGE,TABLE_NAME,GRANTABLE FROM DBA_TAB_PRIVS WHERE GRANTEE ='" + this.username + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dgv_objectprivilegelist.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dgv_objectprivilegelist.Rows.Add();
                dgv_objectprivilegelist.Rows[n].Cells[0].Value = row[0].ToString();
                dgv_objectprivilegelist.Rows[n].Cells[1].Value = row[1].ToString();
                dgv_objectprivilegelist.Rows[n].Cells[2].Value = row[2].ToString();
            }
        }
        private void updateDataGridView3()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE ='" + this.username + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dgv_rolelist.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dgv_rolelist.Rows.Add();
                dgv_rolelist.Rows[n].Cells[0].Value = row[0].ToString();
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtbx_grantee1.Text = this.username;
            txtbx_grantee2.Text = this.username;
            txtbx_grantee3.Text = this.username;
            this.updateDataGridView1();
            this.updateDataGridView2();
            this.updateDataGridView3();
        }

        private void dgv_sysprivilegelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = this.dgv_sysprivilegelist.Rows[e.RowIndex];
            txtbx_privilegetype1.Text = row.Cells[0].Value.ToString();
            btn_grant1.Enabled = false;
            btn_revoke1.Enabled = true;
        }

        private void dgv_objectprivilegelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = this.dgv_objectprivilegelist.Rows[e.RowIndex];
            txtbx_privilegetype2.Text = row.Cells[0].Value.ToString();
            txtbx_object2.Text = row.Cells[1].Value.ToString();
            btn_grant2.Enabled = false;
            btn_revoke2.Enabled = true;
        }

        private void dgv_rolelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = this.dgv_rolelist.Rows[e.RowIndex];
            txtbx_rolename3.Text = row.Cells[0].Value.ToString();
            btn_grant3.Enabled = false;
            btn_revoke3.Enabled = true;
        }

        private void txtbx_privilegetype1_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_privilegetype1.Text == "")
            {
                btn_grant1.Enabled = true;
                btn_revoke1.Enabled = false;
            }
        }

        private void txtbx_privilegetype2_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_privilegetype2.Text == "")
            {
                btn_grant2.Enabled = true;
                btn_revoke2.Enabled = false;
            }
        }

        private void txtbx_rolename3_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_rolename3.Text == "")
            {
                btn_grant3.Enabled = true;
                btn_revoke3.Enabled = false;
            }
        }

        private void resetAll()
        {
            txtbx_privilegetype1.Text = "";
            txtbx_privilegetype2.Text = "";
            txtbx_object2.Text = "";
            txtbx_rolename3.Text = "";
            this.updateDataGridView1();
            this.updateDataGridView2();
            this.updateDataGridView3();

            btn_grant1.Enabled = true;
            btn_revoke1.Enabled = false;
            btn_grant2.Enabled = true;
            btn_revoke2.Enabled = false;
            btn_grant3.Enabled = true;
            btn_revoke3.Enabled = false;
        }

        private void btn_resetall_Click(object sender, EventArgs e)
        {
            this.resetAll();
        }

        private void btn_grant1_Click(object sender, EventArgs e)
        {
            if (txtbx_privilegetype1.Text == "")
            {
                MessageBox.Show("Please enter privilige type first!");
                return;
            }

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = " GRANT " + txtbx_privilegetype1.Text.ToString() + " TO " + this.username;
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Grant succeeded!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            resetAll();
        }

        private void btn_revoke1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "REVOKE " + txtbx_privilegetype1.Text.ToString() + " FROM " + this.username;
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Revoke succeeded!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            this.resetAll();
        }
        private void btn_grant2_Click(object sender, EventArgs e)
        {
            if (txtbx_privilegetype2.Text == "" || txtbx_object2.Text == "")
            {
                MessageBox.Show("Please enter privilige type and object first!");
                return;
            }

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = " GRANT " + txtbx_privilegetype2.Text.ToString() + " ON " + txtbx_object2.Text.ToString() + " TO " + this.username;
            if (chexbox.Checked == true)
                cmd.CommandText += " WITH GRANT OPTION";
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Grant succeeded!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            resetAll();
        }

        private void btn_revoke2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "REVOKE " + txtbx_privilegetype2.Text.ToString() +" ON " + 
                txtbx_object2.Text.ToString() +" FROM " + this.username;
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Revoke succeeded!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            this.resetAll();
        }

        private void btn_grant3_Click(object sender, EventArgs e)
        {
            if (txtbx_rolename3.Text == "")
            {
                MessageBox.Show("Please enter rolename first!");
                return;
            }

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = " GRANT " + txtbx_rolename3.Text.ToString() + " TO " + this.username;
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Grant succeeded!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            resetAll();
        }
        private void btn_revoke3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "REVOKE " + txtbx_rolename3.Text.ToString() + " FROM " + this.username;
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Revoke succeeded!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            this.resetAll();
        }

        private void dgv_rolelist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            Form4 f = new Form4();
            f.rolename = this.dgv_rolelist.Rows[e.RowIndex].Cells[0].Value.ToString();
            f.ShowDialog();
        }
    }
}
