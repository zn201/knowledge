using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest
{
    /// <summary>
    /// 入库返回实体类
    /// </summary>
    public class WarehouseResp
    {
        /// <summary>
        /// "success|failure，只要有一个失败flag就置为failure，如果是success，就忽略下面的inorders节点"
        /// </summary>
        public string flag { get; set; }
        /// <summary>
        /// 响应码
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 响应信息
        /// </summary>
        public string message { get; set; }
        public List<InOrders> inorders { get; set; }
    }

    public class InOrders
    {
        /// <summary>
        /// 同步失败入库订单ID
        /// </summary>
        public string orderid { get; set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string message { get; set; }
    }
}
