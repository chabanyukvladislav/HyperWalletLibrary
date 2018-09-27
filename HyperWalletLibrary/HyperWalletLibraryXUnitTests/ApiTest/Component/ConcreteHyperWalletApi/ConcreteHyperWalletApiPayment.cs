using HyperWalletLibrary.Api;
using HyperWalletLibrary.Model;
using System.Threading.Tasks;
using HyperWalletLibrary.Components;

namespace HyperWalletLibraryXUnitTests.ApiTest.Component.ConcreteHyperWalletApi
{
    class ConcreteHyperWalletApiPayment : AbstractHyperWalletApi<HyperWalletLibrary.Model.Payment>
    {
        private const string TYPE = @"payments";
        private const string USER_TOKEN = @"";
        private const string LOCAL_ADDRESS = @"";

        public ConcreteHyperWalletApiPayment(IHyperWalletAccount account) : base(TYPE, USER_TOKEN, LOCAL_ADDRESS, account) { }

        public override async Task<Response<HyperWalletLibrary.Model.Payment>> GetAsync()
        {
            return await base.GetAsync();
        }

        public override async Task<HyperWalletLibrary.Model.Payment> GetAsync(string token = "")
        {
            return await base.GetAsync(token);
        }

        public override async Task<HyperWalletLibrary.Model.Payment> PostAsync(HyperWalletLibrary.Model.Payment item)
        {
            item.ProgramToken = _account.Portal.ProgramToken;
            item.Purpose = "OTHER";
            return await base.PostAsync(item);
        }
    }
}
