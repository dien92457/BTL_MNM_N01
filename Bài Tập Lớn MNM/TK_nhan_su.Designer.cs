namespace Bài_Tập_Lớn_MNM
{
    partial class TK_nhan_su
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
            this.lbl_TK = new System.Windows.Forms.Label();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_TNV = new System.Windows.Forms.RadioButton();
            this.rdb_MNV = new System.Windows.Forms.RadioButton();
            this.rdb_TPB = new System.Windows.Forms.RadioButton();
            this.rdb_TCC = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TK
            // 
            this.lbl_TK.AutoSize = true;
            this.lbl_TK.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_TK.Location = new System.Drawing.Point(28, 63);
            this.lbl_TK.Name = "lbl_TK";
            this.lbl_TK.Size = new System.Drawing.Size(150, 27);
            this.lbl_TK.TabIndex = 9;
            this.lbl_TK.Text = "Mã nhân viên:";
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_TK.Location = new System.Drawing.Point(192, 60);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(436, 35);
            this.txt_TK.TabIndex = 8;
            this.txt_TK.TextChanged += new System.EventHandler(this.txt_TK_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(783, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 309);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(850, 371);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_TK);
            this.groupBox1.Controls.Add(this.txt_TK);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(75, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhân sự";
            // 
            // rdb_TNV
            // 
            this.rdb_TNV.AutoSize = true;
            this.rdb_TNV.Location = new System.Drawing.Point(226, 21);
            this.rdb_TNV.Name = "rdb_TNV";
            this.rdb_TNV.Size = new System.Drawing.Size(160, 29);
            this.rdb_TNV.TabIndex = 1;
            this.rdb_TNV.TabStop = true;
            this.rdb_TNV.Text = "Tên nhân viên";
            this.rdb_TNV.UseVisualStyleBackColor = true;
            this.rdb_TNV.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdb_MNV
            // 
            this.rdb_MNV.AutoSize = true;
            this.rdb_MNV.Location = new System.Drawing.Point(23, 21);
            this.rdb_MNV.Name = "rdb_MNV";
            this.rdb_MNV.Size = new System.Drawing.Size(155, 29);
            this.rdb_MNV.TabIndex = 0;
            this.rdb_MNV.TabStop = true;
            this.rdb_MNV.Text = "Mã nhân viên";
            this.rdb_MNV.UseVisualStyleBackColor = true;
            this.rdb_MNV.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_TPB
            // 
            this.rdb_TPB.AutoSize = true;
            this.rdb_TPB.Location = new System.Drawing.Point(462, 21);
            this.rdb_TPB.Name = "rdb_TPB";
            this.rdb_TPB.Size = new System.Drawing.Size(166, 29);
            this.rdb_TPB.TabIndex = 12;
            this.rdb_TPB.TabStop = true;
            this.rdb_TPB.Text = "Tên phòng ban";
            this.rdb_TPB.UseVisualStyleBackColor = true;
            this.rdb_TPB.CheckedChanged += new System.EventHandler(this.rdb_TPB_CheckedChanged);
            // 
            // rdb_TCC
            // 
            this.rdb_TCC.AutoSize = true;
            this.rdb_TCC.Location = new System.Drawing.Point(670, 23);
            this.rdb_TCC.Name = "rdb_TCC";
            this.rdb_TCC.Size = new System.Drawing.Size(161, 29);
            this.rdb_TCC.TabIndex = 13;
            this.rdb_TCC.TabStop = true;
            this.rdb_TCC.Text = "Tên chứng chỉ";
            this.rdb_TCC.UseVisualStyleBackColor = true;
            this.rdb_TCC.CheckedChanged += new System.EventHandler(this.rdb_TCC_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_MNV);
            this.panel1.Controls.Add(this.rdb_TCC);
            this.panel1.Controls.Add(this.rdb_TNV);
            this.panel1.Controls.Add(this.rdb_TPB);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.panel1.Location = new System.Drawing.Point(75, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 68);
            this.panel1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button2.Location = new System.Drawing.Point(783, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 54);
            this.button2.TabIndex = 15;
            this.button2.Text = "In danh sách";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TK_nhan_su
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TK_nhan_su";
            this.Text = "Tìm_kiếm_nhân_sự";
            this.Load += new System.EventHandler(this.TK_nhan_su_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_TK;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_TNV;
        private System.Windows.Forms.RadioButton rdb_MNV;
        private System.Windows.Forms.RadioButton rdb_TPB;
        private System.Windows.Forms.RadioButton rdb_TCC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}