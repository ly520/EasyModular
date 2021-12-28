 
using EasyModular.SqlSugar;
using Demo.Admin.Domain;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Admin.Infrastructure
{
    public class ConfigRepository : RepositoryBase<ConfigEntity>, IConfigRepository
    {
        public ConfigRepository(IDbContext context, IQueryFilter filter) : base(context, filter)
        {

        }

        public async Task<IList<ConfigEntity>> Query(ConfigQueryModel model)
        {
            var conditions = await _filter.GetConditions<ConfigEntity, ConfigQueryModel>(model);
            var query = _dbContext.Db.Queryable<ConfigEntity>()
                                     .Where(conditions)
                                     .OrderBy(model.OrderFileds);

            RefAsync<int> totalCount = 0;
            var data = await query.ToPageListAsync(model.PageIndex, model.PageSize, totalCount);
            model.TotalCount = totalCount;

            return data;
        }
    }
}
