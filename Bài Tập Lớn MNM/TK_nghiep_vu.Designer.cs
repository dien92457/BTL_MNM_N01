namespace Bài_Tập_Lớn_MNM
{
    partial class TK_nghiep_vu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_TDT = new System.Windows.Forms.RadioButton();
            this.rdb_TCT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_TK = new System.Windows.Forms.Label();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_TDT);
            this.panel1.Controls.Add(this.rdb_TCT);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.panel1.Location = new System.Drawing.Point(64, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 68);
            this.panel1.TabIndex = 17;
            // 
            // rdb_TDT
            // 
            this.rdb_TDT.AutoSize = true;
            this.rdb_TDT.Location = new System.Drawing.Point(192, 21);
            this.rdb_TDT.Name = "rdb_TDT";
            this.rdb_TDT.Size = new System.Drawing.Size(142, 29);
            this.rdb_TDT.TabIndex = 0;
            this.rdb_TDT.TabStop = true;
            this.rdb_TDT.Text = "Tên đào tạo";
            this.rdb_TDT.UseVisualStyleBackColor = true;
            this.rdb_TDT.CheckedChanged += new System.EventHandler(this.rdb_TDT_CheckedChanged);
            // 
            // rdb_TCT
            // 
            this.rdb_TCT.AutoSize = true;
            this.rdb_TCT.Location = new System.Drawing.Point(514, 21);
            this.rdb_TCT.Name = "rdb_TCT";
            this.rdb_TCT.Size = new System.Drawing.Size(150, 29);
            this.rdb_TCT.TabIndex = 1;
            this.rdb_TCT.TabStop = true;
            this.rdb_TCT.Text = "Tên công tác";
            this.rdb_TCT.UseVisualStyleBackColor = true;
            this.rdb_TCT.CheckedChanged += new System.EventHandler(this.rdb_TCT_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_TK);
            this.groupBox1.Controls.Add(this.txt_TK);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(64, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 132);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nghiệp vụ";
            // 
            // lbl_TK
            // 
            this.lbl_TK.AutoSize = true;
            this.lbl_TK.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_TK.Location = new System.Drawing.Point(28, 63);
            this.lbl_TK.Name = "lbl_TK";
            this.lbl_TK.Size = new System.Drawing.Size(132, 27);
            this.lbl_TK.TabIndex = 9;
            this.lbl_TK.Text = "Tên đào tạo:";
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_TK.Location = new System.Drawing.Point(192, 60);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(436, 35);
            this.txt_TK.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(772, 55);
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
            this.dataGridView1.Location = new System.Drawing.Point(64, 318);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(850, 371);
            this.dataGridView1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button2.Location = new System.Drawing.Point(772, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 54);
            this.button2.TabIndex = 18;
            this.button2.Text = "In danh sách";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TK_nghiep_vu
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
            this.Name = "TK_nghiep_vu";
            this.Text = "Tìm_kiếm_nghiệp_vụ";
            this.Load += new System.EventHandler(this.TK_nghiep_vu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_TDT;
        private System.Windows.Forms.RadioButton rdb_TCT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}