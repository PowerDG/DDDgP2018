using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;

using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Host.Controllers
{
    public class RESTInvoker
    {
        public static HttpWebResponse CreatePostHttpResponse(string url, IDictionary parameters, Encoding encoding)
        {
            HttpWebRequest request = null;
            //HTTPSQ请求
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            request = WebRequest.Create(url) as HttpWebRequest;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            //request.UserAgent = DefaultUserAgent;
            //如果需要POST数据
            if (!(parameters == null || parameters.Count == 0))
            {
                StringBuilder buffer = new StringBuilder();
                int i = 0;
                foreach (string key in parameters.Keys)
                {
                    if (i > 0)
                    {
                        buffer.AppendFormat("&{0}={1}", key, parameters[key]);
                    }
                    else
                    {
                        buffer.AppendFormat("{0}={1}", key, parameters[key]);
                    }
                    i++;
                }
                byte[] data = System.Text.Encoding.ASCII.GetBytes(buffer.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            return request.GetResponse() as HttpWebResponse;
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true; //总是接受
        }

        //---------------------
        //作者：刹影
        //来源：CSDN
        //原文：https://blog.csdn.net/zt102545/article/details/86551903
        //版权声明：本文为博主原创文章，转载请附上博文链接！

        public static void sdf(string urls)
        {
            string url = urls;
            //定义request并设置request的路径
            WebRequest request = WebRequest.Create(url);
            request.Method = "post";
            //初始化request参数
            string postData = "{\"dataSource\":\"DataSource=192.168.0.70/orcl70;UserID=sde;PassWord=sde;\",\"type\":\"0\",\"whereCondition\":\"dlwz='国和百寿一村6号'\",\"tableName\":\"hzdzd_pt\"}";
            //var json = "{ \"dataSource\": \"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.70)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl70)));User ID=sde;Password=sde;Unicode=True\" }";
            //设置参数的编码格式，解决中文乱码
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            //设置request的MIME类型及内容长度
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            //打开request字符流
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            //定义response为前面的request响应
            WebResponse response = request.GetResponse();
            //获取相应的状态代码
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            //定义response字符流
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();//读取所有
            Console.WriteLine(responseFromServer);
        }
    }
}