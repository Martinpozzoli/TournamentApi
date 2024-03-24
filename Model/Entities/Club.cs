namespace Model.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public DateTime FoundationDate { get; set; }
        public List<Player> Players { get; set; }
        public List<Match> Matches { get; set; }
    }
}
