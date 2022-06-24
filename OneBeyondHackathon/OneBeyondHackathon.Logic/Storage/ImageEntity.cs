namespace OneBeyondHackathon.Logic.Storage
{
    public sealed class ImageEntity
    {
        public Guid Id { get; set; }
        public string Url { get; init; } = null!;
    }
}
