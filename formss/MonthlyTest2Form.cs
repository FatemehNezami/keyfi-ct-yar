﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formss
{
    public partial class MonthlyTest2Form : Form
    {
        // لیستی از نام‌های سر ردیف‌ها
        private List<string> rowHeadersText = new List<string> { "1", "2", "3", "4" };

        private void SetupDataGridView()
        {
            // پاک کردن ستون‌های پیشین
            dataGridView1.Columns.Clear();

            // افزودن 3 ستون به DataGridView
            dataGridView1.Columns.Add("Column1", "ضخامت یا قطر فانتوم");
            dataGridView1.Columns.Add("Column2", "عدد سی تی اندازه گیری شده در تصویر/فانتوم آب");
            dataGridView1.Columns.Add("Column3", "خطا");

            // تنظیم تعداد ردیف‌ها
            dataGridView1.Rows.Add(4);

            // فعال کردن نمایش سر ردیف‌ها
            dataGridView1.RowHeadersVisible = true;

            // تنظیم عرض سر ردیف‌ها
            dataGridView1.RowHeadersWidth = 30;

            // جلوگیری از تغییر نام سر ستون‌ها توسط کاربر
            dataGridView1.AllowUserToAddRows =true;   //  افزودن ردیف جدید توسط کاربر
            dataGridView1.AllowUserToDeleteRows = false; // جلوگیری از حذف ردیف توسط کاربر
            dataGridView1.AllowUserToResizeColumns = false; // جلوگیری از تغییر سایز ستون‌ها
            dataGridView1.AllowUserToResizeRows = false;  // جلوگیری از تغییر سایز ردیف‌ها

            // متصل کردن رویداد RowPostPaint به DataGridView
            dataGridView1.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dataGridView1_RowPostPaint);
        }

        // رویداد برای تنظیم نام سر ردیف‌ها
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;

            // بررسی اینکه تعداد ردیف‌ها کافی است
            if (e.RowIndex < rowHeadersText.Count)
            {
                string rowText = rowHeadersText[e.RowIndex];  // متن دلخواه برای سر ردیف

                // تنظیم فرمت برای مرکزیت متن
                var centerFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // رسم متن دلخواه در داخل سر ردیف
                e.Graphics.DrawString(rowText, this.Font, SystemBrushes.ControlText, e.RowBounds.Left + 10, e.RowBounds.Top + 4, centerFormat);
            }
        }
        public MonthlyTest2Form()
        {
            InitializeComponent();
        }

        private void MonthlyTest2Form_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }
    }
}
