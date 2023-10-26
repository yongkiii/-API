namespace 오픈_API___과제
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_search = new System.Windows.Forms.Button();
            this.tbox_query = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox_shop = new System.Windows.Forms.ListBox();
            this.pbox_image = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_url = new System.Windows.Forms.LinkLabel();
            this.tbox_title = new System.Windows.Forms.TextBox();
            this.tbox_brand = new System.Windows.Forms.TextBox();
            this.tbox_lprice = new System.Windows.Forms.TextBox();
            this.tbox_hprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_map_query = new System.Windows.Forms.TextBox();
            this.btn_map = new System.Windows.Forms.Button();
            this.lbox_locale = new System.Windows.Forms.ListBox();
            this.btn_one = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(387, 25);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 35);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbox_query
            // 
            this.tbox_query.Location = new System.Drawing.Point(106, 33);
            this.tbox_query.Name = "tbox_query";
            this.tbox_query.Size = new System.Drawing.Size(249, 21);
            this.tbox_query.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "검색 내용 : ";
            // 
            // lbox_shop
            // 
            this.lbox_shop.FormattingEnabled = true;
            this.lbox_shop.ItemHeight = 12;
            this.lbox_shop.Items.AddRange(new object[] {
            "[1]",
            "",
            "[2]",
            "",
            "[3]",
            "",
            "[4]",
            "",
            "[5]",
            "",
            "[6]",
            "",
            "[7]",
            "",
            "[8]"});
            this.lbox_shop.Location = new System.Drawing.Point(45, 263);
            this.lbox_shop.Name = "lbox_shop";
            this.lbox_shop.Size = new System.Drawing.Size(338, 196);
            this.lbox_shop.TabIndex = 3;
            this.lbox_shop.SelectedIndexChanged += new System.EventHandler(this.lbox_movie_SelectedIndexChanged);
            // 
            // pbox_image
            // 
            this.pbox_image.Location = new System.Drawing.Point(45, 71);
            this.pbox_image.Name = "pbox_image";
            this.pbox_image.Size = new System.Drawing.Size(336, 179);
            this.pbox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_image.TabIndex = 4;
            this.pbox_image.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "제목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "제조사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "링크";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "최저가";
            // 
            // lb_url
            // 
            this.lb_url.AutoSize = true;
            this.lb_url.Location = new System.Drawing.Point(472, 263);
            this.lb_url.Name = "lb_url";
            this.lb_url.Size = new System.Drawing.Size(99, 12);
            this.lb_url.TabIndex = 9;
            this.lb_url.TabStop = true;
            this.lb_url.Text = "www.naver.com";
            this.lb_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_url_LinkClicked);
            // 
            // tbox_title
            // 
            this.tbox_title.Location = new System.Drawing.Point(474, 97);
            this.tbox_title.Name = "tbox_title";
            this.tbox_title.Size = new System.Drawing.Size(145, 21);
            this.tbox_title.TabIndex = 10;
            // 
            // tbox_brand
            // 
            this.tbox_brand.Location = new System.Drawing.Point(474, 133);
            this.tbox_brand.Name = "tbox_brand";
            this.tbox_brand.Size = new System.Drawing.Size(145, 21);
            this.tbox_brand.TabIndex = 11;
            // 
            // tbox_lprice
            // 
            this.tbox_lprice.Location = new System.Drawing.Point(474, 174);
            this.tbox_lprice.Name = "tbox_lprice";
            this.tbox_lprice.Size = new System.Drawing.Size(145, 21);
            this.tbox_lprice.TabIndex = 12;
            // 
            // tbox_hprice
            // 
            this.tbox_hprice.Location = new System.Drawing.Point(474, 213);
            this.tbox_hprice.Name = "tbox_hprice";
            this.tbox_hprice.Size = new System.Drawing.Size(145, 21);
            this.tbox_hprice.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "최고가";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(660, 100);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(480, 411);
            this.webBrowser1.TabIndex = 15;
            this.webBrowser1.Url = new System.Uri("http://192.168.0.4", System.UriKind.Absolute);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(757, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "지도";
            // 
            // tb_map_query
            // 
            this.tb_map_query.Location = new System.Drawing.Point(801, 45);
            this.tb_map_query.Name = "tb_map_query";
            this.tb_map_query.Size = new System.Drawing.Size(225, 21);
            this.tb_map_query.TabIndex = 17;
            // 
            // btn_map
            // 
            this.btn_map.Location = new System.Drawing.Point(1045, 45);
            this.btn_map.Name = "btn_map";
            this.btn_map.Size = new System.Drawing.Size(94, 20);
            this.btn_map.TabIndex = 18;
            this.btn_map.Text = "검색";
            this.btn_map.UseVisualStyleBackColor = true;
            this.btn_map.Click += new System.EventHandler(this.btn_map_Click);
            // 
            // lbox_locale
            // 
            this.lbox_locale.FormattingEnabled = true;
            this.lbox_locale.ItemHeight = 12;
            this.lbox_locale.Location = new System.Drawing.Point(451, 309);
            this.lbox_locale.Name = "lbox_locale";
            this.lbox_locale.Size = new System.Drawing.Size(167, 220);
            this.lbox_locale.TabIndex = 19;
            this.lbox_locale.SelectedIndexChanged += new System.EventHandler(this.lbox_locale_SelectedIndexChanged);
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(580, 38);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(120, 21);
            this.btn_one.TabIndex = 20;
            this.btn_one.Text = "한번에 가는 버튼";
            this.btn_one.UseVisualStyleBackColor = true;
          //  this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 582);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.lbox_locale);
            this.Controls.Add(this.btn_map);
            this.Controls.Add(this.tb_map_query);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tbox_hprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbox_lprice);
            this.Controls.Add(this.tbox_brand);
            this.Controls.Add(this.tbox_title);
            this.Controls.Add(this.lb_url);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbox_image);
            this.Controls.Add(this.lbox_shop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_query);
            this.Controls.Add(this.btn_search);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbox_query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox_shop;
        private System.Windows.Forms.PictureBox pbox_image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lb_url;
        private System.Windows.Forms.TextBox tbox_title;
        private System.Windows.Forms.TextBox tbox_brand;
        private System.Windows.Forms.TextBox tbox_lprice;
        private System.Windows.Forms.TextBox tbox_hprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_map_query;
        private System.Windows.Forms.Button btn_map;
        private System.Windows.Forms.ListBox lbox_locale;
        private System.Windows.Forms.Button btn_one;
    }
}

