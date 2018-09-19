using System.Security;
using System.Threading.Tasks;
using HyperWalletLibrary.Model;

namespace HyperWalletLibrary.Api
{
    public class User : AbstractHyperWalletApi<Model.User>
    {
        private const string USER_TOKEN = @"";
        private const string LOCAL_ADDRESS = @"";

        public User(string programToken, string username, SecureString password) : base(USER_TOKEN, LOCAL_ADDRESS, programToken, username, password) { }

        public override async Task<Response<Model.User>> GetAsync(string token = "")
        {
            return await base.GetAsync(token);
        }

        public override async Task<Response<Model.User>> PostAsync(Model.User item)
        {
            return await base.PostAsync(item);
        }

        public override async Task<Response<Model.User>> PutAsync(string token, Model.User item)
        {
            return await base.PutAsync(token, item);
        }
    }
}
