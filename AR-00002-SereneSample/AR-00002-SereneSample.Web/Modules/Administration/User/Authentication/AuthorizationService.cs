namespace AR_00002_SereneSample.Administration
{
    using Serenity;
    using Serenity.Abstractions;

    public class AuthorizationService : IAuthorizationService
    {
        public bool IsLoggedIn
        {
            get { return !string.IsNullOrEmpty(Username); }
        }

        public string Username
        {
            get { return WebSecurityHelper.HttpContextUsername; }
        }
    }
}