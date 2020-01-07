using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserInviteOfflinesummaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserInviteOfflinesummaryQueryModel : AopObject
    {
        /// <summary>
        /// 二级渠道
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 一级渠道
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 参数名task_id，提供给商户按不同的线下拉新任务类型查询任务完成报表，当前枚举值有：xianxia001,xianxia002,xianxia_super,xianxia_bank。获取方式：该API仅提供给KA商户使用，接入时由运营沟通该参数如何使用。
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
