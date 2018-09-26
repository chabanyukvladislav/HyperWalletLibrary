using System;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinClient.Components;
using XamarinClient.OAuth;

namespace XamarinClient.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        private const string DOMAIN = "itstep1511.eu.auth0.com";
        private const string CLIENT_ID = "OxESJUZoUQoc6zZLNMGNf4ZoCTsORBoM";

        private readonly IOAuthController _oAuth;
        private readonly ITokenConverter<string> _tokenToNickConverter;
        private string _toolBarButtonText;
        private ICommand _toolBarButtonCommand;
        private string _accountText;

        public string ToolBarButtonText
        {
            get => _toolBarButtonText;
            private set
            {
                _toolBarButtonText = value;
                OnPropertyChanged(nameof(ToolBarButtonText));
            }
        }

        public string AccountText
        {
            get => _accountText;
            private set
            {
                _accountText = value;
                OnPropertyChanged(nameof(AccountText));
            }
        }

        public ICommand ToolBarButtonCommand
        {
            get => _toolBarButtonCommand;
            private set
            {
                _toolBarButtonCommand = value;
                OnPropertyChanged(nameof(ToolBarButtonCommand));
            }
        }

        public BaseViewModel()
        {
            _tokenToNickConverter = new TokenToNickConverter(string.IsNullOrEmpty(OAuthController.IdToken) ? null : OAuthController.IdToken);
            AccountText = string.IsNullOrEmpty(OAuthController.IdToken) ? "" : _tokenToNickConverter.Convert();
            ToolBarButtonText = string.IsNullOrEmpty(OAuthController.IdToken) ? "LogIn" : "LogOut";
            ToolBarButtonCommand = string.IsNullOrEmpty(OAuthController.IdToken) ? new Command(ExecuteToolBarLogin) : new Command(ExecuteToolBarLogout);
            _oAuth = new OAuthController(DOMAIN, CLIENT_ID);
            OAuthController.IdTokenSubject.Where(el => string.IsNullOrEmpty(OAuthController.IdToken)).Subscribe(OnTokenClear);
            OAuthController.IdTokenSubject.Where(el => !string.IsNullOrEmpty(OAuthController.IdToken)).Subscribe(OnTokenSet);
        }

        private void ExecuteToolBarLogin()
        {
            _oAuth.Login();
        }

        private void ExecuteToolBarLogout()
        {
            _oAuth.Logout();
        }

        private void OnTokenClear(string token)
        {
            AccountText = null;
            ToolBarButtonText = "LogIn";
            ToolBarButtonCommand = new Command(ExecuteToolBarLogin);
        }

        private void OnTokenSet(string token)
        {
            _tokenToNickConverter.Content = token;
            AccountText = _tokenToNickConverter.Convert();
            ToolBarButtonText = "LogOut";
            ToolBarButtonCommand = new Command(ExecuteToolBarLogout);
        }

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
