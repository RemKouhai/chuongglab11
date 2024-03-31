namespace LAB2
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
            this.hoten = new System.Windows.Forms.TextBox();
            this.van = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.mssv = new System.Windows.Forms.TextBox();
            this.toan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nutluu = new System.Windows.Forms.Button();
            this.nutxuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(368, 52);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(190, 22);
            this.hoten.TabIndex = 0;
            this.hoten.TextChanged += new System.EventHandler(this.hoten_TextChanged);
            this.hoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoten_KeyPress);
            // 
            // van
            // 
            this.van.Location = new System.Drawing.Point(368, 209);
            this.van.Name = "van";
            this.van.Size = new System.Drawing.Size(100, 22);
            this.van.TabIndex = 1;
            this.van.TextChanged += new System.EventHandler(this.van_TextChanged);
            this.van.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.van_KeyPress);
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(368, 152);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(100, 22);
            this.sdt.TabIndex = 2;
            this.sdt.TextChanged += new System.EventHandler(this.sdt_TextChanged);
            this.sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sdt_KeyPress);
            // 
            // mssv
            // 
            this.mssv.Location = new System.Drawing.Point(368, 101);
            this.mssv.Name = "mssv";
            this.mssv.Size = new System.Drawing.Size(100, 22);
            this.mssv.TabIndex = 3;
            this.mssv.TextChanged += new System.EventHandler(this.mssv_TextChanged);
            this.mssv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mssv_KeyPress);
            // 
            // toan
            // 
            this.toan.Location = new System.Drawing.Point(368, 258);
            this.toan.Name = "toan";
            this.toan.Size = new System.Drawing.Size(100, 22);
            this.toan.TabIndex = 4;
            this.toan.TextChanged += new System.EventHandler(this.toan_TextChanged);
            this.toan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toan_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Điểm Văn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Điểm Toán";
            // 
            // nutluu
            // 
            this.nutluu.Location = new System.Drawing.Point(184, 342);
            this.nutluu.Name = "nutluu";
            this.nutluu.Size = new System.Drawing.Size(75, 23);
            this.nutluu.TabIndex = 10;
            this.nutluu.Text = "Lưu";
            this.nutluu.UseVisualStyleBackColor = true;
            this.nutluu.Click += new System.EventHandler(this.nutluu_Click);
            // 
            // nutxuat
            // 
            this.nutxuat.Location = new System.Drawing.Point(483, 342);
            this.nutxuat.Name = "nutxuat";
            this.nutxuat.Size = new System.Drawing.Size(75, 23);
            this.nutxuat.TabIndex = 11;
            this.nutxuat.Text = "Xuất";
            this.nutxuat.UseVisualStyleBackColor = true;
            this.nutxuat.Click += new System.EventHandler(this.nutxuat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nutxuat);
            this.Controls.Add(this.nutluu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toan);
            this.Controls.Add(this.mssv);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.van);
            this.Controls.Add(this.hoten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.TextBox van;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox mssv;
        private System.Windows.Forms.TextBox toan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nutluu;
        private System.Windows.Forms.Button nutxuat;
    }
}

