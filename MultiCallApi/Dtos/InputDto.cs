using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCallApi.Dtos
{
    public class InputDto
    {
        public const string VinFormat = @"(\d?[ก-ฮ]+)( |-)?(\d+)";
        public const string ChassisNoFormat = @"(\w+)";
        public const string MobileNoFormat = @"0([0-9]{9})";
    }
}
