﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace formss
{
    public partial class FormRegister : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=.;Initial Catalog=ct;Integrated Security=True;Trust Server Certificate=True");
            cn.Open();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( txtBoxPassword.Text != string.Empty || txtBoxUsername.Text != string.Empty)
            {
                if (txtBoxPassword.Text != null)
                {
                    cmd = new SqlCommand("select * from users where user_name='" + txtBoxUsername.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("نام کاربری از قبل وجود دارد لطفاً نام کاربری دیگری را امتحان کنید ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into users values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("user_name", txtBoxUsername.Text);
                        cmd.Parameters.AddWithValue("password", txtBoxPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("حساب شما ایجاد شده است. لطفا همین الان وارد شوید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("لطفا رمز عبور هر دو را یکسان وارد کنید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("لطفا مقدار را در همه فیلد وارد کنید.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // بررسی کنید که آیا فرم قبلاً باز نشده است
            if (Application.OpenForms["FormPersonalInfo"] == null)
            {
                // ایجاد و نمایش فرم جدید اگر هنوز باز نشده است
                FormPersonalInfo personalInfoForm = new FormPersonalInfo();
                personalInfoForm.Show();
            }
            else
            {
                // اگر فرم قبلاً باز شده، آن را فعال کنید
                Application.OpenForms["FormPersonalInfo"].BringToFront();
            }
        }
    }
}
