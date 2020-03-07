using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonUtil.RabbitMQ
{
    /// <summary>
    /// RabbitMQ主体
    /// </summary>
    public class MQClient
    {
        /// <summary>
        /// mq默认配置
        /// </summary>
        public static readonly MqSettingModel MqSetting = new MqSettingModel();

        /// <summary>
        /// mq连接connection
        /// </summary>
        public static  IConnection Connection;

        /// <summary>
        /// mq连接channel
        /// </summary>
        public static IModel Channel;

        /// <summary>
        /// 发送消息(普通消息，指定交换机类型)
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="exchangeType">交换机类型</param>
        /// <returns></returns>
        public static bool SendMessage(MessageModel message, MQExchangeTypeEnum exchangeType) => SendMessage(null, message, exchangeType);

        /// <summary>
        /// 发送消息(普通消息)
        /// </summary>
        /// <param name="message">消息体</param>
        /// <returns></returns>
        public static bool SendMessage(MessageModel message) => SendMessage(null, message, MQExchangeTypeEnum.direct);

        /// <summary>
        /// 发送消息(指定自定义tcp连接发送消息)
        /// </summary>
        /// <param name="mqSetting">mq连接对象</param>
        /// <param name="message">消息体</param>
        /// <returns></returns>
        public static bool SendMessage(MqSettingModel mqSetting, MessageModel message) => SendMessage(mqSetting, message, MQExchangeTypeEnum.direct);

        /// <summary>
        /// 发送消息(指定自定义tcp连接和交换机类型)
        /// </summary>
        /// <param name="mqSetting">mq连接对象</param>
        /// <param name="message">消息体</param>
        /// <param name="exchangeType">交换机类型</param>
        /// <returns></returns>
        public static bool SendMessage(MqSettingModel mqSetting, MessageModel message, MQExchangeTypeEnum exchangeType)
        {
            var result = false;
            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));
            mqSetting = mqSetting==null?MqSetting: mqSetting;

            using (var connection = mqSetting.Factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    if (!string.IsNullOrWhiteSpace(message.ExchangeName))
                    {
                        channel.ExchangeDeclare(message.ExchangeName, exchangeType.ToString(), true, false, null);
                    }

                    if (!string.IsNullOrWhiteSpace(message.QueueName))
                    {
                        channel.QueueDeclare(queue: message.QueueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
                        if (!string.IsNullOrWhiteSpace(message.ExchangeName))
                        {
                            channel.QueueBind(message.QueueName, message.ExchangeName, message.RouteKey, null);
                        }
                    }

                    if (message.SendTime != null && message.SendTime > DateTime.Now.AddSeconds(2))
                    {
                        TimeSpan ts = Convert.ToDateTime(message.SendTime) - DateTime.Now;
                        var argument = new Dictionary<string, object>();
                        argument.Add("x-dead-letter-exchange", message.ExchangeName);//过期消息转向路由  
                        argument.Add("x-dead-letter-routing-key", message.RouteKey);//过期消息转向路由相匹配routingkey  
                        argument.Add("x-message-ttl", (int)ts.TotalSeconds * 1000);//消息的过期时间  
                        argument.Add("x-expires", ((int)ts.TotalSeconds * 1000)+1000);//队列的过期时间 
                        var queueName = "timing_" + Guid.NewGuid().ToString("N");
                        channel.QueueDeclare(queueName, true, false, false, argument);
                        if (!string.IsNullOrWhiteSpace(message.ExchangeName))
                        {
                            message.RouteKey = queueName;
                            channel.QueueBind(queueName, message.ExchangeName, message.RouteKey, null);
                        }

                        IBasicProperties properties = channel.CreateBasicProperties();
                        properties.Persistent = true;//消息持久化
                        channel.BasicPublish(exchange: message.ExchangeName, routingKey: queueName, basicProperties: properties, body: body);
                    }
                    else
                    {
                        IBasicProperties properties = channel.CreateBasicProperties();
                        properties.Persistent = true;//消息持久化
                        channel.BasicPublish(exchange: message.ExchangeName, routingKey: message.RouteKey, basicProperties: properties, body: body);
                    }

                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// 接收并处理消息（指定交换机和交换机类型）
        /// </summary>
        /// <param name="runMethod">委托方法</param>
        /// <param name="queueName">队列名称</param>
        /// <param name="routeKey">路由</param>
        /// <param name="exchangeType">交换机类型</param>
        /// <param name="exchangeName">交换机名称</param>
        /// <returns></returns>
        public void  ReceiveMessage(Func<MessageModel, bool> runMethod, string queueName,string routeKey,MQExchangeTypeEnum exchangeType, string exchangeName) => ReceiveMessage(null, runMethod, queueName, routeKey, exchangeType, exchangeName);

        /// <summary>
        /// 接收并处理消息
        /// </summary>
        /// <param name="runMethod">委托方法</param>
        /// <param name="queueName">队列名称</param>
        /// <param name="routeKey">路由</param>
        /// <returns></returns>
        public void ReceiveMessage(Func<MessageModel, bool> runMethod, string queueName, string routeKey) => ReceiveMessage(null, runMethod, queueName, routeKey, MQExchangeTypeEnum.direct, "");

        /// <summary>
        /// 接收并处理消息(指定自定义tcp连接)
        /// </summary>
        /// <param name="mqSetting">mq连接对象</param>
        /// <param name="runMethod">委托方法</param>
        /// <param name="queueName">队列名称</param>
        /// <param name="routeKey">路由</param>
        /// <returns></returns>
        public void ReceiveMessage(MqSettingModel mqSetting, Func<MessageModel, bool> runMethod, string queueName, string routeKey) => ReceiveMessage(mqSetting, runMethod, queueName, routeKey, MQExchangeTypeEnum.direct, "");

        /// <summary>
        /// 接收并处理消息(指定自定义tcp连接，并指定交换机和交换机类型)
        /// </summary>
        /// <param name="mqSetting">mq连接对象</param>
        /// <param name="runMethod">委托方法</param>
        /// <param name="queueName">队列名称</param>
        /// <param name="routeKey">路由</param>
        /// <param name="exchangeType">交换机类型</param>
        /// <param name="exchangeName">交换机名称</param>
        /// <returns></returns>
        public void ReceiveMessage(MqSettingModel mqSetting, Func<MessageModel, bool> runMethod, string queueName, string routeKey, MQExchangeTypeEnum exchangeType, string exchangeName)
        {
            mqSetting = mqSetting != null ? mqSetting : MqSetting;
            Connection = mqSetting!=null?
                mqSetting.Factory.CreateConnection():MqSetting.Factory.CreateConnection();
            Channel = Connection.CreateModel();

            Channel.QueueDeclare(queue: queueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
            if (!string.IsNullOrWhiteSpace(exchangeName))
            {
                Channel.ExchangeDeclare(exchangeName, exchangeType.ToString(), true, false, null);
                Channel.QueueBind(queueName, exchangeName, routeKey, null);
            }

            Channel.BasicQos(0, 1, false);//消费者每次只接收一个消息，并且给Mq回复后才可以接受下一个消息

            var consumer = new EventingBasicConsumer(Channel);
            consumer.Received += (model, ea) =>
            {
                var body = Encoding.UTF8.GetString(ea.Body);
                var message = JsonConvert.DeserializeObject<MessageModel>(body);
                var isSuccess = runMethod(message);
                if (isSuccess)
                {
                    Channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                    message.MessageSuccess(queueName, mqSetting.Factory);
                }
                else
                {
                    if (message.RetryCount >= MqSetting.RetryCount - 1)
                    {
                        Channel.BasicReject(ea.DeliveryTag, requeue: false);
                        message.MessageFail(queueName, mqSetting.Factory);
                    }
                    else
                    {
                        //消息重新推送
                        message.RetryMessage(queueName, mqSetting.Factory);
                        RetryMessage(mqSetting, message);
                        Channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                    }
                }
            };

            Channel.BasicConsume(queue: queueName, autoAck: false, consumer: consumer);
        }


        /// <summary>
        /// 消息重试机制
        /// </summary>
        /// <param name="mqSetting">mq连接对象</param>
        /// <param name="message">消息体</param>
        /// <returns></returns>
        private static bool RetryMessage(MqSettingModel mqSetting, MessageModel message)
        {
            var result = false;
            var timeDic = new Dictionary<int, int>();
            timeDic.Add(1, 5);
            timeDic.Add(2, 60);
            timeDic.Add(3, 60*5);
            timeDic.Add(4, 60*30);
            timeDic.Add(5, 60 * 60);
            timeDic.Add(6, 60 * 60*5);
            timeDic.Add(7, 60 * 60 * 24);
            timeDic.Add(8, 60 * 60 * 72);
            timeDic.Add(9, 60 * 60 * 24*15);
            timeDic.Add(10, 60 * 60 * 24 * 30);
            using (var connection = mqSetting.Factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

                    var argument = new Dictionary<string, object>();
                    argument.Add("x-dead-letter-exchange", message.ExchangeName);//过期消息转向路由  
                    argument.Add("x-dead-letter-routing-key", message.RouteKey);//过期消息转向路由相匹配routingkey  
                    var queueName = "timing_" + message.QueueName;
                    channel.QueueDeclare(queueName, true, false, false, argument);
                    if (!string.IsNullOrWhiteSpace(message.ExchangeName))
                    {
                        channel.QueueBind(queueName, message.ExchangeName, queueName, null);
                    }

                    IBasicProperties properties = channel.CreateBasicProperties();
                    properties.Persistent = true;//消息持久化
                    properties.Expiration = (timeDic[message.RetryCount]*1000).ToString();
                    channel.BasicPublish(exchange: message.ExchangeName, routingKey: queueName, basicProperties: properties, body: body);

                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// 消息转发机制(批量)
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="routeKeyList">路由交换机集合</param>
        /// <returns></returns>
        public static bool ForwardMessage(MessageModel message, IDictionary<string, string> routeKeyList)
        => ForwardMessage(MqSetting, message, routeKeyList);

        /// <summary>
        /// 消息转发机制(批量,指定mq连接对象)
        /// </summary>
        /// <param name="mqSetting">mq连接对象</param>
        /// <param name="message">消息体</param>
        /// <param name="routeKeyList">路由交换机集合</param>
        /// <returns></returns>
        public static bool ForwardMessage(MqSettingModel mqSetting, MessageModel message,IDictionary<string,string> routeKeyList)
        {
            var result = false;
            using (var connection = mqSetting.Factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    foreach (var item in routeKeyList)
                    {
                        message.ForwardMessage(item.Key, item.Value, mqSetting.Factory);
                        var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));
                        if (!string.IsNullOrWhiteSpace(item.Key))
                        {
                            channel.ExchangeDeclare(item.Key, MQExchangeTypeEnum.direct.ToString(), true, false, null);
                        }

                        IBasicProperties properties = channel.CreateBasicProperties();
                        properties.Persistent = true;//消息持久化
                        channel.BasicPublish(exchange: item.Key, routingKey: item.Value, basicProperties: properties, body: body);
                    }
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// 消息转发机制(指定mq连接对象)
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="exchangeName">交换机名称</param>
        /// <param name="routeKey">路由</param>
        /// <returns></returns>
        public static bool ForwardMessage(MessageModel message, string exchangeName, string routeKey)
=> ForwardMessage(MqSetting, message, exchangeName, routeKey);

        /// <summary>
        /// 消息转发机制
        /// </summary>
        /// <param name="mqSetting">mq连接对象</param>
        /// <param name="message">消息体</param>
        /// <param name="exchangeName">交换机名称</param>
        /// <param name="routeKey">路由</param>
        /// <returns></returns>
        public static bool ForwardMessage(MqSettingModel mqSetting, MessageModel message,string exchangeName,string routeKey)
        {
            var result = false;
            using (var connection = mqSetting.Factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    message.ForwardMessage(exchangeName, routeKey, mqSetting.Factory);
                    var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));
                    if (!string.IsNullOrWhiteSpace(exchangeName))
                    {
                        channel.ExchangeDeclare(exchangeName, MQExchangeTypeEnum.direct.ToString(), true, false, null);
                    }

                    IBasicProperties properties = channel.CreateBasicProperties();
                    properties.Persistent = true;//消息持久化
                    channel.BasicPublish(exchange: exchangeName, routingKey: routeKey, basicProperties: properties, body: body);
                    result = true;
                }
            }

            return result;
        }
    }
}
