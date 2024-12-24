using HospitalApp.Communes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HospitalApp.Communes
{
    public interface ICommuneService : IScopedDependency
    {
        Task CreateMultipleAsync(List<CreateAndUpdateCommuneDto> communeList);
        public Task<List<CommuneDto>> GetFilterAsync(int pageNumber, int pageSize);
    }
}
