namespace TournamentApi.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }
        public int Position { get; set; }
        public DateOnly? BirthDay { get; set; }
        public Club Club { get; set; }
    }
}
