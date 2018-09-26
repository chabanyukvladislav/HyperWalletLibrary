using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using XamarinClient.Collections;
using XamarinClient.Models;

namespace XamarinClient.ViewModels
{
    class UsersViewModel : BaseViewModel
    {
        private ObservableCollection<User> _collection;

        public ObservableCollection<User> Users
        {
            get => _collection;
            private set
            {
                _collection = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        public UsersViewModel()
        {
            UserCollection.CollectionSubject.Where(el => el != null).Subscribe(UpdateCollection);
            Users = new ObservableCollection<User>(UserCollection.Collection);
        }

        private void UpdateCollection(List<User> value)
        {
            Users = new ObservableCollection<User>(value);
        }
    }
}
