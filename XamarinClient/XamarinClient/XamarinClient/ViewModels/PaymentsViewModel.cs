using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinClient.Collections;
using XamarinClient.Models;
using XamarinClient.Views;

namespace XamarinClient.ViewModels
{
    class PaymentsViewModel : BaseViewModel
    {
        private ObservableCollection<Payment> _collection;

        public ObservableCollection<Payment> Payments
        {
            get => _collection;
            private set
            {
                _collection = value;
                OnPropertyChanged(nameof(Payments));
            }
        }

        public ICommand Create { get; }

        public PaymentsViewModel() : base()
        {
            Create = new Command(ExecuteCreate);
            PaymentCollection.CollectionSubject.Where(el => el != null).Subscribe(UpdateCollection);
            Payments = new ObservableCollection<Payment>(PaymentCollection.Collection);
        }

        private void UpdateCollection(List<Payment> value)
        {
            Payments = new ObservableCollection<Payment>(value);
        }

        private async void ExecuteCreate()
        {
            await ((NavigationPage) ((TabbedPage) Application.Current.MainPage).Children.FirstOrDefault(el =>
                el.Title == "Payments")).PushAsync(new CreatePaymentPage());
        }
    }
}
