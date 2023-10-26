namespace 오픈_API___과제
{
    internal class Locale
    {
        public Locale(string pname, double lng, double lat)
        {
            Pname = pname;
            Lng = lng;
            Lat = lat;
        }

        public string Pname { get; }
        public double Lng { get; }
        public double Lat { get; }

        public override string ToString()
        {
            return Pname;
        }
    }
}