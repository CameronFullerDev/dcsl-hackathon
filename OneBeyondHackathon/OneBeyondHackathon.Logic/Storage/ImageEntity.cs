using System.ComponentModel.DataAnnotations;

namespace OneBeyondHackathon.Logic.Storage
{
    public sealed class ImageEntity
    {
        public Guid Id { get; set; }

        [MaxLength(1000)]
        public string Url { get; init; } = null!;
    }
}
