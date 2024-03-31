using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        [Serializable]
        class Student
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string DienThoai { get; set; }
            public double DiemVan { get; set; }
            public double DiemToan { get; set; }

            public double DTB()
            {
                return (DiemVan + DiemToan) / 2;
            }
        }

        List<Student> students = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void hoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void mssv_TextChanged(object sender, EventArgs e)
        {

        }

        private void sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void van_TextChanged(object sender, EventArgs e)
        {
            string input = van.Text;
            input = input.Replace(".", ",");
            if (double.TryParse(input, out double number))
            {

                if (number < 0 || number > 10)
                {
                    MessageBox.Show("Vui lòng nhập số trong khoảng từ 0 đến 10", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void toan_TextChanged(object sender, EventArgs e)
        {
            string input1 = toan.Text;
            input1 = input1.Replace(".", ",");
            if (double.TryParse(input1, out double number))
            {

                if (number < 0 || number > 10)
                {
                    MessageBox.Show("Vui lòng nhập số trong khoảng từ 0 đến 10", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void mssv_KeyPress(object sender, KeyPressEventArgs e)
        {

            int code = Convert.ToInt32(e.KeyChar);

            if ((code >= 48 && code <= 57) || code == 8  || code == 46 || code == 44)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int code = Convert.ToInt32(e.KeyChar);

            if ((code >= 48 && code <= 57) || code == 8 || code == 46 || code == 44)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }


        private void van_KeyPress(object sender, KeyPressEventArgs e)
        {
            int code = Convert.ToInt32(e.KeyChar);

            if ((code >= 48 && code <= 57) || code == 8 || code == 45 || code == 32 || code == 46 || code == 44)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void toan_KeyPress(object sender, KeyPressEventArgs e)
        {
            int code = Convert.ToInt32(e.KeyChar);

            if ((code >= 48 && code <= 57) || code == 8 || code == 45 || code == 32 || code == 46 || code == 44)
            {
                e.Handled = false;
            }
            else e.Handled = true;

        }

        private void hoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            int code = Convert.ToInt32(e.KeyChar);

            if (!((code >= 48 && code <= 57) || code == 45  || code == 46 || code == 44))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void nutluu_Click(object sender, EventArgs e)
        {
            string dv = van.Text;
            dv = dv.Replace(".", ",");
            string dt = toan.Text;
            dt = dt.Replace(".", ",");


            Student student = new Student
            {
                HoTen = hoten.Text,
                MSSV = mssv.Text,
                DienThoai=sdt.Text,
                DiemVan=double.Parse(dv),
                DiemToan = double.Parse(dt),
            };

            students.Add(student);

            hoten.Text = "";
            mssv.Text = "";
            sdt.Text = "";
            van.Text = "";
            toan.Text = "";

            BinaryFormatter formatter = new BinaryFormatter();

           
            using (FileStream fs = new FileStream(@"input.txt", FileMode.Create))
            {
               
                formatter.Serialize(fs, students);
            }

           
        }

        private void nutxuat_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<Student> students;
            using (FileStream fs = new FileStream(@"input.txt", FileMode.Open))
            {
                students = (List<Student>)formatter.Deserialize(fs);
            }
            using (StreamWriter writer = new StreamWriter(@"output.txt"))
            {
                foreach (Student student in students)
                {

                    double dtb = Math.Round(student.DTB(),2);


                    writer.WriteLine(student.MSSV);
                    writer.WriteLine(student.HoTen);
                    writer.WriteLine(student.DienThoai);
                    writer.WriteLine(student.DiemVan);
                    writer.WriteLine(student.DiemToan);
                    writer.WriteLine(dtb);
                    writer.WriteLine("");
                    writer.WriteLine("");

                }

                try
                {
                    Process.Start(@"output.txt");
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show("Không thể mở tệp tin. Lỗi: " + ex.Message);
                }

                try
                {
                    Process.Start(@"input.txt");
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show("Không thể mở tệp tin. Lỗi: " + ex.Message);
                }
            }
        }
    }
}
