using HyperWalletLibrary.Components;
using System;
using System.Threading.Tasks;

namespace HyperWalletLibrary.Api
{
    public class Payment: AbstractHyperWalletApi<Model.Payment>
    {
        private const string Type = @"payments";
        private const string UserToken = @"";
        private const string LocalAddress = @"";

        public Payment(IHyperWalletAccount account) : base(Type, UserToken, LocalAddress, account) { }

        public override async Task<Model.Payment> PostAsync(Model.Payment item)
        {
            item.ProgramToken = Account.Portal.ProgramToken;
            item.Purpose = "OTHER";
            item.Currency = "USD";
            item.ClientPaymentId = new Random().Next().ToString();
            return await base.PostAsync(item);
        }
    }
}
