
namespace ATBM1
{
    partial class Form2
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
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_role = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_droprole = new System.Windows.Forms.Button();
            this.btn_updaterole = new System.Windows.Forms.Button();
            this.btn_createrole = new System.Windows.Forms.Button();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.txtbx_role = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_rolelist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rolelist)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_user
            // 
            this.btn_user.AutoSize = true;
            this.btn_user.Location = new System.Drawing.Point(255, 31);
            this.btn_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(110, 27);
            this.btn_user.TabIndex = 2;
            this.btn_user.Text = "Manage User";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_role
            // 
            this.btn_role.AutoSize = true;
            this.btn_role.Enabled = false;
            this.btn_role.Location = new System.Drawing.Point(450, 31);
            this.btn_role.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_role.Name = "btn_role";
            this.btn_role.Size = new System.Drawing.Size(110, 27);
            this.btn_role.TabIndex = 3;
            this.btn_role.Text = "Manage Role";
            this.btn_role.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_droprole);
            this.groupBox1.Controls.Add(this.btn_updaterole);
            this.groupBox1.Controls.Add(this.btn_createrole);
            this.groupBox1.Controls.Add(this.txtbx_password);
            this.groupBox1.Controls.Add(this.txtbx_role);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(296, 267);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role Information";
            // 
            // btn_reset
            // 
            this.btn_reset.AutoSize = true;
            this.btn_reset.Location = new System.Drawing.Point(108, 219);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 27);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_droprole
            // 
            this.btn_droprole.AutoSize = true;
            this.btn_droprole.Enabled = false;
            this.btn_droprole.Location = new System.Drawing.Point(209, 176);
            this.btn_droprole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_droprole.Name = "btn_droprole";
            this.btn_droprole.Size = new System.Drawing.Size(75, 27);
            this.btn_droprole.TabIndex = 9;
            this.btn_droprole.Text = "Drop";
            this.btn_droprole.UseVisualStyleBackColor = true;
            this.btn_droprole.Click += new System.EventHandler(this.btn_droprole_Click);
            // 
            // btn_updaterole
            // 
            this.btn_updaterole.AutoSize = true;
            this.btn_updaterole.Enabled = false;
            this.btn_updaterole.Location = new System.Drawing.Point(108, 176);
            this.btn_updaterole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_updaterole.Name = "btn_updaterole";
            this.btn_updaterole.Size = new System.Drawing.Size(75, 27);
            this.btn_updaterole.TabIndex = 8;
            this.btn_updaterole.Text = "Update";
            this.btn_updaterole.UseVisualStyleBackColor = true;
            this.btn_updaterole.Click += new System.EventHandler(this.btn_updaterole_Click);
            // 
            // btn_createrole
            // 
            this.btn_createrole.AutoSize = true;
            this.btn_createrole.Location = new System.Drawing.Point(16, 176);
            this.btn_createrole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_createrole.Name = "btn_createrole";
            this.btn_createrole.Size = new System.Drawing.Size(75, 27);
            this.btn_createrole.TabIndex = 7;
            this.btn_createrole.Text = "Create";
            this.btn_createrole.UseVisualStyleBackColor = true;
            this.btn_createrole.Click += new System.EventHandler(this.btn_createrole_Click);
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(92, 102);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(146, 20);
            this.txtbx_password.TabIndex = 6;
            // 
            // txtbx_role
            // 
            this.txtbx_role.Location = new System.Drawing.Point(92, 60);
            this.txtbx_role.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_role.Name = "txtbx_role";
            this.txtbx_role.Size = new System.Drawing.Size(146, 20);
            this.txtbx_role.TabIndex = 5;
            this.txtbx_role.TextChanged += new System.EventHandler(this.txtbx_role_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Role";
            // 
            // dgv_rolelist
            // 
            this.dgv_rolelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rolelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_rolelist.Location = new System.Drawing.Point(381, 81);
            this.dgv_rolelist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_rolelist.Name = "dgv_rolelist";
            this.dgv_rolelist.RowHeadersWidth = 51;
            this.dgv_rolelist.RowTemplate.Height = 24;
            this.dgv_rolelist.Size = new System.Drawing.Size(457, 296);
            this.dgv_rolelist.TabIndex = 11;
            this.dgv_rolelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rolelist_CellClick);
            this.dgv_rolelist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rolelist_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ROLE NAME";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 225;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "PASSWORD REQUIRED";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(864, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_rolelist);
            this.Controls.Add(this.btn_role);
            this.Controls.Add(this.btn_user);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Manage Role";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rolelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_role;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_droprole;
        private System.Windows.Forms.Button btn_updaterole;
        private System.Windows.Forms.Button btn_createrole;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.TextBox txtbx_role;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_rolelist;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}