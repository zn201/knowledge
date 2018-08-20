using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest
{
    public class QueryResp
    {
        /// <summary>
        /// 货主ID
        /// </summary>
        public long GoodsOwnerID { get; set; }
        /// <summary>
        /// 物流中心ID
        /// </summary>
        public long WareHouseID { get; set; }
        /// <summary>
        /// 入库订单ID
        /// </summary>
        public long OrderID { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        public int BusTypeID { get; set; }
        /// <summary>
        /// 往来单位ID
        /// </summary>
        public long CompanyID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreDate { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 细单条数
        /// </summary>
        public int DtlLines { get; set; }
        /// <summary>
        /// 入库细单ID 
        /// </summary>
        public long OrderDtlID { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public long GoodsID { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string GoodsType { get; set; }
        /// <summary>
        /// 剂型
        /// </summary>
        public int DrugForm { get; set; }
        /// <summary>
        /// 生产厂商
        /// </summary>
        public string VendorName { get; set; }
        /// <summary>
        /// 交易数量
        /// </summary>
        public int GoodsQty { get; set; }
        /// <summary>
        /// 基本单位
        /// </summary>
        public string TradePack { get; set; }
        /// <summary>
        /// 包装名称
        /// </summary>
        public string PackName { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string Lotno { get; set; }
        /// <summary>
        /// 货品状态
        /// </summary>
        public int GoodsStatusID { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProDate { get; set; }
        /// <summary>
        /// 有效期至
        /// </summary>
        public string EndValiDate { get; set; }
        /// <summary>
        /// 质量状态
        /// </summary>
        public int QualityStatus { get; set; }
        /// <summary>
        /// 产地
        /// </summary>
        public string ProdArea { get; set; }
        ///// <summary>
        ///// 备注
        ///// </summary>
        //public string Memo { get; set; }

    }
}
