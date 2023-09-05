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
        public string unitName { get; set; }
        public bool isVIP { get; set; }
        public string UnitMainPerson { get; set; }
        public string UnitMainPersonPhone { get; set; }
    }
}