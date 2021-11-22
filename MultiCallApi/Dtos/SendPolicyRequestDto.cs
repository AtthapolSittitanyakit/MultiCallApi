using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Serialization;

namespace MultiCallApi.Dtos
{
    [XmlRoot(ElementName = "SendPolicy",Namespace = "http://foo")]
    [MessageContract(WrapperName = "SendPolicy")]
    [DataContract]
    public class SendPolicyRequestDto 
    {

        private XmlSerializerNamespaces _Xmlns;

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns
        {
            get
            {
                if (_Xmlns == null)
                {
                    _Xmlns = new XmlSerializerNamespaces();
                    _Xmlns.Add("tem", "http://foo");
                }

                return _Xmlns;
            }

            set
            {
                _Xmlns = value;
            }
        }


        [DataMember(Order = 1)]
        [XmlElement("username")]
        //[XmlAttribute("username"]
        public string username { get; set; }


        [DataMember(Order = 2)]
        [XmlElement("password")]
        public string password { get; set; }


        [DataMember(Order = 3)]
        [XmlElement("info")]
        public InfoInputDto info { get; set; }


        [DataMember(Order = 4)]
        [XmlElement("genaratePolNo")]
        public bool genaratePolNo { get; set; }


        [DataMember(Order = 5)]
        [XmlElement("genaratePDF")]
        public bool genaratePDF { get; set; }

        [DataMember(Order = 6)]
        [XmlElement("calculatePremium")]
        public bool calculatePremium { get; set; }

        [DataMember(Order = 7)]
        [XmlElement("sswBranchCode")]
        public string sswBranchCode { get; set; }

        [DataMember(Order = 8)]
        [XmlElement("sswStaffCode")]
        public string sswStaffCode { get; set; }

        [XmlIgnore]
        public string ContractNumber { get; set; }

       

    }
}