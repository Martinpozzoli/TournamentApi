namespace Model.Entities
{
    public class Standing
    {
        public int Id { get; set; }
        public List<ClubStanding> ClubStandings { get; set; }
        // public Tournament Tournament { get; set; }
    }
}
