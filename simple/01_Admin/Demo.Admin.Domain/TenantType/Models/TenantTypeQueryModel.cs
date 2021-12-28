
using EasyModular.SqlSugar;
using EasyModular.Utils;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Admin.Domain
{
    /// <summary>
    /// 租户类别查询模型
    /// </summary>
    public class TenantTypeQueryModel : QueryPagingModel
    {

        /// <summary>
        /// 编码
        /// </summary>
        [Condition(ConditionalType = ConditionalType.Like)]
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Condition(ConditionalType = ConditionalType.Like)]
        public string Name { get; set; }
    }
}
    