namespace TournamentApi.DTO
{
    public class ClubResponse
    {
        public string Name { get; set; }
        public string ShortName { get; set; }

        public List<ClubTournamentStanding>? TournamentStandings { get; set; }
    }

    public class ClubTournamentStanding // club standing on tournaments
    {
        public string TournamentName { get; set; }
        public int Position { get; set; }
    }
}
