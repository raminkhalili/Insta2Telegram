namespace Insta2Telegram
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_checkurl = new System.Windows.Forms.Button();
            this.pic_cover = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tokenbot = new System.Windows.Forms.TextBox();
            this.btn_checkbot = new System.Windows.Forms.Button();
            this.txt_addtext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_textinsta = new System.Windows.Forms.TextBox();
            this.txt_insertpost = new System.Windows.Forms.Button();
            this.txt_channelname = new System.Windows.Forms.TextBox();
            this.lbl_statusbot = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "آدرس مطلب انستاگرام :";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(146, 6);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(363, 22);
            this.txt_url.TabIndex = 1;
            this.txt_url.Click += new System.EventHandler(this.txt_url_Click);
            // 
            // btn_checkurl
            // 
            this.btn_checkurl.Location = new System.Drawing.Point(515, 5);
            this.btn_checkurl.Name = "btn_checkurl";
            this.btn_checkurl.Size = new System.Drawing.Size(75, 23);
            this.btn_checkurl.TabIndex = 2;
            this.btn_checkurl.Text = "بررسی";
            this.btn_checkurl.UseVisualStyleBackColor = true;
            this.btn_checkurl.Click += new System.EventHandler(this.btn_checkurl_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.Location = new System.Drawing.Point(340, 34);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Size = new System.Drawing.Size(250, 250);
            this.pic_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cover.TabIndex = 3;
            this.pic_cover.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "توکن ربات را وارد کنید :";
            // 
            // txt_tokenbot
            // 
            this.txt_tokenbot.Location = new System.Drawing.Point(146, 34);
            this.txt_tokenbot.Name = "txt_tokenbot";
            this.txt_tokenbot.Size = new System.Drawing.Size(188, 22);
            this.txt_tokenbot.TabIndex = 5;
            this.txt_tokenbot.Click += new System.EventHandler(this.txt_tokenbot_Click);
            this.txt_tokenbot.TextChanged += new System.EventHandler(this.txt_tokenbot_TextChanged);
            // 
            // btn_checkbot
            // 
            this.btn_checkbot.Location = new System.Drawing.Point(146, 62);
            this.btn_checkbot.Name = "btn_checkbot";
            this.btn_checkbot.Size = new System.Drawing.Size(188, 23);
            this.btn_checkbot.TabIndex = 6;
            this.btn_checkbot.Text = "بررسی ربات";
            this.btn_checkbot.UseVisualStyleBackColor = true;
            this.btn_checkbot.Click += new System.EventHandler(this.btn_checkbot_Click);
            // 
            // txt_addtext
            // 
            this.txt_addtext.Location = new System.Drawing.Point(146, 144);
            this.txt_addtext.Multiline = true;
            this.txt_addtext.Name = "txt_addtext";
            this.txt_addtext.Size = new System.Drawing.Size(188, 65);
            this.txt_addtext.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "افزودن متن هنگام درج :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "متن مطلب انستاگرام :";
            // 
            // txt_textinsta
            // 
            this.txt_textinsta.Location = new System.Drawing.Point(146, 215);
            this.txt_textinsta.Multiline = true;
            this.txt_textinsta.Name = "txt_textinsta";
            this.txt_textinsta.Size = new System.Drawing.Size(188, 69);
            this.txt_textinsta.TabIndex = 11;
            // 
            // txt_insertpost
            // 
            this.txt_insertpost.Location = new System.Drawing.Point(15, 258);
            this.txt_insertpost.Name = "txt_insertpost";
            this.txt_insertpost.Size = new System.Drawing.Size(125, 23);
            this.txt_insertpost.TabIndex = 12;
            this.txt_insertpost.Text = "درج مطلب در کانال";
            this.txt_insertpost.UseVisualStyleBackColor = true;
            this.txt_insertpost.Click += new System.EventHandler(this.txt_insertpost_Click);
            // 
            // txt_channelname
            // 
            this.txt_channelname.Location = new System.Drawing.Point(146, 116);
            this.txt_channelname.Name = "txt_channelname";
            this.txt_channelname.Size = new System.Drawing.Size(188, 22);
            this.txt_channelname.TabIndex = 13;
            // 
            // lbl_statusbot
            // 
            this.lbl_statusbot.AutoSize = true;
            this.lbl_statusbot.Location = new System.Drawing.Point(12, 88);
            this.lbl_statusbot.Name = "lbl_statusbot";
            this.lbl_statusbot.Size = new System.Drawing.Size(67, 14);
            this.lbl_statusbot.TabIndex = 14;
            this.lbl_statusbot.Text = "وضعیت ربات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "نام کاربری کانال :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "برنامه نویسی و رباتیک در ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(154, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 14);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Raminkhalili.blog.ir";
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(508, 294);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 18;
            this.btn_help.Text = "راهنما";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 321);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_statusbot);
            this.Controls.Add(this.txt_channelname);
            this.Controls.Add(this.txt_insertpost);
            this.Controls.Add(this.txt_textinsta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_addtext);
            this.Controls.Add(this.btn_checkbot);
            this.Controls.Add(this.txt_tokenbot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.btn_checkurl);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انستا2تلگرام";
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_checkurl;
        private System.Windows.Forms.PictureBox pic_cover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tokenbot;
        private System.Windows.Forms.Button btn_checkbot;
        private System.Windows.Forms.TextBox txt_addtext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_textinsta;
        private System.Windows.Forms.Button txt_insertpost;
        private System.Windows.Forms.TextBox txt_channelname;
        private System.Windows.Forms.Label lbl_statusbot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_help;
    }
}

