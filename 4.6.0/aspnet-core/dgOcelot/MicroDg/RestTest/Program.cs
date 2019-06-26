using RestTools;
using System;

namespace RestTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RestTemplate rest = new RestTemplate("http://127.0.0.1:8500");
            //RestTemplate把服务的解析和发请求以及响应反序列化帮我们完成
            ResponseEntity<String[]> resp = rest.GetForEntityAsync<String[]>("http://apiservice1/api/values").Result;
            Console.WriteLine(resp.StatusCode);
            Console.WriteLine(String.Join(",", resp.Body));

            Console.ReadKey();
        }
    }
}