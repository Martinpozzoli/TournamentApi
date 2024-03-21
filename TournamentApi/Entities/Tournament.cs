namespace TournamentApi.Entities
{
    public class Tournament
    {
        public static List<Match>? Matches { get; set; }
        public static List<Standing>? Standings { get; set; }

        public Tournament() { }
    }
}
