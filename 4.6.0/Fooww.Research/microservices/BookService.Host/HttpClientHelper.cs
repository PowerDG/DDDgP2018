using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BookService.Host
{
    public class HttpClientHelper
    {
        public static string GetResponseJson(string url, string header)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = httpClient.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseJson = response.Content.ReadAsStringAsync().Result;
                return responseJson;
            }
            else
            {
                return "出错了,StatusCode:" + response.StatusCode.ToString();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="url">调用的Api地址</param>
        /// <param name="requestJson">表单数据（json格式）</param>
        /// <returns></returns>
        public static string PostResponseJson(string url, string requestJson)
        {
            HttpContent httpContent = new StringContent(requestJson);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseJson = response.Content.ReadAsStringAsync().Result;
                return responseJson;
            }
            else
            {
                return "出错了,StatusCode:" + response.StatusCode.ToString();
            }
        }
    }
}