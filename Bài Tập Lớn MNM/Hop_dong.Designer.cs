namespace Bài_Tập_Lớn_MNM
{
    partial class Hop_dong
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
            this.BTN_update = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.BTN_insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_GC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime_NK = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_THD = new System.Windows.Forms.TextBox();
            this.txt_MHD = new System.Windows.Forms.TextBox();
            this.txt_MNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_reset = new System.Windows.Forms.Button();
            this.dateTime_TH = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_update
            // 
            this.BTN_update.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BTN_update.Location = new System.Drawing.Point(485, 109);
            this.BTN_update.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_update.Name = "BTN_update";
            this.BTN_update.Size = new System.Drawing.Size(107, 33);
            this.BTN_update.TabIndex = 18;
            this.BTN_update.Text = "Cập nhật";
            this.BTN_update.UseVisualStyleBackColor = true;
            this.BTN_update.Click += new System.EventHandler(this.BTN_update_Click);
            // 
            // BTN_delete
            // 
            this.BTN_delete.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BTN_delete.Location = new System.Drawing.Point(485, 163);
            this.BTN_delete.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(107, 33);
            this.BTN_delete.TabIndex = 17;
            this.BTN_delete.Text = "Xóa thông tin";
            this.BTN_delete.UseVisualStyleBackColor = true;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // BTN_insert
            // 
            this.BTN_insert.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BTN_insert.Location = new System.Drawing.Point(485, 56);
            this.BTN_insert.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_insert.Name = "BTN_insert";
            this.BTN_insert.Size = new System.Drawing.Size(107, 33);
            this.BTN_insert.TabIndex = 16;
            this.BTN_insert.Text = "Thêm thông tin";
            this.BTN_insert.UseVisualStyleBackColor = true;
            this.BTN_insert.Click += new System.EventHandler(this.BTN_insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 291);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(533, 162);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_GC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_ND);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTime_TH);
            this.groupBox1.Controls.Add(this.dateTime_NK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_THD);
            this.groupBox1.Controls.Add(this.txt_MHD);
            this.groupBox1.Controls.Add(this.txt_MNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(397, 242);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hợp đồng";
            // 
            // txt_GC
            // 
            this.txt_GC.Location = new System.Drawing.Point(129, 203);
            this.txt_GC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GC.Name = "txt_GC";
            this.txt_GC.Size = new System.Drawing.Size(241, 24);
            this.txt_GC.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ghi chú:";
            // 
            // txt_ND
            // 
            this.txt_ND.Location = new System.Drawing.Point(129, 174);
            this.txt_ND.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ND.Name = "txt_ND";
            this.txt_ND.Size = new System.Drawing.Size(241, 24);
            this.txt_ND.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nội dung:";
            // 
            // dateTime_NK
            // 
            this.dateTime_NK.Location = new System.Drawing.Point(129, 114);
            this.dateTime_NK.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_NK.Name = "dateTime_NK";
            this.dateTime_NK.Size = new System.Drawing.Size(242, 24);
            this.dateTime_NK.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày ký:";
            // 
            // txt_THD
            // 
            this.txt_THD.Location = new System.Drawing.Point(131, 83);
            this.txt_THD.Margin = new System.Windows.Forms.Padding(2);
            this.txt_THD.Name = "txt_THD";
            this.txt_THD.Size = new System.Drawing.Size(241, 24);
            this.txt_THD.TabIndex = 6;
            // 
            // txt_MHD
            // 
            this.txt_MHD.Location = new System.Drawing.Point(131, 54);
            this.txt_MHD.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MHD.Name = "txt_MHD";
            this.txt_MHD.Size = new System.Drawing.Size(120, 24);
            this.txt_MHD.TabIndex = 5;
            // 
            // txt_MNV
            // 
            this.txt_MNV.Location = new System.Drawing.Point(131, 24);
            this.txt_MNV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MNV.Name = "txt_MNV";
            this.txt_MNV.Size = new System.Drawing.Size(120, 24);
            this.txt_MNV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời hạn (năm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hợp đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hợp đồng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // BTN_reset
            // 
            this.BTN_reset.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BTN_reset.Location = new System.Drawing.Point(485, 202);
            this.BTN_reset.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_reset.Name = "BTN_reset";
            this.BTN_reset.Size = new System.Drawing.Size(107, 33);
            this.BTN_reset.TabIndex = 18;
            this.BTN_reset.Text = "Xoá";
            this.BTN_reset.UseVisualStyleBackColor = true;
            this.BTN_reset.Click += new System.EventHandler(this.BTN_reset_Click);
            // 
            // dateTime_TH
            // 
            this.dateTime_TH.CustomFormat = "yyyy";
            this.dateTime_TH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_TH.Location = new System.Drawing.Point(129, 146);
            this.dateTime_TH.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_TH.Name = "dateTime_TH";
            this.dateTime_TH.Size = new System.Drawing.Size(242, 24);
            this.dateTime_TH.TabIndex = 9;
            // 
            // Hop_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(652, 484);
            this.Controls.Add(this.BTN_reset);
            this.Controls.Add(this.BTN_update);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.BTN_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hop_dong";
            this.Text = "Hợp_đồng";
            this.Load += new System.EventHandler(this.Hop_dong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_update;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.Button BTN_insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime_NK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_THD;
        private System.Windows.Forms.TextBox txt_MHD;
        private System.Windows.Forms.TextBox txt_MNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_reset;
        private System.Windows.Forms.DateTimePicker dateTime_TH;
    }
}