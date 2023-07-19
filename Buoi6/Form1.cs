using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String strcnn = "Data Source=LAPTOP-4HMISIVV\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        BindingSource bs = null;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(strcnn);
            if (cnn == null)
                cnn = new SqlConnection(strcnn);
            SqlDataAdapter adt = new SqlDataAdapter("Select * from Student", cnn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adt);
            DataSet ds = new DataSet();
            adt.Fill(ds, "student");
            bs = new BindingSource(ds, "student");
            txtmasv.DataBindings.Add("text", bs, "MaSV");
            txttensv.DataBindings.Add("text", bs, "Hoten");
            txtdiemsv.DataBindings.Add("text", bs, "DiemTB");
            txtmakhoa.DataBindings.Add("text", bs, "Khoa");
            label1.Text = "1/" + bs.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
            label1.Text = (bs.Position + 1) + "/" + bs.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
            label1.Text = (bs.Position + 1) + "/" + bs.Count;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string masv = txtmasv.Text;
            string tensv = txttensv.Text;
            float diem = float.Parse(txtdiemsv.Text);
            string makhoa = txtmakhoa.Text;
            themSV(masv, tensv, diem, makhoa);
            MessageBox.Show("Thêm thành công ");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bs.Position > 0)
                bs.Position--;
            label1.Text = (bs.Position + 1) + "/" + bs.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count - 1)
                bs.Position++;
            label1.Text = (bs.Position + 1) + "/" + bs.Count;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }
        public void themSV(string MaSV, string Hoten, float DiemTB, string Khoa)
        {
            SqlConnection sqlConnection =  new SqlConnection(strcnn);
            string query = " insert into Student(MaSV, Hoten, DiemTB, Khoa) values(@MaSV,@Hoten,@DiemTB, @Khoa)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@MaSV", MaSV);
            sqlCommand.Parameters.Add("@Hoten", Hoten);
            sqlCommand.Parameters.Add("@DiemTB", DiemTB);
            sqlCommand.Parameters.Add("@Khoa", Khoa);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        private void Xoa(string ma)
        {
            SqlConnection conn = new SqlConnection(strcnn);
            string query = " Delete from Student where MaSV = @ma";
            SqlCommand  cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("ma", ma);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtmasv.Text;
            Xoa(ma);
            MessageBox.Show("Xóa thành công");
        }
    }
}
