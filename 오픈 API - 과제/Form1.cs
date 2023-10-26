using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 오픈_API___과제
{
    public partial class Form1 : Form
    {
        List<Shopping> shoplist = new List<Shopping>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lbox_shop.Items.Clear();
            shoplist = ShoppingSearch.Search(tbox_query.Text, 1, 10, "sim");

            foreach (Shopping shop in shoplist)
            {
                lbox_shop.Items.Add(shop);
                lbox_shop.GetItemText(shop);



            }



        }

        private void lbox_movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbox_shop.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            Shopping shop = shoplist[index];

            tbox_hprice.Text = shop.HPrice.ToString();
            tbox_lprice.Text = shop.LPrice.ToString();
            tbox_brand.Text = shop.Brand;
            tbox_title.Text = shop.Title;
            lb_url.Text = shop.Link;
            pbox_image.ImageLocation = shop.Image;
            //pbox_image.load

        }

        private void lb_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = lb_url.Text;
            
            Browser bw = new Browser(Process.Start(url));
            bw.Show();
        }

        private void btn_map_Click(object sender, EventArgs e)
        {
            string query = tb_map_query.Text;
            string url = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string query_str = string.Format("{0}?query={1}", url, query);
            WebRequest request = WebRequest.Create(query_str);
            request.Headers.Add("Authorization", "KakaoAK b213f2ae3883be6e978769d84557986f");
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string content = reader.ReadToEnd();
            //Console.WriteLine(content);

            JavaScriptSerializer jss = new JavaScriptSerializer();
            dynamic d = jss.Deserialize<dynamic>(content);
            dynamic[] ddoc = d["documents"];
            Locale local = null;
            HtmlDocument hdoc = webBrowser1.Document;
            object[] objs = new object[2];

            foreach (dynamic elem in ddoc)
            {
                string pname = elem["place_name"];
                double lng = double.Parse(elem["x"]);
                double lat = double.Parse(elem["y"]);
                local = new Locale(pname, lng, lat);
                lbox_locale.Items.Add(local);
                objs[0] = local.Lat;
                objs[1] = local.Lng;
                hdoc.InvokeScript("setCenter", objs);
                hdoc.InvokeScript("addMarker", objs);


            }
            hdoc.InvokeScript("setPlace ", new object[] { local.Pname });
            hdoc.InvokeScript("showMarkers", null);










        }

        private void lbox_locale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_locale.SelectedIndex == -1)
            {
                return;
            }
            Locale local = lbox_locale.SelectedItem as Locale;
            HtmlDocument hdoc1 = webBrowser1.Document;
            object[] objs = new object[] { local.Lng ,local.Lat };
            hdoc1.InvokeScript("setCenter", objs);
          //  hdoc.InvokeScript("setPlace ", new object[] { local.Pname });
        }

       
    }

}
