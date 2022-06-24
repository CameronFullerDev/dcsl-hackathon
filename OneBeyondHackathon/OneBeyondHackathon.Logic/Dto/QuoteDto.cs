namespace OneBeyondHackathon.Logic.Dto
{
    public sealed class QuoteDTO
    {
        public Guid Id { get; set; }
        public string Quote { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime QuoteDate { get; set; }
    }
}
