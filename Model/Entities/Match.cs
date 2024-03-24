namespace Model.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Tournament Tournament { get; set; }
        public Stadium Stadium { get; set; }
        public Club Club1 { get; set; }
        public Club Club2 { get; set; }
        public int Club1Score { get; set; }
        public int Club2Score { get; set; }
    }
}
