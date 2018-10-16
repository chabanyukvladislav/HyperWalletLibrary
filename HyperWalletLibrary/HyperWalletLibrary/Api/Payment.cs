using HyperWalletLibrary.Components;
using HyperWalletLibrary.Model;
using System;
using System.Threading.Tasks;

namespace HyperWalletLibrary.Api
{
    public class Payment: AbstractHyperWalletApi<Model.Payment>
    {
        private const string TYPE = @"payments";
        private const string USER_TOKEN = @"";
        private const string LOCAL_ADDRESS = @"";

        public Payment(IHyperWalletAccount account) : base(TYPE, USER_TOKEN, LOCAL_ADDRESS, account) { }

        public override async Task<Response<Model.Payment>> GetAsync()
        {
            return await base.GetAsync();
        }

        public override async Task<Model.Payment> GetAsync(string token)
        {
            return await base.GetAsync(token);
        }

        public override async Task<Model.Payment> PostAsync(Model.Payment item)
        {
            item.ProgramToken = _account.Portal.ProgramToken;
            item.Purpose = "OTHER";
            item.Currency = "USD";
            item.ClientPaymentId = new Random().Next().ToString();
            return await base.PostAsync(item);
        }
    }
}
