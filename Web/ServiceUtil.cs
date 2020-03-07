using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using Steeltoe.Common.Discovery;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtil.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceUtil
    {
        private readonly HttpClient client = new HttpClient();
        private readonly IHostingEnvironment hostingEnv;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="discoveryClient"></param>
        /// <param name="hostingEnvironment"></param>
        public ServiceUtil(IDiscoveryClient discoveryClient, IHostingEnvironment hostingEnvironment)
        {
            DiscoveryHttpClientHandler _handler = new DiscoveryHttpClientHandler(discoveryClient);
            client = new HttpClient(_handler, false);
            hostingEnv = hostingEnvironment;
        }

        /// <summary>
        /// Post请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="service"></param>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<T> PostAsync<T>(ServiceType service, string url, object data) where T : class, new()
        {
            try
            {
                string issandbox = ConfigUtil.Configuration["issandbox"] == null ? "" : ConfigUtil.Configuration["issandbox"];
                //请求地址
                if (hostingEnv.IsDevelopment() || (issandbox == "1"))
                {
                    url = ConfigUtil.Configuration[service.ToString()] + (url.StartsWith("/") ? "" : "/") + url;
                }
                else
                {
                    url = "http://" + service.ToString() + (url.StartsWith("/") ? "" : "/") + url;
                }
                string content = "";
                if (data is string)
                {
                    content = data.ToString();
                }
                else
                {
                    content = JsonConvert.SerializeObject(data);
                }

                ByteArrayContent byteContent = null;
                if (service.ToString().StartsWith("wx."))
                {
                    Dictionary<string, object> dicJsonData = JsonConvert.DeserializeObject<Dictionary<string, object>>(content);
                    string postcontent = "";
                    foreach (string k in dicJsonData.Keys)
                    {
                        if (postcontent == "")
                        {
                            postcontent = k + "=" + (dicJsonData[k] == null ? "" : dicJsonData[k].ToString());
                        }
                        else
                        {
                            postcontent += "&" + k + "=" + (dicJsonData[k] == null ? "" : dicJsonData[k].ToString());
                        }
                    }
                    var buffer = Encoding.UTF8.GetBytes(postcontent);
                    byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                }
                else
                {
                    var buffer = Encoding.UTF8.GetBytes(content);
                    byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                }
                var response = await client.PostAsync(url, byteContent).ConfigureAwait(false);
                string result = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return new T();
                }
                return JsonConvert.DeserializeObject<T>(result);
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    string responseContent = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                    throw new System.Exception($"response :{responseContent}", ex);
                }
                throw;
            }
        }


        /// <summary>
        /// Post请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<T> PostAsync<T>(string url, object data) where T : class, new()
        {
            try
            {
                string content = JsonConvert.SerializeObject(data);
                var buffer = Encoding.UTF8.GetBytes(content);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                var response = await client.PostAsync(url, byteContent).ConfigureAwait(false);
                string result = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return new T();
                }
                return JsonConvert.DeserializeObject<T>(result);
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    string responseContent = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                    throw new System.Exception($"response :{responseContent}", ex);
                }
                throw;
            }
        }


        /// <summary>
        /// 公共微服务类型
        /// </summary>
        public enum ServiceType
        {
            /// <summary>
            /// 文件服务
            /// </summary>
            crm_file,
            /// <summary>
            /// MQ服务
            /// </summary>
            crm_mq,
            /// <summary>
            /// 缓存服务
            /// </summary>
            crm_memcache
        }
    }
}
