using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class BearerValueGenerator : IBearerValueGenerator
    {
        public static readonly string Template = "Bearer {token}"; 
        
        public string GenerateValue(string token)
        {
            return Template.Replace("{token}", token);
        }
    }
}