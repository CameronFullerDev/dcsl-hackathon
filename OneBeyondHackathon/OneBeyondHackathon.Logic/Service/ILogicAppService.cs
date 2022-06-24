namespace OneBeyondHackathon.Logic.Service
{
    public interface ILogicAppService
    {
        Task PostToSlack(string content);
    }
}
