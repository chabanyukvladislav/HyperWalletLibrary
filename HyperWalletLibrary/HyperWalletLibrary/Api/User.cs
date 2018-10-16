using System.Threading.Tasks;
using HyperWalletLibrary.Components;
using HyperWalletLibrary.Model;

namespace HyperWalletLibrary.Api
{
    public class User : AbstractHyperWalletApi<Model.User>
    {
        private const string Type = @"users";
        private const string UserToken = @"";
        private const string LocalAddress = @"";

        public User(IHyperWalletAccount account) : base(Type, UserToken, LocalAddress, account) { }

        public override async Task<Model.User> PostAsync(Model.User item)
        {
            item.ProfileType = ProfileTypes.INDIVIDUAL;
            item.ProgramToken = Account.Portal.ProgramToken;
            return await base.PostAsync(item);
        }
    }
}
