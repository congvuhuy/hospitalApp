﻿using OfficeOpenXml;
using HospitalApp.AddressType;
using HospitalApp.Communes;
using HospitalApp.Communes.Dtos;
using HospitalApp.Districts;
using HospitalApp.Districts.Dtos;
using HospitalApp.Excels;
using HospitalApp.Provinces;
using HospitalApp.Provinces.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Services
{
    public class ExcelImportService : IExcelImportService
    {
        private readonly IProvinceService _provinceService;
        private readonly IDistrictService _districtService;
        private readonly ICommuneService _communeService;
        public ExcelImportService(IProvinceService provinceService, IDistrictService districtService, ICommuneService communeService)
        {
            _provinceService = provinceService;
            _districtService = districtService;
            _communeService = communeService;
        }
        public async Task ImportExcelProvince(Stream excelStream)
        {
            var provinceList = new List<CreateAndUpdateProvinceDto>();
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(excelStream))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    for (int row = 2; row <= worksheet.Dimension.End.Row - 1; row++)
                    {
                        var provinceTypeStr = worksheet.Cells[row, 4].Text;
                        var normalizedProvinceTypeStr = NormalizeString(provinceTypeStr);
                        Enum.TryParse(normalizedProvinceTypeStr, out ProvinceType provinceType);
                        var createProvinceDto = new CreateAndUpdateProvinceDto
                        {
                            ProvinceCode = int.Parse(worksheet.Cells[row, 1].Text),
                            ProvinceName = worksheet.Cells[row, 2].Text,
                            ProvinceType = provinceType,
                        };
                        provinceList.Add(createProvinceDto);
                    }

                    await _provinceService.CreateMultipleAsync(provinceList);

                }

            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }

        }
        //Import District
        public async Task ImportExcelDistrict(Stream excelStream)
        {
            var districtList = new List<CreateAndUpdateDistrictDto>();
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(excelStream))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    for (int row = 2; row <= worksheet.Dimension.End.Row - 1; row++)
                    {
                        var districtTypeStr = worksheet.Cells[row, 4].Text;
                        var normalizedDistrictTypeStr = NormalizeString(districtTypeStr);
                        Enum.TryParse(normalizedDistrictTypeStr, out DistrictType districtType);
                        var createDistrictDto = new CreateAndUpdateDistrictDto
                        {
                            DistrictCode = int.Parse(worksheet.Cells[row, 1].Text),
                            DistrictName = worksheet.Cells[row, 2].Text,
                            DistrictType = districtType,
                            ProvinceCode = int.Parse(worksheet.Cells[row, 5].Text),
                        };
                        districtList.Add(createDistrictDto);
                    }

                    await _districtService.CreateMultipleAsync(districtList);
                }

            }
            catch (Exception ex)
            {

                throw;
            }

        }
        //Import Commune
        public async Task ImportExcelCommune(Stream excelStream)
        {
            var communeList = new List<CreateAndUpdateCommuneDto>();
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(excelStream))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    //for (int row = 2; row <= worksheet.Dimension.End.Row-1; row++)
                    for (int row = 2; row <= 600; row++)
                    {
                        var communeTypeStr = worksheet.Cells[row, 4].Text;
                        var normalizedCommuneTypeStr = NormalizeString(communeTypeStr);
                        Enum.TryParse(normalizedCommuneTypeStr, out CommuneType communeType);
                        var createCommuneDto = new CreateAndUpdateCommuneDto
                        {
                            CommuneCode = int.Parse(worksheet.Cells[row, 1].Text),
                            CommuneName = worksheet.Cells[row, 2].Text,
                            CommuneType = communeType,
                            DistrictCode = int.Parse(worksheet.Cells[row, 5].Text),
                            ProvinceCode = int.Parse(worksheet.Cells[row, 7].Text),


                        };
                        //if (createCommuneDto.CommuneCode < 0 || createCommuneDto.CommuneCode == null)
                        //{
                        //    throw new Exception($"Mã xã dòng {row} không hợp lệ");
                        //}

                        communeList.Add(createCommuneDto);
                    }

                    await _communeService.CreateMultipleAsync(communeList);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public string NormalizeString(string input)
        {
            var normalizedString = input.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();
            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString()
                                .Normalize(NormalizationForm.FormC)
                                .Replace(" ", string.Empty)
                                .ToLower();
        }


    }
}
