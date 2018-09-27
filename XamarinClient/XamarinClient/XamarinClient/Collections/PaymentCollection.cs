using System.Collections.Generic;
using System.Reactive.Subjects;
using XamarinClient.Controllers;
using XamarinClient.Models;

namespace XamarinClient.Collections
{
    static class PaymentCollection
    {
        private static readonly IController<Payment> _controller;
        private static List<Payment> _collection;

        public static List<Payment> Collection
        {
            get => _collection;
            private set
            {
                _collection = value;
                CollectionSubject.OnNext(_collection);
            }
        }
        public static ISubject<List<Payment>> CollectionSubject { get; }

        static PaymentCollection()
        {
            CollectionSubject = new Subject<List<Payment>>();
            Collection = new List<Payment>();
            _controller = new PaymentsController();
            LoadCollection();
            _controller.TokenChanged += TokenChanged;
        }

        private static void TokenChanged()
        {
            LoadCollection();
        }

        private static async void LoadCollection()
        {
            Collection = await _controller.GetAsync();
        }
    }
}
