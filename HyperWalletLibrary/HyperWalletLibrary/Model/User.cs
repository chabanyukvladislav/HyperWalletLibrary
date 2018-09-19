using HyperWalletLibrary.Model.UserModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace HyperWalletLibrary.Model
{
    public class User: IHyperWalletModel
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("status")]
        [JsonIgnore]
        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }
        [JsonProperty("createdOn")]
        [JsonIgnore]
        public DateTime CreatedOn { get; set; }
        [JsonProperty("clientUserId")]
        public string ClientUserId { get; set; }
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }
        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }
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
        [JsonProperty("email")]
        public string Email { get; set; }
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
        [JsonProperty("language")]
        public string Language { get; set; }
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
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("profileType")]
        public ProfileTypes ProfileType { get; set; }
        [JsonProperty("programToken")]
        public string ProgramToken { get; set; }
        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("verificationStatus")]
        public VerificationStatus VerificationStatus { get; set; }
        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }
}
