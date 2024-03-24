namespace Model.Entities
{
    public class Tournament
    {
        // add capacity prop
        public int Id { get; set; }
        public string Name { get; set; }
        public Standing Standing { get; set; }
        public List<Match> Matches { get; set; }
    }
}
