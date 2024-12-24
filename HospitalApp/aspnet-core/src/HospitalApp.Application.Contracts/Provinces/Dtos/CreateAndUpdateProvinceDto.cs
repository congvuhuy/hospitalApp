using HospitalApp.AddressType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Provinces.Dtos
{
    public class CreateAndUpdateProvinceDto
    {
        public string ProvinceName { get; set; } = string.Empty;
        public int ProvinceCode { get; set; }
        public ProvinceType ProvinceType { get; set; }
    }
}
