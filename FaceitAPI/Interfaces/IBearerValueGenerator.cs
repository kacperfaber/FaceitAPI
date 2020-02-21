namespace FaceitAPI.Interfaces
{
    public interface IBearerValueGenerator
    {
        string GenerateValue(string token);
    }
}