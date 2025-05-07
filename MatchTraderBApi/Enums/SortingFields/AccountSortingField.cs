using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.SortingFields;

public enum AccountSortingField
{
    [EnumMember(Value = "created")]
    Created,
    
    [EnumMember(Value = "updated")]
    Updated,
    
    [EnumMember(Value = "accountConfiguration.partnerId")]
    PartnerId,
    
    [EnumMember(Value = "contactDetails.email")]
    Email,
    
    [EnumMember(Value = "contactDetails.phone")]
    Phone,
    
    [EnumMember(Value = "personalDetails.firstname")]
    Firstname,
    
    [EnumMember(Value = "personalDetails.surname")]
    Surname,
    
    [EnumMember(Value = "addressDetails.country")]
    Country,
    
    [EnumMember(Value = "addressDetails.state")]
    State,
    
    [EnumMember(Value = "addressDetails.city")]
    City,
    
    [EnumMember(Value = "addressDetails.postCode")]
    PostCode,
    
    [EnumMember(Value = "addressDetails.address")]
    Address,
}