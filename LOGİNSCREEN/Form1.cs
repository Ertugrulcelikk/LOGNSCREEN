using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGİNSCREEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiriş_Click(object sender, EventArgs e)
        { 
          string kullanıcıadı=tboxKa.Text;
          string şifre=tboxs.Text;

            if(kullanıcıadı=="ERTUĞRUL")
            { 
                if(şifre=="Ertugrul28")
                {
                  label3.Text = "Giriş Başarılı";
                        

                }
                else
                {
                    label3.Text = "Hatalı Şifre";
                }



            }
            else
            {
                label3.Text = "Kullanıcı Adı Hatalı";

            }

        }

        
       

        
    }
}

