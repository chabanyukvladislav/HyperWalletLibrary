using HyperWalletLibrary.Api;
using HyperWalletLibrary.Model;
using System.Threading.Tasks;
using HyperWalletLibrary.Components;

namespace HyperWalletLibraryXUnitTests.ApiTest.Component.ConcreteHyperWalletApi
{
    class ConcreteHyperWalletApiUser : AbstractHyperWalletApi<HyperWalletLibrary.Model.User>
    {
        private const string USER_TOKEN = @"";
        private const string LOCAL_ADDRESS = @"";

        public ConcreteHyperWalletApiUser(IHyperWalletAccount account) : base(USER_TOKEN, LOCAL_ADDRESS, account) { }

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
