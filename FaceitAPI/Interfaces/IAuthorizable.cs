namespace FaceitAPI.Interfaces
{
    public interface IAuthorizable
    {
        string GetBearer();

        string GetHeaderName();
    }
}