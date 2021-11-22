using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MultiCallApi.Dtos
{
    [DataContract(Name = "Error")]
    [XmlType(TypeName = "Error")]
    public class SSWErrorDto
    {
        [DataMember(Order = 0)]
        virtual public string ErrorCode { get; set; }
        [DataMember(Order = 1)]
        virtual public string ErrorMessage { get; set; }     
        [XmlIgnore]
        virtual public string Description { get; set; }
    }

    public enum ErrorCode
    {
        UnknowError = 0,
        AuthenticationFail = 1,
        PolicyNumberNotFound = 2,
        PolicyNumberInUse = 3,
        RequireField = 4,
        ValidationError = 5,
        LicenseNotActive = 6,
        DataNotFound = 7,
        CoverDayOveYear = 8,
        DuplicatePolicy = 9
    }
}
