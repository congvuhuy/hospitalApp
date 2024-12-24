using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HospitalApp.Provinces.Dtos;

namespace HospitalApp.Provinces
{
    public class CreateAndUpdateDtoValidator: AbstractValidator<CreateAndUpdateProvinceDto>
    {
        public CreateAndUpdateDtoValidator()
        {
            RuleFor(x => x.ProvinceCode).NotEmpty().WithMessage("Mã tỉnh không được để trống")
                                        .GreaterThan(0).WithMessage("Mã tỉnh không hợp lệ");
            RuleFor(x => x.ProvinceName).NotEmpty().WithMessage("Tên tỉnh không được để trống")
                                        .MaximumLength(50).WithMessage("Tên tỉnh không quá 50 ký tự");
            RuleFor(x => x.ProvinceType).IsInEnum().WithMessage("Cấp không hợp lệ");
        }
    }
}
