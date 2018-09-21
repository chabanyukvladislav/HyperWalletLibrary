﻿using Server.Component;

namespace Server.Database.Model
{
    public class User : IModel
    {
        public string Token { get; set; }
        public string Id { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string StateProvince { get; set; }

        public User() { }
        public User(HyperWalletLibrary.Model.User apiUser)
        {
            StringToHashConverter converter = new StringToHashConverter(apiUser.Email);
            Token = apiUser.Token;
            Id = apiUser.ClientUserId;
            AddressLine1 = apiUser.AddressLine1;
            City = apiUser.City;
            Country = apiUser.Country;
            Email = converter.Convert();
            FirstName = apiUser.FirstName;
            LastName = apiUser.LastName;
            MiddleName = apiUser.MiddleName;
            PhoneNumber = apiUser.PhoneNumber;
            PostalCode = apiUser.PostalCode;
            StateProvince = apiUser.StateProvince;
        }
    }
}
