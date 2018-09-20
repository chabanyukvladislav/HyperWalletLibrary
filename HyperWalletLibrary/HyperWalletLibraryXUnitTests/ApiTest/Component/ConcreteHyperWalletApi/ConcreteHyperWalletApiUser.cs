using HyperWalletLibrary.Api;
using HyperWalletLibrary.Model;
using System.Security;
using System.Threading.Tasks;

namespace HyperWalletLibraryXUnitTests.ApiTest.Component.ConcreteHyperWalletApi
{
    class ConcreteHyperWalletApiUser : AbstractHyperWalletApi<HyperWalletLibrary.Model.User>
    {
        private const string USER_TOKEN = @"";
        private const string LOCAL_ADDRESS = @"";

        public ConcreteHyperWalletApiUser(string programToken, string username, SecureString password) : base(USER_TOKEN, LOCAL_ADDRESS, programToken, username, password) { }

        public override async Task<Response<HyperWalletLibrary.Model.User>> GetAsync()
        {
            return await base.GetAsync();
        }

        public override async Task<HyperWalletLibrary.Model.User> GetAsync(string token = "")
        {
            return await base.GetAsync(token);
        }

        public override async Task<HyperWalletLibrary.Model.User> PostAsync(HyperWalletLibrary.Model.User item)
        {
            return await base.PostAsync(item);
        }

        public override async Task<HyperWalletLibrary.Model.User> PutAsync(string token, HyperWalletLibrary.Model.User item)
        {
            return await base.PutAsync(token, item);
        }
    }
}
