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
    public partial class MnthlyTestingEquipmentForm : Form
    {
        public MnthlyTestingEquipmentForm()
        {
            InitializeComponent();
        }

        private void MnthlyTestingEquipmentForm_Load(object sender, EventArgs e)
        {
                // تنظیم متن به راست به چپ
    richTextBox1.RightToLeft = RightToLeft.Yes;
    

    // قفل کردن RichTextBox برای جلوگیری از ویرایش
    richTextBox1.ReadOnly = true;

    // تنظیم فونت برای نمایش صحیح متن فارسی
    richTextBox1.Font = new Font("Tahoma", 12);

    // قرار دادن متن مورد نظر
    richTextBox1.Text = @" 
 آزمون صحت عدد سی تی اسکن در موقعیت های مختلف: 

 تجهیزات و لوازم موردنیاز: 
فانتوم آب سی تی اسکن (و یا یک ظرف پلاستیکی استوانه¬ای که دارای حدوداً 21 سانتی¬متر قطر بوده و محتوی آب باشد).


 آزمون صحت عدد سیتی اسکن در ضخامت های مختلف بیمار: 

تجهیزات و لوازم موردنیاز: 
فانتوم آب سی تی اسکن در ابعاد مختلف (بدین منظور می¬توان از ظروف استوانه¬ای شکل پلاستیکی که دارای قطرهای مختلف بوده و محتوی آب باشند استفاده نمود). 


 آزمون صحت عدد سی تی اسکن در الگوریتم¬های مختلف بازسازی تصویر: 

 تجهیزات و لوازم موردنیاز: 
فانتوم آب سی تی اسکن (و یا ظرف پلاستیکی) استوانه¬ای شکل که دارای حدوداً 20cm  قطر بوده و محتوی آب باشد. 



 آزمون یکنواختی عدد سی تی اسکن: 

 تجهیزات و لوازم موردنیاز: 
فانتوم آب سی تی اسکن (و یا ظرف پلاستیکی) استوانه¬ای شکل که دارای حدوداً20cm  قطر بوده و محتوی آب باشد. 


 آزمون قدرت تفکیک فضایی در کنتراست بالا: 

 تجهیزات و لوازم موردنیاز: 
فانتوم سی تی اسکن که حاوی مجموعه¬ای از جفت خط¬های مختلف و یا نواحی کوچک دایرهای با قطرهای مختلف  و با کنتراست¬های متفاوت است. 


 آزمون قدرت تفکیک فضایی در کنتراست پایین: 


 تجهیزات و لوازم موردنیاز: 
فانتوم سی تی اسکن که دارای نواحی دایره¬ای شکل با ابعاد مختلف و کنتراست¬های پایین است. 


 آزمون اعوجاج تصویر: 

تجهیزات و لوازم موردنیاز: 
1-  فانتوم سر یا بدن سی تی اسکن که دارای یک الگوی مناسب با فواصل معین باشد. برای این منظور می-توان یک الگو که دارای یک یا چند عنصر کوچک با فواصل معین و دقیق باشد استفاده کرد. به¬عنوان¬مثال الگوی نشان داده¬شده در شکل2-52 که به¬صورت یک + بزرگ متشکل از سوراخ¬های ریز و با فواصل دقیق و معین است مناسب خواهد بود به¬طوریکه تقریب تمام سطح فانتوم پوشش داده شود. 
2-  خط کش دقیق و استاندارد (نظیر کولیس)  


 آزمون تطابق نورهای داخلی و خارجی سطح Axial:   

 تجهیزات و لوازم موردنیاز: 
1-  یک صفحه کاغذ 
2-  یک عدد مارکر 


 آزمون انطباق نور داخلی سطح Axial با سطح Axial: 

 تجهیزات و لوازم موردنیاز: 
1-  فانتوم سر سی تی اسکن 
2-  فیلم (درون پاکت مخصوص) 
3-  سوزن 
4-  چسب نواری شفاف 


آزمون تطابق نورهای سطح Sagital و Cronal: 

 تجهیزات و لوازم موردنیاز: 
یک قطعه سیم مفتولی نازک و بلند. 


 آزمون تنظیم نقطه صفر تخت: 

 تجهیزات و لوازم موردنیاز: 
1-  متر (نوار اندازهگیری طول)
2-  چسب نواری 
3-  مارکر 
4-  وزنه معادل بیمار 


 آزمون صحت جابجایی تخت: 

 تجهیزات و لوازم موردنیاز: 
1-  فیلم درون پاکت مخصوص 
2-  وزنه معادل بیمار 
 ";
        }
    }
}
