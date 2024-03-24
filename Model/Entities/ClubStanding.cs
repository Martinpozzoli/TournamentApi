namespace Model.Entities
{
    public class ClubStanding
    {
        public int Id { get; set; }
        public Club Club { get; set; }
        public Standing Standing { get; set; }
        public int Points { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int MatchesPlayed { get; set; }
        public int MatchesWon { get; set; }
        public int MatchesDrawn { get; set; }
        public int MatchesLost { get; set; }
    }
}
