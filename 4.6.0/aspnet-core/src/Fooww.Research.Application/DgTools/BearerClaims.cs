using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Authentication;

using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Security;
using System.Collections.Specialized;
using System.Security.Claims;
using Abp.Runtime.Session;
using Microsoft.Extensions.DependencyModel;

namespace Fooww.Research

//    https://www.cnblogs.com/spritekuang/p/10805737.html
//企业级工作流解决方案（六）--微服务消息处理模型之与Abp集成
//https://www.cnblogs.com/spritekuang/tag/abp/
{
    public class BearerClaims
    {
        private object jsonReqStr;

        public SortedDictionary<string, string> contextNameValueCollection { get; private set; }

        public void t()
        {
            var abpSession = Dependency.IocManager.Instance.Resolve<IAbpSession>();
            if (!string.IsNullOrEmpty(abpSession.AccessToken)) // 将用户Token转递到其他微服务
            {
                contextNameValueCollection.Add("AccessToken", "1");
                contextNameValueCollection.Add("UserId", abpSession.UserId?.ToString());
                contextNameValueCollection.Add("UserName", abpSession.UserName);
                contextNameValueCollection.Add("TenantId", abpSession.TenantId?.ToString());
                contextNameValueCollection.Add("RoleIds", abpSession.RoleIds);
            }
            var jsonRespStr = LocalRpcRun(jsonReqStr, contextNameValueCollection);
        }

        private object LocalRpcRun(object jsonReqStr, SortedDictionary<string, string> contextNameValueCollection)
        {
            throw new NotImplementedException();
        }

        public static Task<string> Process(string sessionId, string jsonRpc, object context = null)
        {
            return Task<string>.Factory.StartNew((_) =>
            {
                if ((context is Newtonsoft.Json.Linq.JObject) && (context as Newtonsoft.Json.Linq.JObject)["AccessToken"] != null) // 设置Token
                {
                    var identity = new ClaimsIdentity();
                    var accessToken = ((Newtonsoft.Json.Linq.JValue)(context as Newtonsoft.Json.Linq.JObject)["AccessToken"]).Value;
                    var userId = ((Newtonsoft.Json.Linq.JValue)(context as Newtonsoft.Json.Linq.JObject)["UserId"])?.Value;
                    var tenantId = ((Newtonsoft.Json.Linq.JValue)(context as Newtonsoft.Json.Linq.JObject)["TenantId"])?.Value;
                    var roleIds = ((Newtonsoft.Json.Linq.JValue)(context as Newtonsoft.Json.Linq.JObject)["RoleIds"])?.Value;
                    var userName = ((Newtonsoft.Json.Linq.JValue)(context as Newtonsoft.Json.Linq.JObject)["UserName"])?.Value;

                    if (userId != null) identity.AddClaim(new Claim(AbpClaimTypes.UserId, userId?.ToString()));
                    if (tenantId != null) identity.AddClaim(new Claim(AbpClaimTypes.TenantId, tenantId?.ToString()));
                //if (roleIds != null) identity.AddClaim(new Claim(AbpClaimTypes.RoleIds, roleIds?.ToString()));

                if (roleIds != null) identity.AddClaim(new Claim(AbpClaimTypes.Role, roleIds?.ToString()));
                    if (userName != null) identity.AddClaim(new Claim(AbpClaimTypes.UserName, userName?.ToString()));
                //if (accessToken != null) identity.AddClaim(new Claim(AbpClaimTypes.AccessToken, accessToken.ToString()));
                Thread.CurrentPrincipal = new ClaimsPrincipal(identity);
                }
                if (context is NameValueCollection)
                {
                    var namevalues = context as NameValueCollection;
                    if (Thread.CurrentPrincipal == null && !string.IsNullOrEmpty(namevalues.Get("AccessToken")))
                    {
                        var identity = new ClaimsIdentity();
                        var accessToken = namevalues.Get("AccessToken");
                        var userId = namevalues.Get("UserId");
                        var tenantId = namevalues.Get("TenantId");
                        var roleIds = namevalues.Get("RoleIds");
                        var userName = namevalues.Get("UserName");

                        if (userId != null) identity.AddClaim(new Claim(AbpClaimTypes.UserId, userId?.ToString()));
                        if (tenantId != null) identity.AddClaim(new Claim(AbpClaimTypes.TenantId, tenantId?.ToString()));
                    //if (roleIds != null) identity.AddClaim(new Claim(AbpClaimTypes.RoleIds, roleIds?.ToString()));
                    if (roleIds != null) identity.AddClaim(new Claim(AbpClaimTypes.Role, roleIds?.ToString()));
                        if (userName != null) identity.AddClaim(new Claim(AbpClaimTypes.UserName, userName?.ToString()));
                        if (accessToken != null) identity.AddClaim(new Claim(ClaimsIdentity.AccessToken, accessToken.ToString()));
                        Thread.CurrentPrincipal = new ClaimsPrincipal(identity);
                    }
                }

                var tuple = (Tuple<string, string, object>)_;
                return ProcessInternal(tuple.Item1, tuple.Item2, tuple.Item3);
            }, new Tuple<string, string, object>(sessionId, jsonRpc, context));
        }
    }
}