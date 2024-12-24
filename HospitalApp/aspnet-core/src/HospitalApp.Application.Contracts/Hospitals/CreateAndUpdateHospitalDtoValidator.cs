using FluentValidation;
using HospitalApp.Hospitals.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Hospitals
{
    public class CreateAndUpdateHospitalValidateDto : AbstractValidator<CreateAndUpdateHospitalDto>
    {
        public CreateAndUpdateHospitalValidateDto()
        {
            RuleFor(x => x.HospitalName).NotNull().WithMessage("tên bệnh viện không được dể trống")
                                      .NotEmpty().WithMessage("tên bệnh viện không được dể trống");

            RuleFor(x => x.CommuneCode).NotEmpty().WithMessage("Mã xã không được để trống")
                                      .GreaterThan(0).WithMessage("Mã xã không hợp lệ");
            RuleFor(x => x.DistrictCode).NotEmpty().WithMessage("Mã huyện không được để trống")
                                        .GreaterThan(0).WithMessage("Mã huyện không hợp lệ");
            RuleFor(x => x.ProvinceCode).NotEmpty().WithMessage("Mã tỉnh không được để trống")
                                      .GreaterThan(0).WithMessage("Mã tỉnh không hợp lệ");

        }
    }
}
