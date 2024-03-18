namespace bai1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtb = new System.Windows.Forms.TextBox();
            this.dcn = new System.Windows.Forms.TextBox();
            this.dau = new System.Windows.Forms.TextBox();
            this.hl = new System.Windows.Forms.TextBox();
            this.dtt = new System.Windows.Forms.TextBox();
            this.rot = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách điểm:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kết quả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.Location = new System.Drawing.Point(261, 172);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(610, 178);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách môn học và điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điểm trung bình : \r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Môn có điểm cao nhất : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số môn đậu : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Xếp loại học lực : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số môn không đậu : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Môn có điểm thấp nhất : ";
            // 
            // dtb
            // 
            this.dtb.Location = new System.Drawing.Point(150, 406);
            this.dtb.Name = "dtb";
            this.dtb.Size = new System.Drawing.Size(100, 22);
            this.dtb.TabIndex = 12;
            this.dtb.TextChanged += new System.EventHandler(this.dtb_TextChanged);
            // 
            // dcn
            // 
            this.dcn.Location = new System.Drawing.Point(190, 454);
            this.dcn.Name = "dcn";
            this.dcn.Size = new System.Drawing.Size(100, 22);
            this.dcn.TabIndex = 13;
            this.dcn.TextChanged += new System.EventHandler(this.dcn_TextChanged);
            // 
            // dau
            // 
            this.dau.Location = new System.Drawing.Point(131, 500);
            this.dau.Name = "dau";
            this.dau.Size = new System.Drawing.Size(100, 22);
            this.dau.TabIndex = 14;
            this.dau.TextChanged += new System.EventHandler(this.dau_TextChanged);
            // 
            // hl
            // 
            this.hl.Location = new System.Drawing.Point(618, 403);
            this.hl.Name = "hl";
            this.hl.Size = new System.Drawing.Size(100, 22);
            this.hl.TabIndex = 15;
            this.hl.TextChanged += new System.EventHandler(this.hl_TextChanged);
            // 
            // dtt
            // 
            this.dtt.Location = new System.Drawing.Point(658, 451);
            this.dtt.Name = "dtt";
            this.dtt.Size = new System.Drawing.Size(100, 22);
            this.dtt.TabIndex = 16;
            this.dtt.TextChanged += new System.EventHandler(this.dtt_TextChanged);
            // 
            // rot
            // 
            this.rot.Location = new System.Drawing.Point(636, 497);
            this.rot.Name = "rot";
            this.rot.Size = new System.Drawing.Size(100, 22);
            this.rot.TabIndex = 17;
            this.rot.TextChanged += new System.EventHandler(this.rot_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 578);
            this.Controls.Add(this.rot);
            this.Controls.Add(this.dtt);
            this.Controls.Add(this.hl);
            this.Controls.Add(this.dau);
            this.Controls.Add(this.dcn);
            this.Controls.Add(this.dtb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dtb;
        private System.Windows.Forms.TextBox dcn;
        private System.Windows.Forms.TextBox dau;
        private System.Windows.Forms.TextBox hl;
        private System.Windows.Forms.TextBox dtt;
        private System.Windows.Forms.TextBox rot;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

