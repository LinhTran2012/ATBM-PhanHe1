
namespace ATBM1
{
    partial class Form3
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
            this.dgv_sysprivilegelist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_objectprivilegelist = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_grant1 = new System.Windows.Forms.Button();
            this.btn_revoke1 = new System.Windows.Forms.Button();
            this.btn_grant2 = new System.Windows.Forms.Button();
            this.btn_revoke2 = new System.Windows.Forms.Button();
            this.btn_resetall = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbx_grantee1 = new System.Windows.Forms.TextBox();
            this.txtbx_privilegetype1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbx_grantee2 = new System.Windows.Forms.TextBox();
            this.txtbx_object2 = new System.Windows.Forms.TextBox();
            this.txtbx_privilegetype2 = new System.Windows.Forms.TextBox();
            this.dgv_rolelist = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_grant3 = new System.Windows.Forms.Button();
            this.btn_revoke3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbx_grantee3 = new System.Windows.Forms.TextBox();
            this.txtbx_rolename3 = new System.Windows.Forms.TextBox();
            this.chexbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sysprivilegelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_objectprivilegelist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rolelist)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_sysprivilegelist
            // 
            this.dgv_sysprivilegelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sysprivilegelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_sysprivilegelist.Location = new System.Drawing.Point(235, 17);
            this.dgv_sysprivilegelist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_sysprivilegelist.Name = "dgv_sysprivilegelist";
            this.dgv_sysprivilegelist.RowHeadersWidth = 51;
            this.dgv_sysprivilegelist.RowTemplate.Height = 24;
            this.dgv_sysprivilegelist.Size = new System.Drawing.Size(337, 98);
            this.dgv_sysprivilegelist.TabIndex = 0;
            this.dgv_sysprivilegelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sysprivilegelist_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "PRIVILEGE";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // dgv_objectprivilegelist
            // 
            this.dgv_objectprivilegelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_objectprivilegelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column4});
            this.dgv_objectprivilegelist.Location = new System.Drawing.Point(235, 17);
            this.dgv_objectprivilegelist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_objectprivilegelist.Name = "dgv_objectprivilegelist";
            this.dgv_objectprivilegelist.RowHeadersWidth = 51;
            this.dgv_objectprivilegelist.RowTemplate.Height = 24;
            this.dgv_objectprivilegelist.Size = new System.Drawing.Size(337, 145);
            this.dgv_objectprivilegelist.TabIndex = 1;
            this.dgv_objectprivilegelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_objectprivilegelist_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRIVILEGE";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TABLE NAME";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "WITH GRANT OPTION";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Privilege type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grantee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Privilege type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grantee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Object";
            // 
            // btn_grant1
            // 
            this.btn_grant1.AutoSize = true;
            this.btn_grant1.Location = new System.Drawing.Point(30, 80);
            this.btn_grant1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_grant1.Name = "btn_grant1";
            this.btn_grant1.Size = new System.Drawing.Size(56, 23);
            this.btn_grant1.TabIndex = 7;
            this.btn_grant1.Text = "Grant";
            this.btn_grant1.UseVisualStyleBackColor = true;
            this.btn_grant1.Click += new System.EventHandler(this.btn_grant1_Click);
            // 
            // btn_revoke1
            // 
            this.btn_revoke1.AutoSize = true;
            this.btn_revoke1.Enabled = false;
            this.btn_revoke1.Location = new System.Drawing.Point(118, 80);
            this.btn_revoke1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_revoke1.Name = "btn_revoke1";
            this.btn_revoke1.Size = new System.Drawing.Size(56, 23);
            this.btn_revoke1.TabIndex = 8;
            this.btn_revoke1.Text = "Revoke";
            this.btn_revoke1.UseVisualStyleBackColor = true;
            this.btn_revoke1.Click += new System.EventHandler(this.btn_revoke1_Click);
            // 
            // btn_grant2
            // 
            this.btn_grant2.AutoSize = true;
            this.btn_grant2.Location = new System.Drawing.Point(30, 139);
            this.btn_grant2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_grant2.Name = "btn_grant2";
            this.btn_grant2.Size = new System.Drawing.Size(56, 23);
            this.btn_grant2.TabIndex = 9;
            this.btn_grant2.Text = "Grant";
            this.btn_grant2.UseVisualStyleBackColor = true;
            this.btn_grant2.Click += new System.EventHandler(this.btn_grant2_Click);
            // 
            // btn_revoke2
            // 
            this.btn_revoke2.AutoSize = true;
            this.btn_revoke2.Enabled = false;
            this.btn_revoke2.Location = new System.Drawing.Point(118, 139);
            this.btn_revoke2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_revoke2.Name = "btn_revoke2";
            this.btn_revoke2.Size = new System.Drawing.Size(56, 23);
            this.btn_revoke2.TabIndex = 10;
            this.btn_revoke2.Text = "Revoke";
            this.btn_revoke2.UseVisualStyleBackColor = true;
            this.btn_revoke2.Click += new System.EventHandler(this.btn_revoke2_Click);
            // 
            // btn_resetall
            // 
            this.btn_resetall.AutoSize = true;
            this.btn_resetall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_resetall.Location = new System.Drawing.Point(92, 430);
            this.btn_resetall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_resetall.Name = "btn_resetall";
            this.btn_resetall.Size = new System.Drawing.Size(59, 23);
            this.btn_resetall.TabIndex = 12;
            this.btn_resetall.Text = "Reset All";
            this.btn_resetall.UseVisualStyleBackColor = true;
            this.btn_resetall.Click += new System.EventHandler(this.btn_resetall_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtbx_grantee1);
            this.groupBox1.Controls.Add(this.txtbx_privilegetype1);
            this.groupBox1.Controls.Add(this.dgv_sysprivilegelist);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_revoke1);
            this.groupBox1.Controls.Add(this.btn_grant1);
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(582, 124);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System privilege";
            // 
            // txtbx_grantee1
            // 
            this.txtbx_grantee1.Enabled = false;
            this.txtbx_grantee1.Location = new System.Drawing.Point(91, 53);
            this.txtbx_grantee1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_grantee1.Name = "txtbx_grantee1";
            this.txtbx_grantee1.Size = new System.Drawing.Size(120, 20);
            this.txtbx_grantee1.TabIndex = 28;
            // 
            // txtbx_privilegetype1
            // 
            this.txtbx_privilegetype1.Location = new System.Drawing.Point(91, 28);
            this.txtbx_privilegetype1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_privilegetype1.Name = "txtbx_privilegetype1";
            this.txtbx_privilegetype1.Size = new System.Drawing.Size(120, 20);
            this.txtbx_privilegetype1.TabIndex = 27;
            this.txtbx_privilegetype1.TextChanged += new System.EventHandler(this.txtbx_privilegetype1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.chexbox);
            this.groupBox3.Controls.Add(this.txtbx_grantee2);
            this.groupBox3.Controls.Add(this.txtbx_object2);
            this.groupBox3.Controls.Add(this.txtbx_privilegetype2);
            this.groupBox3.Controls.Add(this.dgv_objectprivilegelist);
            this.groupBox3.Controls.Add(this.btn_revoke2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_grant2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(20, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(582, 179);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Object privilege";
            // 
            // txtbx_grantee2
            // 
            this.txtbx_grantee2.Enabled = false;
            this.txtbx_grantee2.Location = new System.Drawing.Point(91, 82);
            this.txtbx_grantee2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_grantee2.Name = "txtbx_grantee2";
            this.txtbx_grantee2.Size = new System.Drawing.Size(120, 20);
            this.txtbx_grantee2.TabIndex = 31;
            // 
            // txtbx_object2
            // 
            this.txtbx_object2.Location = new System.Drawing.Point(91, 52);
            this.txtbx_object2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_object2.Name = "txtbx_object2";
            this.txtbx_object2.Size = new System.Drawing.Size(120, 20);
            this.txtbx_object2.TabIndex = 30;
            // 
            // txtbx_privilegetype2
            // 
            this.txtbx_privilegetype2.Location = new System.Drawing.Point(91, 24);
            this.txtbx_privilegetype2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_privilegetype2.Name = "txtbx_privilegetype2";
            this.txtbx_privilegetype2.Size = new System.Drawing.Size(120, 20);
            this.txtbx_privilegetype2.TabIndex = 29;
            this.txtbx_privilegetype2.TextChanged += new System.EventHandler(this.txtbx_privilegetype2_TextChanged);
            // 
            // dgv_rolelist
            // 
            this.dgv_rolelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rolelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5});
            this.dgv_rolelist.Location = new System.Drawing.Point(235, 17);
            this.dgv_rolelist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_rolelist.Name = "dgv_rolelist";
            this.dgv_rolelist.RowHeadersWidth = 51;
            this.dgv_rolelist.RowTemplate.Height = 24;
            this.dgv_rolelist.Size = new System.Drawing.Size(337, 98);
            this.dgv_rolelist.TabIndex = 15;
            this.dgv_rolelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rolelist_CellClick);
            this.dgv_rolelist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rolelist_CellDoubleClick);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "GRANTED ROLE";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Role name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Grantee";
            // 
            // btn_grant3
            // 
            this.btn_grant3.AutoSize = true;
            this.btn_grant3.Location = new System.Drawing.Point(30, 82);
            this.btn_grant3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_grant3.Name = "btn_grant3";
            this.btn_grant3.Size = new System.Drawing.Size(56, 23);
            this.btn_grant3.TabIndex = 11;
            this.btn_grant3.Text = "Grant";
            this.btn_grant3.UseVisualStyleBackColor = true;
            this.btn_grant3.Click += new System.EventHandler(this.btn_grant3_Click);
            // 
            // btn_revoke3
            // 
            this.btn_revoke3.AutoSize = true;
            this.btn_revoke3.Enabled = false;
            this.btn_revoke3.Location = new System.Drawing.Point(118, 82);
            this.btn_revoke3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_revoke3.Name = "btn_revoke3";
            this.btn_revoke3.Size = new System.Drawing.Size(56, 23);
            this.btn_revoke3.TabIndex = 11;
            this.btn_revoke3.Text = "Revoke";
            this.btn_revoke3.UseVisualStyleBackColor = true;
            this.btn_revoke3.Click += new System.EventHandler(this.btn_revoke3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.txtbx_grantee3);
            this.groupBox2.Controls.Add(this.txtbx_rolename3);
            this.groupBox2.Controls.Add(this.btn_grant3);
            this.groupBox2.Controls.Add(this.btn_revoke3);
            this.groupBox2.Controls.Add(this.dgv_rolelist);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(20, 290);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(582, 129);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Role";
            // 
            // txtbx_grantee3
            // 
            this.txtbx_grantee3.Enabled = false;
            this.txtbx_grantee3.Location = new System.Drawing.Point(91, 49);
            this.txtbx_grantee3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_grantee3.Name = "txtbx_grantee3";
            this.txtbx_grantee3.Size = new System.Drawing.Size(120, 20);
            this.txtbx_grantee3.TabIndex = 28;
            // 
            // txtbx_rolename3
            // 
            this.txtbx_rolename3.Location = new System.Drawing.Point(91, 24);
            this.txtbx_rolename3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_rolename3.Name = "txtbx_rolename3";
            this.txtbx_rolename3.Size = new System.Drawing.Size(120, 20);
            this.txtbx_rolename3.TabIndex = 27;
            this.txtbx_rolename3.TextChanged += new System.EventHandler(this.txtbx_rolename3_TextChanged);
            // 
            // chexbox
            // 
            this.chexbox.AutoSize = true;
            this.chexbox.Location = new System.Drawing.Point(91, 107);
            this.chexbox.Name = "chexbox";
            this.chexbox.Size = new System.Drawing.Size(107, 17);
            this.chexbox.TabIndex = 32;
            this.chexbox.Text = "With grant option";
            this.chexbox.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.btn_resetall);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "User privilege";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sysprivilegelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_objectprivilegelist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rolelist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sysprivilegelist;
        private System.Windows.Forms.DataGridView dgv_objectprivilegelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_grant1;
        private System.Windows.Forms.Button btn_revoke1;
        private System.Windows.Forms.Button btn_grant2;
        private System.Windows.Forms.Button btn_revoke2;
        private System.Windows.Forms.Button btn_resetall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_rolelist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_grant3;
        private System.Windows.Forms.Button btn_revoke3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbx_grantee1;
        private System.Windows.Forms.TextBox txtbx_privilegetype1;
        private System.Windows.Forms.TextBox txtbx_grantee2;
        private System.Windows.Forms.TextBox txtbx_object2;
        private System.Windows.Forms.TextBox txtbx_privilegetype2;
        private System.Windows.Forms.TextBox txtbx_grantee3;
        private System.Windows.Forms.TextBox txtbx_rolename3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox chexbox;
    }
}