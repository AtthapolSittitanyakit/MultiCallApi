using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MultiCallApi.Dtos
{
    [DataContract]
    public class SendPolicyResponseDto
    {
        [DataMember(Order = 1)]
        public string IsSuccess = "false";

        [DataMember(Order = 2)]
        public string PolNoPmc = "";

        //[DataMember(Order = 3)]
        //public string FullPrm = "";      

        [DataMember(Order = 3)]
        public string BillPrm = "";

        [DataMember(Order = 4)]
        public string BillStamp = "";

        [DataMember(Order = 5)]
        public string BillVat = "";

        [DataMember(Order = 6)]
        public string BillPrice = "";

        [DataMember(Order = 7)]
        public SSWErrorDto[] Errors = new SSWErrorDto[0];

        [DataMember(Order = 8)]
        public string TablePDF = "";

        [XmlIgnore]
        public int TranId;
        [XmlIgnore]
        public string NotificationNumber;
    }
}
