using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinClient.ViewModels
{
    class RegisterViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string StateProvince { get; set; }

        public ICommand Register { get; set; }

        public RegisterViewModel()
        {
            Register = new Command(ExecuteRegister);
        }

        private void ExecuteRegister()
        {

        }
    }
}
