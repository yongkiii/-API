using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 오픈_API___과제
{
    internal class Shopping
    {
        //상품제목
        public string Title { get; }
        //링크
        public string Link { get; }
        //영화감독
        public string Brand { get; }
        //평점
        public int LPrice { get; }
        public int HPrice { get; }
        //썸네일
        public string Image { get; }
        
        public Shopping(string title,string link, string brand, int lprice, int hprice,string image)
        {
            Title = title;
            Link = link;
            Brand = brand;
            LPrice = lprice;
            HPrice = hprice;
            Image = image;
        }
        public override string ToString()
        {
            return Title;
        }




    }
}
