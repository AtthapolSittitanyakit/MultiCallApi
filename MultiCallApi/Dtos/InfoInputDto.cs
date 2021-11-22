using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MultiCallApi.Dtos
{
    [DataContract(Name = "Info")]
    public class InfoInputDto : InputDto
    {
        [DataMember(Order = 1)]
        [XmlElement("PolNo")]
        public string PolNo { get; set; }

        [DataMember(Order = 2)]
        [XmlElement("PolNoPmc")]
        public string PolNoPmc { get; set; }

        [DataMember(Order = 3)]
        [XmlElement("Barcode")]
        public string Barcode { get; set; }

        [DataMember(Order = 4)]
        [XmlElement("taxInvoiceNoPmc")]
        public string taxInvoiceNoPmc { get; set; }

        [DataMember(Order = 5)]
        [XmlElement("taxInvoiceNo")]
        public string taxInvoiceNo { get; set; }

        [DataMember(Order = 6)]
        [XmlElement("ReferenceNo")]
        public string ReferenceNo { get; set; }

        [DataMember(Order = 7)]
        [XmlElement("PreviousPolNo")]
        public string PreviousPolNo { get; set; }

        [DataMember(Order = 8)]
        [XmlElement("PreviousPolNoPmc")]
        public string PreviousPolNoPmc { get; set; }

        [DataMember(Order = 9)]
        [XmlElement("CarSeat")]
        public string CarSeat { get; set; }

        [DataMember(Order = 10)]
        [XmlElement("CarCC")]
        public string CarCC { get; set; }

        [DataMember(Order = 11)]
        [XmlElement("CarWeight")]
        public string CarWeight { get; set; }

        [DataMember(Order = 12)]
        [XmlElement("CarCode")]
        public string CarCode { get; set; }

        [DataMember(Order = 13)]
        [XmlElement("CarRegistNo")]
        public string CarRegistNo { get; set; }

        [DataMember(Order = 14)]
        [XmlElement("CarChassisNo")]
        public string CarChassisNo { get; set; }

        [DataMember(Order = 15)]
        [XmlElement("CarYear")]
        public string CarYear { get; set; }

        [DataMember(Order = 16)]
        [XmlElement("CarProvince")]
        public string CarProvince { get; set; }

        [DataMember(Order = 17)]
        [XmlElement("CusPrefix")]
        public string CusPrefix { get; set; }

        [DataMember(Order = 18)]
        [XmlElement("CusFname")]
        public string CusFname { get; set; }

        [DataMember(Order = 19)]
        [XmlElement("CusLname")]
        public string CusLname { get; set; }

        [DataMember(Order = 20)]
        [XmlElement("CusId")]
        public string CusId { get; set; }

        [DataMember(Order = 21)]
        [XmlElement("CusType")]
        public string CusType { get; set; }

        [DataMember(Order = 22)]
        [XmlElement("Email")]
        public string Email { get; set; }

        [DataMember(Order = 23)]
        [XmlElement("PersonType")]
        public string PersonType { get; set; }

        [DataMember(Order = 24)]
        [XmlElement("CoperateType")]
        public string CoperateType { get; set; }

        [DataMember(Order = 25)]
        [XmlElement("CoperateBranchCode")]
        public string CoperateBranchCode { get; set; }

        [DataMember(Order = 26)]
        [XmlElement("PersonNationalityCode")]
        public string PersonNationalityCode { get; set; }

        [DataMember(Order = 27)]
        [XmlElement("Addrs1")]
        public string Addrs1 { get; set; }

        [DataMember(Order = 28)]
        [XmlElement("CusTelNumber")]
        public string CusTelNumber { get; set; }

        [DataMember(Order = 29)]
        [XmlElement("CusPostCode")]
        public string CusPostCode { get; set; }

        [DataMember(Order = 30)]
        [XmlElement("BillPrice")]
        public string BillPrice { get; set; }

        [DataMember(Order = 31)]
        [XmlElement("BillStamp")]
        public string BillStamp { get; set; }

        [DataMember(Order = 32)]
        [XmlElement("BillVat")]
        public string BillVat { get; set; }

        [DataMember(Order = 33)]
        [Display(Name = "BillPrm")]
        public string BillPrm { get; set; }

        [DataMember(Order = 34)]
        [XmlElement("EffectiveDate")]
        public string EffectiveDate { get; set; }

        [DataMember(Order = 35)]
        [XmlElement("ExpireDate")]
        public string ExpireDate { get; set; }

        [DataMember(Order = 36)]
        [XmlElement("ProvinceCode")]
        public string ProvinceCode { get; set; }

        [DataMember(Order = 37)]
        [XmlElement("DistrictCode")]
        public string DistrictCode { get; set; }

        [DataMember(Order = 38)]
        [XmlElement("SubDistrictCode")]
        public string SubDistrictCode { get; set; }

        [DataMember(Order = 39)]
        [XmlElement("CampaignCode")]
        public string CampaignCode { get; set; }

        [DataMember(Order = 40)]
        [XmlArrayItem("PathImage")]
        public ImageRQDto[] PathImage { get; set; }

        [DataMember(Order = 41)]
        [XmlElement("FlagCCTV")]
        public string FlagCCTV { get; set; }

        [DataMember(Order = 42)]
        [XmlElement("PreferredLang")]
        public string PreferredLang { get; set; }

        [DataMember(Order = 43)]
        [XmlElement("DirectDiscountRate")]
        public string DirectDiscountRate { get; set; }

        [DataMember(Order = 44)]
        [XmlElement("DirectDiscountAmount")]
        public string DirectDiscountAmount { get; set; }

        [DataMember(Order = 45)]
        [XmlElement("ISP14")]
        public string ISP14 { get; set; }
        
        [DataMember(Order = 46)]
        [XmlElement("LoanContractNumber")]
        public string LoanContractNumber { get; set; }
        
        [DataMember(Order = 47)]
        [XmlElement("BeneficiaryName")]
        public string BeneficiaryName { get; set; }

        [XmlIgnore]
        public string CarMakeCode { get; set; }
        [XmlIgnore]
        public string CarModelCode { get; set; }
        [XmlIgnore]
        public string CarModelName { get; set; }
    }

    [DataContract(Name = "ImageRQ")]
    [XmlType(TypeName = "ImageRQ")]
    public class ImageRQDto
    {
        [DataMember(Order = 1)]
        [XmlElement("Name")]
        public string Name { get; set; }
        [DataMember(Order = 2)]
        [XmlElement("Type")]
        public string Type { get; set; }
        [DataMember(Order = 3)]
        [XmlElement("Base64String")]
        public string Base64String { get; set; }
        [DataMember(Order = 4)]
        [XmlElement("ByteArray")]
        public string ByteArray { get; set; }
    }

    /// <summary>ประเภทผู้ทำประกัน</summary>
    public enum CustomerType
    {
        /// <summary>บุคคลธรรมดา</summary>
        P = 1,
        /// <summary>นิติบุคคล</summary>
        C = 2,
        /// <summary>บุคคลธรรมดาต่างด้าว</summary>
        N = 3,

    }


    /// <summary>เพศผู้ทำประกัน</summary>
    public enum CustomerSex
    {
        /// <summary>ผู้ชาย</summary>
        M = 1,
        /// <summary>ผู้หญิง</summary>
        F = 2,

    }

    public class ApiDateFormatAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)// Return a boolean value: true == IsValid, false != IsValid
        {
            try
            {
                DateTime dt = DateTime.ParseExact(value.ToString(), "yyyyMMdd",
                                  CultureInfo.InvariantCulture);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
