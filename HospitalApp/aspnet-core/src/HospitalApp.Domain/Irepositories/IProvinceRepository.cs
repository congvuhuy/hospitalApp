﻿using HospitalApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Irepositories
{
    public interface IProvinceRepository
    {
        Task<List<Province>> GetAllAsync(int pageNumber, int pageSize);
        Task<Province> GetByCodeAsync(int code);
    }
}
