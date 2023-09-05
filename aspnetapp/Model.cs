namespace aspnetapp
{
    public class Counter
    {
        public int id { get; set; }
        public int count { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class Signup
    {
        public int id { get; set; }
        public string 单位名 { get; set; }
        public bool 会员 { get; set; }
        public string 单位联系人 { get; set; }
        public string 单位联系人移动电话 { get; set; }
    }
}