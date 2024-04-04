namespace TournamentApi.Entities
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string? Description { get; set; } = null;
        public List<Club> Clubs { get; set; }
        public static List<Match> Matches { get; set; }
        public static Standing Standing { get; set; }

    }
}