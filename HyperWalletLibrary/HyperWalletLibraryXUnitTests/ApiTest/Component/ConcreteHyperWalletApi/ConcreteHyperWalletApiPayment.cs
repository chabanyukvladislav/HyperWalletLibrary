using HyperWalletLibrary.Api;
using System.Threading.Tasks;
using HyperWalletLibrary.Components;
using System;

namespace HyperWalletLibraryXUnitTests.ApiTest.Component.ConcreteHyperWalletApi
{
    internal class ConcreteHyperWalletApiPayment : AbstractHyperWalletApi<HyperWalletLibrary.Model.Payment>
    {
        private const string Type = @"payments";
        private const string UserToken = @"";
        private const string LocalAddress = @"";

        public ConcreteHyperWalletApiPayment(IHyperWalletAccount account) : base(Type, UserToken, LocalAddress, account) { }

        public override async Task<HyperWalletLibrary.Model.Payment> PostAsync(HyperWalletLibrary.Model.Payment item)
        {
            item.ProgramToken = Account.Portal.ProgramToken;
            item.Purpose = "OTHER";
            item.Currency = "USD";
            item.ClientPaymentId = new Random().Next().ToString();
            return await base.PostAsync(item);
        }
    }
}
