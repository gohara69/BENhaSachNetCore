namespace NhaSachDotNet.Entity
{
    public class User
    {
        public long Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string ward { get; set; }
        public string district { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string token { get; set; }
        public DateTime tokenExpired { get; set; }
        public List<HoaDon> listHoaDon { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public User()
        {
            listHoaDon = new List<HoaDon>();
        }
    }
}
