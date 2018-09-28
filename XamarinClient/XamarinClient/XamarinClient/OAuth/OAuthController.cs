using System.Reactive.Subjects;
using Auth0.OidcClient;
using IdentityModel.OidcClient;
using Xamarin.Forms;
using XamarinClient.Models;

namespace XamarinClient.OAuth
{
    class OAuthController : IOAuthController
    {
        private readonly IAuth0Client _client;
        private static string _idToken;
        private static Token _token;

        public static string IdToken
        {
            get => _idToken;
            private set
            {
                _idToken = value;
                IdTokenSubject.OnNext(_idToken);
            }
        }
        public static Token Token
        {
            get => _token;
            private set
            {
                _token = value;
                TokenSubject.OnNext(_token);
            }
        }
        public static ISubject<string> IdTokenSubject { get; }
        public static ISubject<Token> TokenSubject { get; }

        static OAuthController()
        {
            IdTokenSubject = new Subject<string>();
            TokenSubject = new Subject<Token>();
        }
        public OAuthController(string domain, string clientId)
        {
            _client = new Auth0Client(new Auth0ClientOptions() { Domain = domain, ClientId = clientId });
        }

        public async void Login()
        {
            LoginResult result = await _client.LoginAsync();
            if (result.IsError)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Can not login", "Ok");
                return;
            }
            LoginController controller = new LoginController(result.IdentityToken);
            Token = await controller.LoginAsync();
            if (Token == null)
            {
                await _client.LogoutAsync();
                await Application.Current.MainPage.DisplayAlert("Error", "Can not get api token", "Ok");
                return;
            }
            IdToken = result.IdentityToken;
        }

        public async void Logout()
        {
            await _client.LogoutAsync();
            IdToken = null;
            Token = null;
        }
    }
}
