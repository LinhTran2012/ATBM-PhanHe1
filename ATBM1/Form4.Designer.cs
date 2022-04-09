
namespace ATBM1
{
    partial class Form4
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
            this.btn_resetall = new System.Windows.Forms.Button();
            this.btn_revoke2 = new System.Windows.Forms.Button();
            this.btn_grant2 = new System.Windows.Forms.Button();
            this.btn_revoke1 = new System.Windows.Forms.Button();
            this.btn_grant1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_objectprivilegelist = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_sysprivilegelist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbx_privilegetype1 = new System.Windows.Forms.TextBox();
            this.txtbx_grantee1 = new System.Windows.Forms.TextBox();
            this.txtbx_privilegetype2 = new System.Windows.Forms.TextBox();
            this.txtbx_object2 = new System.Windows.Forms.TextBox();
            this.txtbx_grantee2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_objectprivilegelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sysprivilegelist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_resetall
            // 
            this.btn_resetall.AutoSize = true;
            this.btn_resetall.Location = new System.Drawing.Point(68, 323);
            this.btn_resetall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_resetall.Name = "btn_resetall";
            this.btn_resetall.Size = new System.Drawing.Size(59, 23);
            this.btn_resetall.TabIndex = 24;
            this.btn_resetall.Text = "Reset All";
            this.btn_resetall.UseVisualStyleBackColor = true;
            this.btn_resetall.Click += new System.EventHandler(this.btn_resetall_Click);
            // 
            // btn_revoke2
            // 
            this.btn_revoke2.AutoSize = true;
            this.btn_revoke2.Enabled = false;
            this.btn_revoke2.Location = new System.Drawing.Point(122, 127);
            this.btn_revoke2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_revoke2.Name = "btn_revoke2";
            this.btn_revoke2.Size = new System.Drawing.Size(56, 23);
            this.btn_revoke2.TabIndex = 23;
            this.btn_revoke2.Text = "Revoke";
            this.btn_revoke2.UseVisualStyleBackColor = true;
            this.btn_revoke2.Click += new System.EventHandler(this.btn_revoke2_Click);
            // 
            // btn_grant2
            // 
            this.btn_grant2.AutoSize = true;
            this.btn_grant2.Location = new System.Drawing.Point(33, 127);
            this.btn_grant2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_grant2.Name = "btn_grant2";
            this.btn_grant2.Size = new System.Drawing.Size(56, 23);
            this.btn_grant2.TabIndex = 22;
            this.btn_grant2.Text = "Grant";
            this.btn_grant2.UseVisualStyleBackColor = true;
            this.btn_grant2.Click += new System.EventHandler(this.btn_grant2_Click);
            // 
            // btn_revoke1
            // 
            this.btn_revoke1.AutoSize = true;
            this.btn_revoke1.Enabled = false;
            this.btn_revoke1.Location = new System.Drawing.Point(122, 107);
            this.btn_revoke1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_revoke1.Name = "btn_revoke1";
            this.btn_revoke1.Size = new System.Drawing.Size(56, 23);
            this.btn_revoke1.TabIndex = 21;
            this.btn_revoke1.Text = "Revoke";
            this.btn_revoke1.UseVisualStyleBackColor = true;
            this.btn_revoke1.Click += new System.EventHandler(this.btn_revoke1_Click);
            // 
            // btn_grant1
            // 
            this.btn_grant1.AutoSize = true;
            this.btn_grant1.Location = new System.Drawing.Point(33, 107);
            this.btn_grant1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_grant1.Name = "btn_grant1";
            this.btn_grant1.Size = new System.Drawing.Size(56, 23);
            this.btn_grant1.TabIndex = 20;
            this.btn_grant1.Text = "Grant";
            this.btn_grant1.UseVisualStyleBackColor = true;
            this.btn_grant1.Click += new System.EventHandler(this.btn_grant1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Object";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Grantee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Privilege type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Grantee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Privilege type";
            // 
            // dgv_objectprivilegelist
            // 
            this.dgv_objectprivilegelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_objectprivilegelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_objectprivilegelist.Location = new System.Drawing.Point(245, 182);
            this.dgv_objectprivilegelist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_objectprivilegelist.Name = "dgv_objectprivilegelist";
            this.dgv_objectprivilegelist.RowHeadersWidth = 51;
            this.dgv_objectprivilegelist.RowTemplate.Height = 24;
            this.dgv_objectprivilegelist.Size = new System.Drawing.Size(337, 122);
            this.dgv_objectprivilegelist.TabIndex = 14;
            this.dgv_objectprivilegelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_objectprivilegelist_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRIVILEGE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TABLE NAME";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "COLUMN NAME";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // dgv_sysprivilegelist
            // 
            this.dgv_sysprivilegelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sysprivilegelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_sysprivilegelist.Location = new System.Drawing.Point(245, 28);
            this.dgv_sysprivilegelist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_sysprivilegelist.Name = "dgv_sysprivilegelist";
            this.dgv_sysprivilegelist.RowHeadersWidth = 51;
            this.dgv_sysprivilegelist.RowTemplate.Height = 24;
            this.dgv_sysprivilegelist.Size = new System.Drawing.Size(337, 122);
            this.dgv_sysprivilegelist.TabIndex = 13;
            this.dgv_sysprivilegelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sysprivilegelist_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "PRIVILEGE";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // txtbx_privilegetype1
            // 
            this.txtbx_privilegetype1.Location = new System.Drawing.Point(93, 44);
            this.txtbx_privilegetype1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_privilegetype1.Name = "txtbx_privilegetype1";
            this.txtbx_privilegetype1.Size = new System.Drawing.Size(128, 20);
            this.txtbx_privilegetype1.TabIndex = 25;
            this.txtbx_privilegetype1.TextChanged += new System.EventHandler(this.txtbx_privilegetype1_TextChanged);
            // 
            // txtbx_grantee1
            // 
            this.txtbx_grantee1.Enabled = false;
            this.txtbx_grantee1.Location = new System.Drawing.Point(93, 73);
            this.txtbx_grantee1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_grantee1.Name = "txtbx_grantee1";
            this.txtbx_grantee1.Size = new System.Drawing.Size(128, 20);
            this.txtbx_grantee1.TabIndex = 26;
            // 
            // txtbx_privilegetype2
            // 
            this.txtbx_privilegetype2.Location = new System.Drawing.Point(93, 175);
            this.txtbx_privilegetype2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_privilegetype2.Name = "txtbx_privilegetype2";
            this.txtbx_privilegetype2.Size = new System.Drawing.Size(128, 20);
            this.txtbx_privilegetype2.TabIndex = 27;
            this.txtbx_privilegetype2.TextChanged += new System.EventHandler(this.txtbx_privilegetype2_TextChanged);
            // 
            // txtbx_object2
            // 
            this.txtbx_object2.Location = new System.Drawing.Point(78, 55);
            this.txtbx_object2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_object2.Name = "txtbx_object2";
            this.txtbx_object2.Size = new System.Drawing.Size(128, 20);
            this.txtbx_object2.TabIndex = 28;
            // 
            // txtbx_grantee2
            // 
            this.txtbx_grantee2.Enabled = false;
            this.txtbx_grantee2.Location = new System.Drawing.Point(78, 89);
            this.txtbx_grantee2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_grantee2.Name = "txtbx_grantee2";
            this.txtbx_grantee2.Size = new System.Drawing.Size(128, 20);
            this.txtbx_grantee2.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtbx_object2);
            this.groupBox1.Controls.Add(this.txtbx_grantee2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_revoke2);
            this.groupBox1.Controls.Add(this.btn_grant2);
            this.groupBox1.Location = new System.Drawing.Point(15, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(596, 164);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object privilege";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_revoke1);
            this.groupBox2.Controls.Add(this.btn_grant1);
            this.groupBox2.Location = new System.Drawing.Point(15, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(596, 152);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System privilege";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(634, 366);
            this.Controls.Add(this.txtbx_privilegetype2);
            this.Controls.Add(this.txtbx_grantee1);
            this.Controls.Add(this.txtbx_privilegetype1);
            this.Controls.Add(this.btn_resetall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_objectprivilegelist);
            this.Controls.Add(this.dgv_sysprivilegelist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Role privilege";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_objectprivilegelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sysprivilegelist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resetall;
        private System.Windows.Forms.Button btn_revoke2;
        private System.Windows.Forms.Button btn_grant2;
        private System.Windows.Forms.Button btn_revoke1;
        private System.Windows.Forms.Button btn_grant1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_objectprivilegelist;
        private System.Windows.Forms.DataGridView dgv_sysprivilegelist;
        private System.Windows.Forms.TextBox txtbx_privilegetype1;
        private System.Windows.Forms.TextBox txtbx_grantee1;
        private System.Windows.Forms.TextBox txtbx_privilegetype2;
        private System.Windows.Forms.TextBox txtbx_object2;
        private System.Windows.Forms.TextBox txtbx_grantee2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}