using HyperWalletLibrary.Model.BankAccountModel;
using System;
using System.Collections.Generic;

namespace HyperWalletLibrary.Model
{
    [Serializable]
    class BankAccount: IApiModel
    {
        public string Token { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public Types Type { get; set; }
        public string TransferMethodCountry { get; set; }
        public string TransferMethodCurrency { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string BankAccountId { get; set; }
        public string BankAccountPurpose { get; set; }
        public BankAccountRelationships BankAccountRelationship { get; set; }
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string BranchAddressLine1 { get; set; }
        public string BranchAddressLine2 { get; set; }
        public string BranchCity { get; set; }
        public string BranchCountry { get; set; }
        public string BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchPostalCode { get; set; }
        public string BranchStateProvince { get; set; }
        public BusinessContactRoles BusinessContactRole { get; set; }
        public string BusinessName { get; set; }
        public string BusinessRegistrationCountry { get; set; }
        public string BusinessRegistrationId { get; set; }
        public string BusinessRegistrationStateProvince { get; set; }
        public BusinessTypes BusinessType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CountryOfBirth { get; set; }
        public string CountryOfNationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DriversLicenseId { get; set; }
        public string EmployerId { get; set; }
        public string FirstName { get; set; }
        public Genders Gender { get; set; }
        public string GovernmentId { get; set; }
        public GovernmentIdTypes GovernmentIdType { get; set; }
        public string IntermediaryBankAccountId { get; set; }
        public string IntermediaryBankAddressLine1 { get; set; }
        public string IntermediaryBankAddressLine2 { get; set; }
        public string IntermediaryBankCity { get; set; }
        public string IntermediaryBankCountry { get; set; }
        public string IntermediaryBankId { get; set; }
        public string IntermediaryBankName { get; set; }
        public string IntermediaryBankPostalCode { get; set; }
        public string IntermediaryBankStateProvince { get; set; }
        public bool IsDefaultTransferMethod { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MobileNumber { get; set; }
        public string PassportId { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public ProfileTypes ProfileType { get; set; }
        public string StateProvince { get; set; }
        public string WireInstructions { get; set; }
        public IEnumerable<Link> Links { get; set; }
    }
}
