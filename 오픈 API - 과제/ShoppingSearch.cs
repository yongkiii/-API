using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 오픈_API___과제
{
    internal class ShoppingSearch
    {
        public static List<Shopping> Search(string query, int start, int display, string sort)
        {
            string url = "https://openapi.naver.com/v1/search/shop.xml";

            string query_str = string.Format("{0}?query={1}&start={2}&display={3}&sort={4}",url,query,start,display,sort);
            WebRequest request = WebRequest.Create(query_str);
            request.Headers.Add("X-Naver-Client-Id", "MWZFg0OBjkkdV9qhjVXN");
            request.Headers.Add("X-Naver-Client-Secret", "w_n6N1E2UP");
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(stream);
            XmlNode rssnode = xdoc.SelectSingleNode("rss");
            XmlNode chnode = rssnode.SelectSingleNode("channel");
            XmlNode disnode = chnode.SelectSingleNode("display");
           // XmlNode sortnode = xdoc.SelectSingleNode("sort");
            int rd = int.Parse(disnode.InnerText);
            XmlNodeList item_nodes = chnode.SelectNodes("item");
            List<Shopping> shop_list = new List<Shopping>();
            foreach(XmlNode node in item_nodes)
            {
                string title = node.SelectSingleNode("title").InnerText;
                string link = node.SelectSingleNode("link").InnerText;
                string brand = node.SelectSingleNode("brand").InnerText;
                
                int lprice = int.Parse(node.SelectSingleNode("lprice").InnerText);

                int hprice = 0;
                int.TryParse(node.SelectSingleNode("hprice").InnerText,out hprice);
                string image = node.SelectSingleNode("image").InnerText;
                Shopping shop = new Shopping(title, link, brand, lprice, hprice,image);
                shop_list.Add(shop);

            }
            return shop_list;

        }
        
    }
}
