using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooww.Research.Editions
{
    /// <summary>
    /// Abp + MongoDb 改造默认的审计日志存储位置
    /// https://www.520mwx.com/view/30025
    /// Abp + MongoDb 改造默认的审计日志存储位置
    /// https://www.520mwx.com/view/30025
    /// 
    ///  ABP结合MongoDB的使用范例  
    /// http://blog.skydev.cc/article/view/3f26d81a-3e74-4ac4-8c56-79e1da7ee2fa
    /// 
    /// 2016-2-3 Add Abp.MongoDb functions. 
    /// https://github.com/2fumin/LtePlatform/commit/f52afb928291f16bf11b652abd194b3c24cf31d7#diff-6a954e24311fd7d572e9b9ebf0fcc5e3
    /// HTML5+Activex+Singr+ABP+MongoDB[????]
    /// https://www.cnblogs.com/jsyb/archive/2016/03/04/5243846.html
    /// </summary>
    public interface IAuditingMongoDbConfiguration
    {
        //IAuditingMongoDbConfiguration
            /// <summary>
    /// MongoDb 连接字符串。
    /// </summary>
    string ConnectionString { get; set; }

    /// <summary>
    /// 要连接的 MongoDb 数据库名称 
    /// </summary>
    string DataBaseName { get; set; }
    }

    public interface IMongoClientFactory
    {
        IMongoClient Create();
    }
}
