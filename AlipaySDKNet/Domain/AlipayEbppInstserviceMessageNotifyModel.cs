using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceMessageNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInstserviceMessageNotifyModel : AopObject
    {
        /// <summary>
        /// 账单机构缩写，广东移动，江苏电网
        /// </summary>
        [XmlElement("bill_inst")]
        public string BillInst { get; set; }

        /// <summary>
        /// 如浙江电力，浙江移动等
        /// </summary>
        [XmlElement("bill_inst_desc")]
        public string BillInstDesc { get; set; }

        /// <summary>
        /// 通知关键字，户号，手机号
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型，通信，缴费，还款等动帐服务通知
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 标准kv，json数据
        /// </summary>
        [XmlElement("extend_data")]
        public string ExtendData { get; set; }

        /// <summary>
        /// 通知时间
        /// </summary>
        [XmlElement("notify_date")]
        public string NotifyDate { get; set; }

        /// <summary>
        /// 通知描述
        /// </summary>
        [XmlElement("notify_desc")]
        public string NotifyDesc { get; set; }

        /// <summary>
        /// 通知功能码
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 二级业务类型，话费，流量，水费，电费等
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
