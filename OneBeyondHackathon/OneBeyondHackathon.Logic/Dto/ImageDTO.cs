namespace OneBeyondHackathon.Logic.Dto
{
    public sealed record ImageDTO
    {
        public Guid Id { get; set; }
        public string Url { get; init; } = null!;
    }
}
