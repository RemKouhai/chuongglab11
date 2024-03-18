using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai1
{
    public partial class Form1 : Form
    {
        private List<double> numbers;
        public Form1()
        {
            InitializeComponent();
            numbers = new List<double>();
            textBox2.Enabled = false;
            dtb.Enabled = false;
            dcn.Enabled = false;
            dau.Enabled = false;
            hl.Enabled = false;
            dtt.Enabled = false;
            rot.Enabled = false;
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numbers.Clear();
            string input = textBox1.Text;
            input = input.Replace(".",",");
            string[] numberStrings = input.Split(' ');
     
           
           

                foreach (string numberString in numberStrings)
            {


                if (double.TryParse(numberString, out double number))
                {

                    if (number >= 0 && number <= 10)
                    {
                        numbers.Add((double)number);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số trong khoảng từ 0 đến 10", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                

                  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///////////////hien diem//////////////////////////////////
            string output = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                output += $"Môn {i + 1}: {numbers[i]}đ\t";
            }
            textBox2.Text = output;
            //////////////diem trung binh////////////////////////////////////
            string output1 = "";
            double tb = 0;
            double tong1= 0;
            for (int i = 0; i < numbers.Count; i++)
            { 
                tong1 += numbers[i];
            }
            tb=tong1/(double)numbers.Count;
            output1=tb.ToString("0.00");
            dtb.Text = output1;
            ////////////////diem cao nhat//////////////////////////////////
            string output2 = "";
            double cn = (double)numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if ((double)numbers[i] > cn) { cn = (double)numbers[i]; }
            }
            output2 = cn.ToString();
            dcn.Text = output2;
            ////////////////diem thap nhat//////////////////////////////////
            string output3 = "";
            double tn = (double)numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if ((double)numbers[i] < tn) { tn = (double)numbers[i]; }
            }
            output3 = tn.ToString();
            dtt.Text = output3;
            /////////////////////so mon dau/////////////////////////////
            string output4 = "";
            int smd = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if ((double)numbers[i] >= 5 ) { smd++; }
            }
            output4 = smd.ToString();
            dau.Text = output4;
            /////////////////////so mon ko dau/////////////////////////////
            string output5 = "";
            int smr = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if ((double)numbers[i] < 5) { smr++; }
            }
            output5 = smr.ToString();
            rot.Text = output5;
            /////////////////////xep loai/////////////////////////////
            string output6 = "";
            string xl = "";
            if (tb >= 8 && tn > 6.5)
            {
                xl = "Giỏi";
            }
            else if (tb >= 6.5 && tn >5 )
            {
                xl = "Khá";
            }
            else if (tb >= 5 && tn > 3.5)
            {
                xl = "Trung bình";
            }
            else if (tb >= 3.5 && tn > 2)
            {
                xl = "Yếu";
            }
            else
            {
                xl = "Kém";
            }
            output6 = xl;
            hl.Text = output6;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dcn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dau_TextChanged(object sender, EventArgs e)
        {

        }

        private void hl_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rot_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int code = Convert.ToInt32(e.KeyChar);
           
            if ((code >= 48 && code <= 57) || code == 8 || code == 45 ||code==32 || code == 46 || code == 44)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
    }
}
