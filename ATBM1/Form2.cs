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
    public partial class Form2 : Form
    {
        OracleConnection con = null;
        public Form2()
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
            cmd.CommandText = "SELECT * FROM DBA_ROLES";
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
                dgv_rolelist.Rows[n].Cells[1].Value = row[1].ToString();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btn_createrole_Click(object sender, EventArgs e)
        {
            if (txtbx_role.Text == "")
            {
                MessageBox.Show("Please enter rolename first!");
                return;
            }

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = " CREATE ROLE " + txtbx_role.Text.ToString();
            if (txtbx_password.Text.ToString() !="")
                cmd.CommandText+= " IDENTIFIED BY " + txtbx_password.Text.ToString();
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Create role successed!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            resetAll();
        }

        private void btn_updaterole_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = " ALTER ROLE " + txtbx_role.Text.ToString() + " IDENTIFIED BY " + txtbx_role.Text.ToString();
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Alter role successed!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            resetAll();
        }

        private void btn_droprole_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "DROP ROLE " + txtbx_role.Text.ToString();
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    MessageBox.Show("Drop role successed!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            this.resetAll();
        }

        private void resetAll()
        {
            txtbx_role.Text = "";
            txtbx_password.Text = "";
            this.updateDataGridView();

            btn_createrole.Enabled = true;
            btn_updaterole.Enabled = false;
            btn_droprole.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.resetAll();
        }

        private void dgv_rolelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = this.dgv_rolelist.Rows[e.RowIndex];
            txtbx_role.Text = row.Cells[0].Value.ToString();
            btn_createrole.Enabled = false;
            btn_updaterole.Enabled = true;
            btn_droprole.Enabled = true;
        }

        private void txtbx_role_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_role.Text == "")
            {
                btn_createrole.Enabled = true;
                btn_updaterole.Enabled = false;
                btn_droprole.Enabled = false;
            }
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
