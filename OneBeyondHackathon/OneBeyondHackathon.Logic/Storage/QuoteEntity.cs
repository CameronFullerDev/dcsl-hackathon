using System.ComponentModel.DataAnnotations;

namespace OneBeyondHackathon.Logic.Storage
{
    public sealed class QuoteEntity
    {
        public Guid Id { get; set; }

        [MaxLength(1000)]
        public string Quote { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Author { get; set; } = string.Empty;

        public DateTime QuoteDate { get; set; }
    }
}
