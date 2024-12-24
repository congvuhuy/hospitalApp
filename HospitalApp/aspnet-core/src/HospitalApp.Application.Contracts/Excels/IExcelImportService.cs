﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HospitalApp.Excels
{
    public interface IExcelImportService : IScopedDependency
    {
        public Task ImportExcelProvince(Stream excelStream);
        public Task ImportExcelDistrict(Stream excelStream);
        public Task ImportExcelCommune(Stream excelStream);
    }
}
