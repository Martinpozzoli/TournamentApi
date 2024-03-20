namespace Model.Entities
{
    public class Tournament
    {
        public Standing Standing { get; set; }
        public List<Match> Matches { get; set; }
    }
}
