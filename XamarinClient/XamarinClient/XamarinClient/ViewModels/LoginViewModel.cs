using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinClient.ViewModels
{
    class LoginViewModel
    {
        public string Id { get; set; }
        public string Password { get; set; }

        public ICommand Login { get; }

        public LoginViewModel()
        {
            Login = new Command(ExecuteLogin);
        }

        private void ExecuteLogin()
        {
            
        }
    }
}
