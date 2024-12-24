using Dapper;
using HospitalApp.Entities;
using HospitalApp.EntityFrameworkCore;
using HospitalApp.Irepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;

namespace HospitalApp.Repositories
{
    public class DistrictRepository : DapperRepository<HospitalAppDbContext>, IDistrictRepository, ITransientDependency
    {
        public DistrictRepository(IDbContextProvider<HospitalAppDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
        public virtual async Task<List<District>> GetAllAsync(int pageNumber, int pageSize)
        {
            var dbConnection = await GetDbConnectionAsync();
            var sql = @"SELECT * FROM District ORDER BY ProvinceCode LIMIT @PageSize OFFSET @Offset;";
            var parameters = new
            {
                Offset = (pageNumber - 1) * pageSize,
                PageSize = pageSize
            };

            return (await dbConnection.QueryAsync<District>(sql, parameters, transaction: await GetDbTransactionAsync())).ToList();
        }

        public async Task<District> GetByCodeAsync(int code)
        {
            var dbConnection = await GetDbConnectionAsync();
            var sql = @"SELECT * FROM District WHERE DistrictCode=@Code";
            var parameters = new { Code = code };
            return (dbConnection.QueryFirstOrDefault<District>(sql, parameters, transaction: await GetDbTransactionAsync()));
        }
    }
}
