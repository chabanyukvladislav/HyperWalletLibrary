using HyperWalletLibrary.Model.UserModel;
using System;
using System.Collections.Generic;

namespace HyperWalletLibrary.Model
{
    [Serializable]
    public class User: IApiModel
    {
        public string Token { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ClientUserId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public BusinessContactRoles BusinessContactRole { get; set; }
        public string BusinessName { get; set; }
        public string BusinessRegistrationCountry { get; set; }
        public string BusinessRegistrationId { get; set; }
        public string BusinessRegistrationStateProvince { get; set; }
        public string BusinessContactAddressLine1 { get; set; }
        public string BusinessContactAddressLine2 { get; set; }
        public string BusinessContactCity { get; set; }
        public string BusinessContactStateProvince { get; set; }
        public string BusinessContactCountry { get; set; }
        public string BusinessContactPostalCode { get; set; }
        public string BusinessOperatingName { get; set; }
        public BusinessTypes BusinessType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CountryOfBirth { get; set; }
        public string CountryOfNationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DriversLicenseId { get; set; }
        public string Email { get; set; }
        public string EmployerId { get; set; }
        public string FirstName { get; set; }
        public Genders Gender { get; set; }
        public string GovernmentId { get; set; }
        public GovernmentIdTypes GovernmentIdType { get; set; }
        public string Language { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MobileNumber { get; set; }
        public string PassportId { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public ProfileTypes ProfileType { get; set; }
        public string ProgramToken { get; set; }
        public string StateProvince { get; set; }
        public VerificationStatus VerificationStatus { get; set; }
        public IEnumerable<Link> Links { get; set; }
    }
}
