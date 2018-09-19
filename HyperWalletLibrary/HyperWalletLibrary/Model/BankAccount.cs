using HyperWalletLibrary.Model.BankAccountModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace HyperWalletLibrary.Model
{
    class BankAccount : IHyperWalletModel
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }
        [JsonProperty("createdOn")]
        [JsonIgnore]
        public DateTime CreatedOn { get; set; }
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Types Type { get; set; }
        [JsonProperty("transferMethodCountry")]
        public string TransferMethodCountry { get; set; }
        [JsonProperty("transferMethodCurrency")]
        public string TransferMethodCurrency { get; set; }
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }
        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }
        [JsonProperty("bankAccountId")]
        public string BankAccountId { get; set; }
        [JsonProperty("bankAccountPurpose")]
        public string BankAccountPurpose { get; set; }
        [JsonProperty("bankAccountRelationship")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BankAccountRelationships BankAccountRelationship { get; set; }
        [JsonProperty("bankId")]
        public string BankId { get; set; }
        [JsonProperty("bankName")]
        public string BankName { get; set; }
        [JsonProperty("branchAddressLine1")]
        public string BranchAddressLine1 { get; set; }
        [JsonProperty("branchAddressLine2")]
        public string BranchAddressLine2 { get; set; }
        [JsonProperty("branchCity")]
        public string BranchCity { get; set; }
        [JsonProperty("branchCountry")]
        public string BranchCountry { get; set; }
        [JsonProperty("branchId")]
        public string BranchId { get; set; }
        [JsonProperty("branchName")]
        public string BranchName { get; set; }
        [JsonProperty("branchPostalCode")]
        public string BranchPostalCode { get; set; }
        [JsonProperty("branchStateProvince")]
        public string BranchStateProvince { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("countryOfBirth")]
        public string CountryOfBirth { get; set; }
        [JsonProperty("countryOfNationality")]
        public string CountryOfNationality { get; set; }
        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }
        [JsonProperty("driversLicenseId")]
        public string DriversLicenseId { get; set; }
        [JsonProperty("employerId")]
        public string EmployerId { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("gender")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Genders Gender { get; set; }
        [JsonProperty("governmentId")]
        public string GovernmentId { get; set; }
        [JsonProperty("governmentIdType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GovernmentIdTypes GovernmentIdType { get; set; }
        [JsonProperty("intermediaryBankAccountId")]
        public string IntermediaryBankAccountId { get; set; }
        [JsonProperty("intermediaryBankAddressLine1")]
        public string IntermediaryBankAddressLine1 { get; set; }
        [JsonProperty("intermediaryBankAddressLine2")]
        public string IntermediaryBankAddressLine2 { get; set; }
        [JsonProperty("intermediaryBankCity")]
        public string IntermediaryBankCity { get; set; }
        [JsonProperty("intermediaryBankCountry")]
        public string IntermediaryBankCountry { get; set; }
        [JsonProperty("intermediaryBankId")]
        public string IntermediaryBankId { get; set; }
        [JsonProperty("intermediaryBankName")]
        public string IntermediaryBankName { get; set; }
        [JsonProperty("intermediaryBankPostalCode")]
        public string IntermediaryBankPostalCode { get; set; }
        [JsonProperty("intermediaryBankStateProvince")]
        public string IntermediaryBankStateProvince { get; set; }
        [JsonProperty("isDefaultTransferMethod")]
        public bool IsDefaultTransferMethod { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }
        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }
        [JsonProperty("passportId")]
        public string PassportId { get; set; }
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
        [JsonProperty("profileType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ProfileTypes ProfileType { get; set; }
        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }
        [JsonProperty("wireInstructions")]
        public string WireInstructions { get; set; }
        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }
}
