using HospitalApp.AddressType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Communes.Dtos
{
    public class CreateAndUpdateCommuneDto
    {
        public string CommuneName { get; set; } = string.Empty;
        public int CommuneCode { get; set; }
        public CommuneType CommuneType { get; set; }
        public int ProvinceCode { get; set; }
        public int DistrictCode { get; set; }
    }
}
