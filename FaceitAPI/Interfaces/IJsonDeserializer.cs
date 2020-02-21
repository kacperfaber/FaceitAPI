namespace FaceitAPI.Interfaces
{
    public interface IJsonDeserializer
    {
        T Deserialize<T>(string json);
    }
}