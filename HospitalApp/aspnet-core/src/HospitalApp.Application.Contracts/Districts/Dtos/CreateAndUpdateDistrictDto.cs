using HospitalApp.AddressType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Districts.Dtos
{
    public class CreateAndUpdateDistrictDto
    {
        public string DistrictName { get; set; } = string.Empty;
        public int DistrictCode { get; set; }
        public DistrictType DistrictType { get; set; }
        public int ProvinceCode { get; set; }
    }
}
