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
        public string 单位联系人 { get; set; }
        public string 单位联系人移动电话 { get; set; }
        public string 标间数 { get; set; }
        public string 单间数 { get; set; }
        public string 入住日期 { get; set; }
        public string 离开日期 { get; set; }
    }
}