using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonTest
{
    /// <summary>
    /// 入库请求实体类
    /// </summary>
    public class PutIn
    {
        [JsonProperty("goodsownerid")]
        public long GoodsownerId { get; set; }
        [JsonProperty("warehouseid")]
        public long WarehouseId { get; set; }
        [JsonProperty("inorders")]
        public List<InOrder> InOrders { get; set; }
    }

    public class InOrder
    {
        [JsonProperty("orderid")]
        public long OrderId { get; set; }
        [JsonProperty("orderno")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonProperty("bustypeid")]
        public int BustypeId { get; set; }
        /// <summary>
        /// 物流标志（1：无物流；0：物流）
        /// </summary>
        [JsonProperty("wmsflag")]
        public int WmsFlag { get; set; }
        /// <summary>
        /// 预计到货日期  YYYY-MM-DD
        /// </summary>
        [JsonProperty("exptdate")]
        public string exptdate { get; set; }
        /// <summary>
        /// 货主单位ID 
        /// </summary>
        [JsonProperty("companyid")]
        public long CompanyId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 备用字段1 
        /// </summary>
        [JsonProperty("zxcolumn1")]
        public string ZxColumn1 { get; set; }
        /// <summary>
        /// 备用字段2 
        /// </summary>
        [JsonProperty("zxcolumn2")]
        public string ZxColumn2 { get; set; }
        /// <summary>
        /// 备用字段3
        /// </summary>
        [JsonProperty("zxcolumn3")]
        public string ZxColumn3 { get; set; }
        /// <summary>
        /// 备用字段4 
        /// </summary>
        [JsonProperty("zxcolumn4")]
        public string ZxColumn4 { get; set; }
        /// <summary>
        /// 备用字段5
        /// </summary>
        [JsonProperty("zxcolumn5")]
        public string ZxColumn5 { get; set; }
        /// <summary>
        /// 备用字段6 
        /// </summary>
        [JsonProperty("zxcolumn6")]
        public string ZxColumn6 { get; set; }
        /// <summary>
        /// 备用字段7
        /// </summary>
        [JsonProperty("zxcolumn7")]
        public string ZxColumn7 { get; set; }
        /// <summary>
        /// 备用字段8 
        /// </summary>
        [JsonProperty("zxcolumn8")]
        public string ZxColumn8 { get; set; }
        /// <summary>
        /// 备用字段9
        /// </summary>
        [JsonProperty("zxcolumn9")]
        public string ZxColumn9 { get; set; }
        /// <summary>
        /// 备用字段10
        /// </summary>
        [JsonProperty("zxcolumn10")]
        public string ZxColumn10{ get; set; }
        /// <summary>
        /// 订单明细
        /// </summary>
        [JsonProperty("orderdtls")]
        public List<OrderDtl> OrderDtls { get; set; }
    }

    public class OrderDtl
    {
        /// <summary>
        /// 货主入库细单ID
        /// </summary>
        [JsonProperty("orderdtlid")]
        public long OrderDtlId { get; set; }
        /// <summary>
        /// 货主货品ID
        /// </summary>
        [JsonProperty("goodsid")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 基本单位 
        /// </summary>
        [JsonProperty("goodsunit")]
        public string GoodsUnit { get; set; }
        /// <summary>
        /// 包装名称
        /// </summary>
        [JsonProperty("packname")]
        public string PackName { get; set; }
        /// <summary>
        /// 包装大小
        /// </summary>
        [JsonProperty("packsize")]
        public long PackSize { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("goodsqty")]
        public long GoodsQty { get; set; }
        /// <summary>
        /// 单价 
        /// </summary>
        [JsonProperty("unitprice")]
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        [JsonProperty("lotno")]
        public string LotNo { get; set; }
        /// <summary>
        /// 生产日期 YYYY-MM-DD
        /// </summary>
        [JsonProperty("prodate")]
        public string ProDate { get; set; }
        /// <summary>
        /// 有效期 YYYY-MM-DD
        /// </summary>
        [JsonProperty("endvalidate")]
        public string EndValidate { get; set; }
        /// <summary>
        /// 批准文号 
        /// </summary>
        [JsonProperty("approvedno")]
        public string ApprovedNo { get; set; }
        /// <summary>
        /// 注册证号 
        /// </summary>
        [JsonProperty("registerno")]
        public string RegisterNo { get; set; }
        /// <summary>
        /// 货品状态
        /// </summary>
        [JsonProperty("goodsstatusid")]
        public int GoodsStatusId { get; set; }
        /// <summary>
        /// 质量状态
        /// </summary>
        [JsonProperty("qualitystatus")]
        public int QualityStatus { get; set; }
        /// <summary>
        /// 退货原因
        /// </summary>
        [JsonProperty("backreason")]
        public int BackReason { get; set; }
        /// <summary>
        /// 产地
        /// </summary>
        [JsonProperty("prodarea")]
        public string ProdArea { get; set; }
        /// <summary>
        /// 生产厂商
        /// </summary>
        [JsonProperty("vendorname")]
        public string VendorName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("dtlmemo")]
        public string DtlMemo { get; set; }
        /// <summary>
        /// 备用字段1 
        /// </summary>
        [JsonProperty("zxcolumn1")]
        public string ZxColumn1 { get; set; }
        /// <summary>
        /// 备用字段2 
        /// </summary>
        [JsonProperty("zxcolumn2")]
        public string ZxColumn2 { get; set; }
        /// <summary>
        /// 备用字段3
        /// </summary>
        [JsonProperty("zxcolumn3")]
        public string ZxColumn3 { get; set; }
        /// <summary>
        /// 备用字段4 
        /// </summary>
        [JsonProperty("zxcolumn4")]
        public string ZxColumn4 { get; set; }
        /// <summary>
        /// 备用字段5
        /// </summary>
        [JsonProperty("zxcolumn5")]
        public string ZxColumn5 { get; set; }
        /// <summary>
        /// 备用字段6 
        /// </summary>
        [JsonProperty("zxcolumn6")]
        public string ZxColumn6 { get; set; }
        /// <summary>
        /// 备用字段7
        /// </summary>
        [JsonProperty("zxcolumn7")]
        public string ZxColumn7 { get; set; }
        /// <summary>
        /// 备用字段8 
        /// </summary>
        [JsonProperty("zxcolumn8")]
        public string ZxColumn8 { get; set; }
        /// <summary>
        /// 备用字段9
        /// </summary>
        [JsonProperty("zxcolumn9")]
        public string ZxColumn9 { get; set; }
        /// <summary>
        /// 备用字段10
        /// </summary>
        [JsonProperty("zxcolumn10")]
        public string ZxColumn10 { get; set; }
    }
}
