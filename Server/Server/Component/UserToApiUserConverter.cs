using HyperWalletLibrary.Model;

namespace Server.Component
{
    public class UserToApiUserConverter : IUserConverter<User>
    {
        public Database.Model.User Content { get; set; }

        public UserToApiUserConverter(Database.Model.User user = null)
        {
            Content = user;
        }

        public User Convert()
        {
            User apiUser = new User
            {
                Token = Content.Token,
                ClientUserId = Content.Id,
                AddressLine1 = Content.AddressLine1,
                City = Content.City,
                Country = Content.Country,
                Email = Content.Email,
                FirstName = Content.FirstName,
                LastName = Content.LastName,
                MiddleName = Content.MiddleName,
                PhoneNumber = Content.PhoneNumber,
                PostalCode = Content.PostalCode,
                ProfileType = Content.ProfileType,
                ProgramToken = Content.ProgramToken,
                StateProvince = Content.StateProvince
            };
            return apiUser;
        }
    }
}
