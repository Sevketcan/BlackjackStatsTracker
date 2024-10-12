namespace BlackjackStatsTracker.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Suit { get; set; }  // Maça, Karo, Sinek, Kupa gibi kart türleri
        public string Value { get; set; }  // 2-10, J, Q, K, A gibi değerler
        public DateTime DatePlayed { get; set; }
    }
}
