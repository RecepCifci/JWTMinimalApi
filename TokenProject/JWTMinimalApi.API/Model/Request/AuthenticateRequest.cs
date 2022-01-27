namespace JWTMinimalApi.API.Model.Request
{
    public class AuthenticateRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}