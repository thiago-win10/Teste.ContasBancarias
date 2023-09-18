using Microsoft.IdentityModel.Tokens;

namespace ContasBancarias.Identity.Configurations
{
    public class JwtOptions
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public SigningCredentials SigninCredentials { get; set; }
        public int Expiration { get; set; }
    }
}
