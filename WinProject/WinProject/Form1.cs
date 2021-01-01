using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nf = new Form2();
            nf.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "username" && txtPassword.Text == "pass")
            {
                Form2 ifPage = new Form2();
                ifPage.ShowDialog();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!\nBạn có muốn nhập lại?", "Lỗi nhập", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        private void checkLengTextBox(object sender, TextBox txtBox)
        {
            if (txtBox.Text.Length > 20)
            {
                MessageBox.Show("Không được nhập quá 20 kí tự", "Lỗi nhập");
                txtBox.Text = "";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            checkLengTextBox(sender, txtUsername);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            checkLengTextBox(sender, txtPassword);
        }
    }
}
