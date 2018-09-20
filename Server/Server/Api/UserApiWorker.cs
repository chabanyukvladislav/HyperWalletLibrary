using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Server.Database.Model;
using Server.Component;

namespace Server.Api
{
    public class UserApiWorker : IApiWorker<User>
    {
        private readonly HyperWalletLibrary.Api.User _api;
        private readonly UserToApiUserConverter _userToApiUser;
        private readonly ResponseApiUserToListUserConverter _responseApiUserToListUser;

        public UserApiWorker()
        {
            _api = new HyperWalletLibrary.Api.User(Account.HyperWalletAccount);
            _userToApiUser = new UserToApiUserConverter();
            _responseApiUserToListUser = new ResponseApiUserToListUserConverter();
        }

        public async Task<List<User>> GetAsync()
        {
            try
            {
                HyperWalletLibrary.Model.Response<HyperWalletLibrary.Model.User> response = await _api.GetAsync();
                _responseApiUserToListUser.Content = response;
                List<User> list = _responseApiUserToListUser.Convert();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<User> GetAsync(string token)
        {
            try
            {
                HyperWalletLibrary.Model.User response = await _api.GetAsync(token);
                User user = new User(response);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<User> PostAsync(User item)
        {
            try
            {
                _userToApiUser.Content = item;
                HyperWalletLibrary.Model.User newItem = _userToApiUser.Convert();
                HyperWalletLibrary.Model.User response = await _api.PostAsync(newItem);
                User user = new User(response);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<User> PutAsync(string token, User item)
        {
            try
            {
                _userToApiUser.Content = item;
                HyperWalletLibrary.Model.User newItem = _userToApiUser.Convert();
                HyperWalletLibrary.Model.User response = await _api.PutAsync(token, newItem);
                User user = new User(response);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
