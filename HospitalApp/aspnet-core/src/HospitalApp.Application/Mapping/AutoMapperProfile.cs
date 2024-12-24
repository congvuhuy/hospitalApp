using AutoMapper;
using HospitalApp.Communes.Dtos;
using HospitalApp.Districts.Dtos;
using HospitalApp.Entities;
using HospitalApp.Hospitals.Dto;
using HospitalApp.Provinces.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //province
            CreateMap<ProvinceDto, Province>();
            CreateMap<Province, ProvinceDto>();

            CreateMap<CreateAndUpdateProvinceDto, Province>();


            //District
            CreateMap<DistrictDto, District>();
            CreateMap<District, DistrictDto>();

            CreateMap<CreateAndUpdateDistrictDto, District>();


            //Commune
            CreateMap<CommuneDto, Commune>();
            CreateMap<Commune, CommuneDto>();
            CreateMap<CreateAndUpdateCommuneDto, Commune>();

            //Hospital
            CreateMap<CreateAndUpdateHospitalDto, Hospital>();
            CreateMap<Hospital, HospitalDto>();
            //Patient
        }
    }
}
