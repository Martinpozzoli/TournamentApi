namespace TournamentApi.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int GoalsAgaint { get; set; }
        public int GoalsFor { get; set;}
        public List<Match> Matches { get; set; }
        public List<Player> Players { get; set; }
        public Standing Standing { get; set; }
    }
}
