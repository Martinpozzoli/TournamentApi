namespace Model.Entities
{
    public class Standing
    {
        public int Id { get; set; }
        public List<Club> Clubs { get; set; }
        public Tournament Tournament { get; set; }
    }
}
