﻿namespace Bài_Tập_Lớn_MNM
{
    partial class Bao_hiem
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
            this.txt_MSBH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime_NL = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TBH = new System.Windows.Forms.TextBox();
            this.txt_SBH = new System.Windows.Forms.TextBox();
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
            this.BTN_update.Location = new System.Drawing.Point(485, 94);
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
            this.BTN_delete.Location = new System.Drawing.Point(485, 148);
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
            this.BTN_insert.Location = new System.Drawing.Point(485, 40);
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
            this.dataGridView1.Location = new System.Drawing.Point(59, 260);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(533, 195);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime_TH);
            this.groupBox1.Controls.Add(this.txt_MSBH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTime_NL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_TBH);
            this.groupBox1.Controls.Add(this.txt_SBH);
            this.groupBox1.Controls.Add(this.txt_MNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(397, 216);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảo hiểm";
            // 
            // txt_MSBH
            // 
            this.txt_MSBH.Location = new System.Drawing.Point(131, 25);
            this.txt_MSBH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MSBH.Name = "txt_MSBH";
            this.txt_MSBH.Size = new System.Drawing.Size(120, 24);
            this.txt_MSBH.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã số bảo hiểm:";
            // 
            // dateTime_NL
            // 
            this.dateTime_NL.CustomFormat = "dd/MM/yyyy";
            this.dateTime_NL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_NL.Location = new System.Drawing.Point(129, 138);
            this.dateTime_NL.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_NL.Name = "dateTime_NL";
            this.dateTime_NL.Size = new System.Drawing.Size(242, 24);
            this.dateTime_NL.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày lập:";
            // 
            // txt_TBH
            // 
            this.txt_TBH.Location = new System.Drawing.Point(131, 107);
            this.txt_TBH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TBH.Name = "txt_TBH";
            this.txt_TBH.Size = new System.Drawing.Size(241, 24);
            this.txt_TBH.TabIndex = 6;
            // 
            // txt_SBH
            // 
            this.txt_SBH.Location = new System.Drawing.Point(131, 79);
            this.txt_SBH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SBH.Name = "txt_SBH";
            this.txt_SBH.Size = new System.Drawing.Size(169, 24);
            this.txt_SBH.TabIndex = 5;
            // 
            // txt_MNV
            // 
            this.txt_MNV.Location = new System.Drawing.Point(131, 51);
            this.txt_MNV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MNV.Name = "txt_MNV";
            this.txt_MNV.Size = new System.Drawing.Size(120, 24);
            this.txt_MNV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời hạn (năm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bảo hiểm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số bảo hiểm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // BTN_reset
            // 
            this.BTN_reset.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BTN_reset.Location = new System.Drawing.Point(485, 203);
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
            this.dateTime_TH.Location = new System.Drawing.Point(131, 174);
            this.dateTime_TH.Name = "dateTime_TH";
            this.dateTime_TH.Size = new System.Drawing.Size(200, 24);
            this.dateTime_TH.TabIndex = 12;
            // 
            // Bao_hiem
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
            this.Name = "Bao_hiem";
            this.Text = "Bảo_hiểm";
            this.Load += new System.EventHandler(this.Bao_hiem_Load);
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
        private System.Windows.Forms.DateTimePicker dateTime_NL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TBH;
        private System.Windows.Forms.TextBox txt_SBH;
        private System.Windows.Forms.TextBox txt_MNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MSBH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_reset;
        private System.Windows.Forms.DateTimePicker dateTime_TH;
    }
}