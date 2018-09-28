using System;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinClient.Controllers;
using XamarinClient.Models;
using XamarinClient.OAuth;

namespace XamarinClient.ViewModels
{
    class CreatePaymentPageViewModel : BaseViewModel
    {
        private readonly IController<Payment> _controller;
        private Payment _payment;
        private bool _canCreate;

        public Payment Payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged(nameof(Payment));
            }
        }
        public bool CanCreate
        {
            get => _canCreate;
            set
            {
                _canCreate = value;
                OnPropertyChanged(nameof(CanCreate));
            }
        }

        public ICommand Create { get; }

        public CreatePaymentPageViewModel()
        {
            Payment = new Payment();
            CanCreate = OAuthController.Token != null;
            OAuthController.TokenSubject.Subscribe(TokenChanged);
            Create = new Command(ExecuteCreate);
            _controller = new PaymentsController();
        }

        private void TokenChanged(Token value)
        {
            CanCreate = value != null;
        }

        private async void ExecuteCreate()
        {
            if (string.IsNullOrWhiteSpace(Payment.DestinationToken))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Can not create payment", "Ok");
                return;
            }
            bool result = await _controller.PostAsync(Payment);
            if (!result)
                await Application.Current.MainPage.DisplayAlert("Error", "Can not create payment", "Ok");
            else
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Created", "Ok");
                await ((NavigationPage)((TabbedPage)Application.Current.MainPage).Children.FirstOrDefault(el =>
                    el.Title == "Payments")).PopAsync();
            }
        }
    }
}
