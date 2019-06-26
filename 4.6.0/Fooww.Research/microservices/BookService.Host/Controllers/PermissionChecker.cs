using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Host.Controllers
{
    public class PermissionChecker
    {
        //public string IsGrantedAsync(string com, string strl)
        //{
        //    var task = Send100.Instance().Get(com, strl);
        //    return task;
        //}

        public string Get(string com, string strl)
        {
            string url = "http://poll.kuaidi100.com/poll/query.do";
            Encoding encoding = Encoding.GetEncoding("utf-8");

            //参数
            string str = strl;
            string param = "{\"com\":\"" + com + "\",\"num\":\"" + str + "\",\"from\":\"\",\"to\":\"\"}";
            string customer = "4FC24438857676E915EE243C171CFE5B";
            string key = "xjpUzFiv7191";
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] InBytes = Encoding.GetEncoding("UTF-8").GetBytes(param + key + customer);
            byte[] OutBytes = md5.ComputeHash(InBytes);
            string OutString = "";
            for (int i = 0; i < OutBytes.Length; i++)
            {
                OutString += OutBytes[i].ToString("x2");
            }
            string sign = OutString.ToUpper();
            IDictionary parameters = new Dictionary<string, string>();
            parameters.Add("param", param);
            parameters.Add("customer", customer);
            parameters.Add("sign", sign);
            HttpWebResponse response = RESTInvoker.CreatePostHttpResponse(url, parameters, encoding);
            //打印返回值
            System.IO.Stream stream = response.GetResponseStream();   //获取响应的字符串流
            StreamReader sr = new StreamReader(stream); //创建一个stream读取流
            string html = sr.ReadToEnd();   //从头读到尾，放到字符串html
            return html;
        }
    }
}