using System.Xml.Linq;
using System;

namespace NhaSachDotNet.Entity
{
    public class HoaDon
    {
        public long Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string ward { get; set; }
        public string district { get; set; }
        public string address { get; set; }
        public bool status { get; set; }

        public User user { get; set; }
        public List<ChiTietHoaDon> listCTHD { get; set; }

        public double total { get; set; }

        public HoaDon()
        {
            listCTHD = new List<ChiTietHoaDon>();
        }
    }
}
