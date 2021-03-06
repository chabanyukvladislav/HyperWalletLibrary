﻿using System.Collections.Generic;
using System.Reactive.Subjects;
using XamarinClient.Controllers;
using XamarinClient.Models;

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
            CollectionSubject = new Subject<List<User>>();
            Collection = new List<User>();
            _controller = new UserController();
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
