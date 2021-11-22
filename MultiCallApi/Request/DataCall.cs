using MultiCallApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCallApi.Request
{
    public class DataCall
    {
        public static List<SendPolicyRequestDto> xml_call()
        {
            var list = new List<SendPolicyRequestDto>();
            for (int i = 1; i <= 10; i++)
            {
                SendPolicyRequestDto request = new SendPolicyRequestDto();

                request.username = "k6nKOEd1gJ7DVB2b0TGz";
                request.password = "CMmUHWa0b8ZKF7qEner3kSovGsj9IQAphd5gYywO";


                var info = new InfoInputDto();
                info.PolNo = "";
                info.PolNoPmc = "";
                info.Barcode = "";
                info.taxInvoiceNoPmc = "";
                info.taxInvoiceNo = "";
                info.ReferenceNo = "";
                info.PreviousPolNo = "";
                info.PreviousPolNoPmc = "";
                info.CarSeat = "";
                info.CarCC = "100";
                info.CarWeight = "";
                info.CarCode = "SSW00293";
                info.CarRegistNo = $"8กฉ-912{i}";
                info.CarChassisNo = $"CSMAKE2021080912{i}";
                info.CarYear = "2012";
                info.CarProvince = "57";
                info.CusPrefix = "7";
                info.CusFname = "ทดสอบ";
                info.CusLname = $"performance{i}";
                info.CusId = "1439900178178";
                info.CusType = "P";
                info.Email = "atthapol.sittitanyakit@chubb.com";
                info.PersonType = "";
                info.CoperateType = "";
                info.CoperateBranchCode = "";
                info.PersonNationalityCode = "THA";
                info.Addrs1 = "999 / 1 ม.9";
                info.CusTelNumber = "0998889999";
                info.CusPostCode = "57130";
                info.BillPrice = "";
                info.BillStamp = "";
                info.BillVat = "";
                info.BillPrm = "";
                info.EffectiveDate =DateTime.Now.ToString("yyyyMMdd");
                info.ExpireDate = DateTime.Now.AddYears(+1).ToString("yyyyMMdd");
                info.ProvinceCode = "57";
                info.DistrictCode = "09";
                info.SubDistrictCode = "08";
                info.CampaignCode = "424377-23626";
                //info.PathImage[0].Name = "";
                //info.PathImage[0].Type = "";
                //info.PathImage[0].Base64String = "";
                //info.PathImage[0].ByteArray = "";
                info.FlagCCTV = "";
                info.PreferredLang = "";
                info.DirectDiscountRate = "";
                info.DirectDiscountAmount = "";
                info.ISP14 = "";
                info.LoanContractNumber = "";
                info.BeneficiaryName = "";

                request.info = info;
                request.genaratePolNo = true;
                request.genaratePDF = true;
                request.calculatePremium = true;
                request.sswBranchCode = "SS001";
                request.sswStaffCode = "";

                list.Add(request);
            
            }

            return list;
        }
    }
}
