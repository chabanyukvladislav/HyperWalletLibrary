using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using XamarinClient.Controllers;
using XamarinClient.Models;

namespace XamarinClient.Collections
{
    static class PaymentCollection
    {
        private const string SIGNAL_R_ADDRESS = "http://localhost:11801/notification";

        private static readonly IController<Payment> _controller;
        private static List<Payment> _collection;
        private static HubConnection _hub;

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
            _hub = new HubConnectionBuilder().WithUrl(SIGNAL_R_ADDRESS).Build();
            StartHub();
        }

        private static async void StartHub()
        {
            try
            {
                await _hub.StartAsync();
                _hub.On<Payment>("PaymentPost", (value) =>
                {
                    Collection.Add(value);
                    CollectionSubject.OnNext(_collection);
                });
            }
            catch (Exception )
            {
                StartHub();
            }
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
