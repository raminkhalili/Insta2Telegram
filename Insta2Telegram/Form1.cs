using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Insta2Telegram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool type = true;//true is image - false is video
        public string image = "", video = "", caption = "";
        private void btn_checkurl_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stm = client.OpenRead(txt_url.Text);
            StreamReader str = new StreamReader(stm);
            
            string codes = str.ReadToEnd();
            str.Close();
            stm.Close();
            stm= client.OpenRead(txt_url.Text);
            str = new StreamReader(stm);
            string  line = "" ;
            

            if (codes.Contains("<meta name=\"medium\" content=\"image\" />"))
            {

                this.type = true;
                
                
            }
            else if (codes.Contains("<meta name=\"medium\" content=\"video\" />"))
            {
                this.type = false;
              
            }
            while (!str.EndOfStream)
            {
                line = str.ReadLine();
                if (line.Contains("<meta property=\"og:image\""))
                {
                    image = line;
                }
                if (line.Contains("<meta property=\"og:title\""))
                {
                    caption = line;
                }
                if(!this.type && line.Contains("<meta property=\"og:video\""))
                {
                    video = line;
                    video = video.Substring(39);
                    video = video.Trim("\" /> ".ToCharArray());
                }
            }

            image = image.Substring(39);
            image = image.Trim("\" /> ".ToCharArray());
            caption = caption.Substring(60);
            caption = caption.Trim("”\" /> ".ToCharArray());
            pic_cover.ImageLocation = image;
            txt_textinsta.Text = caption;
            str.Close();
            stm.Close();

        }

        private void btn_checkbot_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                Stream stm = client.OpenRead("https://api.telegram.org/bot" + txt_tokenbot.Text + "/getMe");
                StreamReader str = new StreamReader(stm);
                string json = str.ReadToEnd();
                Telegrambot tb = JsonConvert.DeserializeObject<Telegrambot>(json);
                if (tb.ok == false)
                {
                    lbl_statusbot.ForeColor = Color.Red;
                    lbl_statusbot.Text = " لطفاً توکن را صحیح وارد کنید.";
                    return;
                }
                else
                {
                    lbl_statusbot.ForeColor = Color.Green;
                    lbl_statusbot.Text = "نام : " + tb.result.first_name+"      " + "نام کاربری : "+ tb.result.username;
                    txt_tokenbot.ReadOnly = true;
                }
            }catch(Exception ex)
            {
                lbl_statusbot.ForeColor = Color.Red;
                lbl_statusbot.Text = " لطفاً توکن را صحیح وارد کنید.";
                return;
            }
                


        }

        private void txt_tokenbot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_url_Click(object sender, EventArgs e)
        {
            txt_url.Text = "";
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            frm_help help = new frm_help();
            help.ShowDialog();
        }

        private void txt_tokenbot_Click(object sender, EventArgs e)
        {
            txt_tokenbot.ReadOnly = false;
        }

        private void txt_insertpost_Click(object sender, EventArgs e)
        {
            if (txt_tokenbot.ReadOnly)
            {
                WebClient client = new WebClient();
                Stream stm;
                StreamReader str;
                caption = txt_textinsta.Text + txt_addtext.Text;
                caption = System.Net.WebUtility.UrlEncode(caption);
                
                if (this.type)
                {
                    //insert image

                    stm = client.OpenRead("https://api.telegram.org/bot" + txt_tokenbot.Text + "/sendPhoto?chat_id=@" + txt_channelname.Text.Trim('@') + "&photo=" + image + "&caption=" + caption);

                }
                else
                {
                    //insert video
                    
                     stm = client.OpenRead("https://api.telegram.org/bot" + txt_tokenbot.Text + "/sendVideo?chat_id=@" + txt_channelname.Text.Trim('@') + "&video=" + video + "&caption=" + caption);
                }
                str = new StreamReader(stm);
                //MessageBox.Show(str.ReadToEnd());
                str.Close();
                stm.Close();
            }
            else
            {
                MessageBox.Show("لطفاً توکن را بررسی کنید.");
            }
        }
    }
}
