
namespace ATBM1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_userlist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_role = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_user = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.btn_createuser = new System.Windows.Forms.Button();
            this.btn_updateuser = new System.Windows.Forms.Button();
            this.btn_dropuser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userlist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_userlist
            // 
            this.dgv_userlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_userlist.Location = new System.Drawing.Point(381, 81);
            this.dgv_userlist.Name = "dgv_userlist";
            this.dgv_userlist.RowHeadersWidth = 51;
            this.dgv_userlist.RowTemplate.Height = 24;
            this.dgv_userlist.Size = new System.Drawing.Size(457, 296);
            this.dgv_userlist.TabIndex = 0;
            this.dgv_userlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_userlist_CellClick);
            this.dgv_userlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_userlist_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "USERNAME";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "USER_ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "CREATED";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // btn_user
            // 
            this.btn_user.AutoSize = true;
            this.btn_user.Enabled = false;
            this.btn_user.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_user.Location = new System.Drawing.Point(255, 31);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(110, 27);
            this.btn_user.TabIndex = 1;
            this.btn_user.Text = "Manage User";
            this.btn_user.UseVisualStyleBackColor = true;
            // 
            // btn_role
            // 
            this.btn_role.AutoSize = true;
            this.btn_role.Location = new System.Drawing.Point(450, 31);
            this.btn_role.Name = "btn_role";
            this.btn_role.Size = new System.Drawing.Size(110, 27);
            this.btn_role.TabIndex = 2;
            this.btn_role.Text = "Manage Role";
            this.btn_role.UseVisualStyleBackColor = true;
            this.btn_role.Click += new System.EventHandler(this.btn_role_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtbx_user
            // 
            this.txtbx_user.Location = new System.Drawing.Point(87, 75);
            this.txtbx_user.Name = "txtbx_user";
            this.txtbx_user.Size = new System.Drawing.Size(193, 20);
            this.txtbx_user.TabIndex = 5;
            this.txtbx_user.TextChanged += new System.EventHandler(this.txtbx_user_TextChanged);
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(87, 126);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(193, 20);
            this.txtbx_password.TabIndex = 6;
            // 
            // btn_createuser
            // 
            this.btn_createuser.AutoSize = true;
            this.btn_createuser.Location = new System.Drawing.Point(6, 181);
            this.btn_createuser.Name = "btn_createuser";
            this.btn_createuser.Size = new System.Drawing.Size(75, 27);
            this.btn_createuser.TabIndex = 7;
            this.btn_createuser.Text = "Create";
            this.btn_createuser.UseVisualStyleBackColor = true;
            this.btn_createuser.Click += new System.EventHandler(this.btn_createuser_Click);
            // 
            // btn_updateuser
            // 
            this.btn_updateuser.AutoSize = true;
            this.btn_updateuser.Enabled = false;
            this.btn_updateuser.Location = new System.Drawing.Point(105, 181);
            this.btn_updateuser.Name = "btn_updateuser";
            this.btn_updateuser.Size = new System.Drawing.Size(75, 27);
            this.btn_updateuser.TabIndex = 8;
            this.btn_updateuser.Text = "Update";
            this.btn_updateuser.UseVisualStyleBackColor = true;
            this.btn_updateuser.Click += new System.EventHandler(this.btn_updateuser_Click);
            // 
            // btn_dropuser
            // 
            this.btn_dropuser.AutoSize = true;
            this.btn_dropuser.Enabled = false;
            this.btn_dropuser.Location = new System.Drawing.Point(205, 181);
            this.btn_dropuser.Name = "btn_dropuser";
            this.btn_dropuser.Size = new System.Drawing.Size(75, 27);
            this.btn_dropuser.TabIndex = 9;
            this.btn_dropuser.Text = "Drop";
            this.btn_dropuser.UseVisualStyleBackColor = true;
            this.btn_dropuser.Click += new System.EventHandler(this.btn_dropuser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_dropuser);
            this.groupBox1.Controls.Add(this.btn_updateuser);
            this.groupBox1.Controls.Add(this.btn_createuser);
            this.groupBox1.Controls.Add(this.txtbx_password);
            this.groupBox1.Controls.Add(this.txtbx_user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 276);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // btn_reset
            // 
            this.btn_reset.AutoSize = true;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(105, 232);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 27);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(864, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_role);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.dgv_userlist);
            this.Name = "Form1";
            this.Text = "Manage User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userlist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Button btn_dangnhap;
        //private System.Windows.Forms.BindingSource dataSet1BindingSource;
        //private DataSet1 dataSet1;
        //private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.DataGridView dgv_userlist;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_user;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Button btn_createuser;
        private System.Windows.Forms.Button btn_updateuser;
        private System.Windows.Forms.Button btn_dropuser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

