using System.Threading.Tasks;
using HyperWalletLibrary.Components;
using HyperWalletLibrary.Model;

namespace HyperWalletLibrary.Api
{
    public class User : AbstractHyperWalletApi<Model.User>
    {
        private const string USER_TOKEN = @"";
        private const string LOCAL_ADDRESS = @"";

        public User(IHyperWalletAccount account) : base(USER_TOKEN, LOCAL_ADDRESS, account) { }

        public override async Task<Response<Model.User>> GetAsync()
        {
            return await base.GetAsync();
        }

        public override async Task<Model.User> GetAsync(string token)
        {
            return await base.GetAsync(token);
        }

        public override async Task<Model.User> PostAsync(Model.User item)
        {
            item.ProfileType = ProfileTypes.INDIVIDUAL;
            item.ProgramToken = _account.Portal.ProgramToken;
            return await base.PostAsync(item);
        }

        public override async Task<Model.User> PutAsync(string token, Model.User item)
        {
            return await base.PutAsync(token, item);
        }
    }
}
