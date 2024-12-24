﻿using HospitalApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HospitalApp.Irepositories
{
    public interface ICommuneRepository : IScopedDependency
    {
        Task<List<Commune>> GetAllAsync(int pageNumber, int pageSize);
        Task<Commune> GetByCodeAsync(int code);
    }
}
