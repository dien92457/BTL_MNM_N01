namespace Bài_Tập_Lớn_MNM
{
    partial class Phong_ban
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TPB = new System.Windows.Forms.TextBox();
            this.txt_MPB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MNV = new System.Windows.Forms.TextBox();
            this.BTN_update = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.BTN_INSERT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_reset = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TPB);
            this.groupBox2.Controls.Add(this.txt_MPB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_MNV);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(59, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(393, 132);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phòng ban";
            // 
            // txt_TPB
            // 
            this.txt_TPB.Location = new System.Drawing.Point(131, 85);
            this.txt_TPB.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TPB.Name = "txt_TPB";
            this.txt_TPB.Size = new System.Drawing.Size(241, 24);
            this.txt_TPB.TabIndex = 6;
            // 
            // txt_MPB
            // 
            this.txt_MPB.Location = new System.Drawing.Point(131, 52);
            this.txt_MPB.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MPB.Name = "txt_MPB";
            this.txt_MPB.Size = new System.Drawing.Size(120, 24);
            this.txt_MPB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên phòng ban:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã phòng ban:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txt_MNV
            // 
            this.txt_MNV.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MNV.Location = new System.Drawing.Point(131, 21);
            this.txt_MNV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MNV.Name = "txt_MNV";
            this.txt_MNV.Size = new System.Drawing.Size(120, 24);
            this.txt_MNV.TabIndex = 21;
            // 
            // BTN_update
            // 
            this.BTN_update.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BTN_update.Location = new System.Drawing.Point(485, 123);
            this.BTN_update.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_update.Name = "BTN_update";
            this.BTN_update.Size = new System.Drawing.Size(107, 33);
            this.BTN_update.TabIndex = 26;
            this.BTN_update.Text = "Cập nhật";
            this.BTN_update.UseVisualStyleBackColor = true;
            this.BTN_update.Click += new System.EventHandler(this.BTN_update_Click_1);
            // 
            // BTN_delete
            // 
            this.BTN_delete.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BTN_delete.Location = new System.Drawing.Point(485, 157);
            this.BTN_delete.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(107, 33);
            this.BTN_delete.TabIndex = 25;
            this.BTN_delete.Text = "Xóa thông tin";
            this.BTN_delete.UseVisualStyleBackColor = true;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click_1);
            // 
            // BTN_INSERT
            // 
            this.BTN_INSERT.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BTN_INSERT.Location = new System.Drawing.Point(485, 77);
            this.BTN_INSERT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_INSERT.Name = "BTN_INSERT";
            this.BTN_INSERT.Size = new System.Drawing.Size(107, 33);
            this.BTN_INSERT.TabIndex = 24;
            this.BTN_INSERT.Text = "Thêm thông tin";
            this.BTN_INSERT.UseVisualStyleBackColor = true;
            this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 242);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(533, 162);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTN_reset
            // 
            this.BTN_reset.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BTN_reset.Location = new System.Drawing.Point(504, 205);
            this.BTN_reset.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_reset.Name = "BTN_reset";
            this.BTN_reset.Size = new System.Drawing.Size(59, 33);
            this.BTN_reset.TabIndex = 25;
            this.BTN_reset.Text = "Xóa ";
            this.BTN_reset.UseVisualStyleBackColor = true;
            this.BTN_reset.Click += new System.EventHandler(this.BTN_reset_Click);
            // 
            // Phong_ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(652, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_update);
            this.Controls.Add(this.BTN_reset);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.BTN_INSERT);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Phong_ban";
            this.Text = "Phòng_ban";
            this.Load += new System.EventHandler(this.Phong_ban_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_TPB;
        private System.Windows.Forms.TextBox txt_MPB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MNV;
        private System.Windows.Forms.Button BTN_update;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.Button BTN_INSERT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_reset;
    }
}