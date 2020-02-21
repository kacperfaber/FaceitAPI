using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class Authorization : IAuthorizable
    {
        public const string Header = "Authorization";
        
        public IBearerValueGenerator BearerValueGenerator;

        public Authorization(string apiAccessToken, IBearerValueGenerator bearerValueGenerator = null)
        {
            AccessToken = apiAccessToken;
            BearerValueGenerator = bearerValueGenerator ?? new BearerValueGenerator();
        }

        public string AccessToken { get; set; }

        public string GetBearer()
        {
            return BearerValueGenerator.GenerateValue(AccessToken);
        }

        public string GetHeaderName()
        {
            return Header;
        }
    }
}