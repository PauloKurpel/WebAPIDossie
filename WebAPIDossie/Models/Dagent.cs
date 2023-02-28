namespace WebAPIDossie.Models
{
    public class Dagent : Entity
    {
        public int logid { get; set; }
        public DateTime row_date { get; set; }
        public int ringcalls { get; set; }
        public int acdcalls { get; set; }
        public int acdtime { get; set; }
        public int acwtime { get; set; }
        public int holdtime { get; set; }
    }
}
