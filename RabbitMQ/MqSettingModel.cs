using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CommonUtil.RabbitMQ
{
    /// <summary>
    /// mq配置模型
    /// </summary>
    public class MqSettingModel
    {
        /// <summary>
        /// MQTCP连接
        /// </summary>
        public ConnectionFactory Factory { get; set; }

        /// <summary>
        /// MQTCP连接IP
        /// </summary>
        public string HostName { get;set;}

        /// <summary>
        /// mq用户名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// mq用户密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// mq端口号
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// mq虚拟主机
        /// </summary>
        public string VirtualHost { get; set; }

        /// <summary>
        /// mq消息重试次数
        /// </summary>
        public int RetryCount { get; set; }

        /// <summary>
        /// MQ配置集合
        /// </summary>
        public List<MqSettingModel> ChildItems { get; set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        public MqSettingModel(string mqConfig= "MQConfig") {
            this.HostName = ConfigUtil.Configuration[$"{mqConfig}:HostName"].Trim();
            this.Password = ConfigUtil.Configuration[$"{mqConfig}:Password"].Trim();
            this.Port = Int32.Parse(ConfigUtil.Configuration[$"{mqConfig}:Port"].Trim());
            this.UserName = ConfigUtil.Configuration[$"{mqConfig}:UserName"].Trim();
            this.VirtualHost = ConfigUtil.Configuration[$"{mqConfig}:VirtualHost"].Trim();
            this.RetryCount= int.Parse(ConfigUtil.Configuration[$"{mqConfig}:RetryCount"].Trim());
            this.Factory = new ConnectionFactory()
            {
                UserName = this.UserName,
                Password = this.Password,
                Port = this.Port,
                VirtualHost = this.VirtualHost,
                HostName = this.HostName
            };
            this.ChildItems = new List<MqSettingModel>();
            foreach (var item in ConfigUtil.Configuration.GetSection($"{mqConfig}:Items").GetChildren())
            {
                this.ChildItems.Add(new MqSettingModel(item.Path));
            }
        }
    }

    /// <summary>
    /// MQ消息体
    /// </summary>
    public class MessageModel {
        /// <summary>
        /// 消息Id
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// 消息事件
        /// </summary>
        public string MessageEvent { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? SendTime { get; set; }

        /// <summary>
        /// 来源消息Id
        /// </summary>
        public string FromMessageId { get; set; }

        /// <summary>
        /// 消息体
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 消息类型(timing:定时消息，common:普通消息)
        /// </summary>
        public string MessageType { get; set; }

        /// <summary>
        /// 队列名称
        /// </summary>
        public string QueueName { get; set; }

        /// <summary>
        /// 队列路由
        /// </summary>
        public string RouteKey { get; set; }

        /// <summary>
        /// 交换机名称
        /// </summary>
        public string ExchangeName { get; set; }

        /// <summary>
        /// 商家Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        public int RetryCount { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 初始化消息
        /// </summary>
        /// <param name="messageBody"></param>
        /// <param name="exchangeName"></param>
        /// <param name="routeKey"></param>
        /// <param name="queueName"></param>
        /// <param name="messageType"></param>
        /// <param name="userId"></param>
        /// <param name="eventkey"></param>
        /// <param name="sendTime"></param>
        /// <param name="messageId"></param>
        public MessageModel(string userId, string eventkey, string messageBody, MessageTypeEnum messageType, string routeKey, DateTime? sendTime=null, string exchangeName="", string queueName="", string messageId = "")
        {
            messageId = messageId.IsNullOrEmpty()?userId + "_" + GetMD5(messageBody) : userId+"_"+ messageId;
            this.Body = messageBody;
            this.ExchangeName = exchangeName;
            this.MessageEvent = eventkey;
            this.MessageId = messageId;
            this.RouteKey = routeKey;
            this.MessageType = messageType.ToString();
            this.QueueName = queueName;
            this.RetryCount = 0;
            this.UserId = userId;
            this.State = MessageStateEnum.send.ToString();
            this.SendTime = sendTime;
            #region 写入日志
            LogUtil.Trace("初始化创建消息："+JsonConvert.SerializeObject(this), "MQTrace");
            #endregion
        }

        /// <summary>
        /// md5加密
        /// </summary>
        /// <param name="myString"></param>
        /// <returns></returns>
        public string GetMD5(string myString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = System.Text.Encoding.Unicode.GetBytes(myString);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x");
            }

            return byte2String;
        }

        /// <summary>
        /// 消息重新推送变更消息体
        /// </summary>
        /// <param name="queueName"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public void RetryMessage(string queueName, ConnectionFactory factory)
        {
            var host = factory.HostName;
            var userName = factory.UserName;
            var port = factory.Port;
            var virtualHost = factory.VirtualHost;
            this.RetryCount += 1;
            this.QueueName = queueName;
            this.State = MessageStateEnum.retry.ToString();
            #region 写入日志
            LogUtil.Trace("消息重试：" + JsonConvert.SerializeObject(this), "MQTrace");
            #endregion
        }

        /// <summary>
        /// 消息转发
        /// </summary>
        /// <param name="exchangeName"></param>
        /// <param name="routeKey"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public void ForwardMessage(string exchangeName, string routeKey, ConnectionFactory factory)
        {
            var host = factory.HostName;
            var userName = factory.UserName;
            var port = factory.Port;
            var virtualHost = factory.VirtualHost;
            this.FromMessageId = this.MessageId;
            this.MessageId = this.UserId + "_" + Guid.NewGuid().ToString("N");

            this.ExchangeName = exchangeName;
            this.RouteKey = routeKey;
            this.RetryCount = 0;
            this.State = MessageStateEnum.forward.ToString();
            this.QueueName = null;
            #region 写入日志
            LogUtil.Trace("消息转发：" + JsonConvert.SerializeObject(this), "MQTrace");
            #endregion
        }

        /// <summary>
        /// 消息处理成功
        /// </summary>
        /// <param name="queueName"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public void MessageSuccess(string queueName, ConnectionFactory factory)
        {
            var host = factory.HostName;
            var userName = factory.UserName;
            var port = factory.Port;
            var virtualHost = factory.VirtualHost;
            this.QueueName = queueName;
            this.State = MessageStateEnum.success.ToString();
            #region 写入日志
            LogUtil.Trace("消息消费成功：" + JsonConvert.SerializeObject(this), "MQTrace");
            #endregion
        }

        /// <summary>
        /// 消息处理失败
        /// </summary>
        /// <param name="queueName"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public void MessageFail(string queueName, ConnectionFactory factory)
        {
            var host = factory.HostName;
            var userName = factory.UserName;
            var port = factory.Port;
            var virtualHost = factory.VirtualHost;
            this.QueueName = queueName;
            this.State = MessageStateEnum.fail.ToString();
            #region 写入日志
            LogUtil.Trace("消息消费失败：" + JsonConvert.SerializeObject(this), "MQTrace");
            #endregion
        }
    }
}
