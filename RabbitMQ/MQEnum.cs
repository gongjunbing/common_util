using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CommonUtil.RabbitMQ
{
    /// <summary>
    /// MQ交换机类型
    /// </summary>
    public enum MQExchangeTypeEnum
    {
        /// <summary>
        /// 广播交换机
        /// </summary>
        [Description("广播交换机")]
        fanout,

        /// <summary>
        /// 直连交换机
        /// </summary>
        [Description("直连交换机")]
        direct,

        /// <summary>
        /// 主题交换机
        /// </summary>
        [Description("主题交换机")]
        topic,

        /// <summary>
        /// 头交换机
        /// </summary>
        [Description("头交换机")]
        headers
    }

    /// <summary>
    /// 消息类型
    /// </summary>
    public enum MessageTypeEnum
    {
        /// <summary>
        /// 定时消息
        /// </summary>
        [Description("定时消息")]
        timing,

        /// <summary>
        /// 普通消息
        /// </summary>
        [Description("普通消息")]
        common
    }

    /// <summary>
    /// 消息状态
    /// </summary>
    public enum MessageStateEnum
    {
        /// <summary>
        /// 消息发送
        /// </summary>
        [Description("消息发送")]
        send,

        /// <summary>
        /// 转发
        /// </summary>
        [Description("转发")]
        forward,

        /// <summary>
        /// 重试
        /// </summary>
        [Description("重试")]
        retry,

        /// <summary>
        /// 失败
        /// </summary>
        [Description("失败")]
        fail,

        /// <summary>
        /// 成功
        /// </summary>
        [Description("成功")]
        success,
    }
}
