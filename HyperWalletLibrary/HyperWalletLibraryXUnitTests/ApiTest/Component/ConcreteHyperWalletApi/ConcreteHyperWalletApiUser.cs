using HyperWalletLibrary.Api;
using HyperWalletLibrary.Components;

namespace HyperWalletLibraryXUnitTests.ApiTest.Component.ConcreteHyperWalletApi
{
    internal class ConcreteHyperWalletApiUser : AbstractHyperWalletApi<HyperWalletLibrary.Model.User>
    {
        private const string Type = @"users";
        private const string UserToken = @"";
        private const string LocalAddress = @"";

        public ConcreteHyperWalletApiUser(IHyperWalletAccount account) : base(Type, UserToken, LocalAddress, account) { }
    }
}
