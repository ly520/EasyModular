 
using EasyModular.SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Admin.Domain
{
    public interface IResourceFilterRepository : IRepository<ResourceFilterEntity>
    {
        Task<IList<ResourceFilterEntity>> Query(ResourceFilterQueryModel model);
    }
}
 