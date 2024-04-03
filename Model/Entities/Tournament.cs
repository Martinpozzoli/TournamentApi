namespace TournamentApi.Entities
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string? Description { get; set; } = null;
        public List<Club> Clubs { get; set; }
        public static List<Match> Matches { get; set; }
        
    /* 
    * Si el club juega más de un torneo esta agregación no corre.
    * Debería ser una relación con tournament. 
    */
        // public static Standing Standing { get; set; }

    }
}