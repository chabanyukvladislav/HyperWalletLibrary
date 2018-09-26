using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using XamarinClient.Controllers;
using XamarinClient.Models;
using XamarinClient.OAuth;

namespace XamarinClient.Collections
{
    static class UserCollection
    {
        private static readonly IController<User> _controller;
        private static List<User> _collection;

        public static List<User> Collection
        {
            get => _collection;
            private set
            {
                _collection = value;
                CollectionSubject.OnNext(_collection);
            }
        }
        public static ISubject<List<User>> CollectionSubject { get; }

        static UserCollection()
        {
            OAuthController.TokenSubject.Subscribe(TokenChanged);
            CollectionSubject = new Subject<List<User>>();
            Collection = new List<User>();
            _controller = new UserController();
            LoadCollection();
        }

        private static void TokenChanged(Token value)
        {
            LoadCollection();
        }

        private static async void LoadCollection()
        {
            Collection = await _controller.GetAsync();
        }
    }
}
