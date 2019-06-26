using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace emailservice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [Route("Send")]
        public bool Send(string msg)
        {
            Console.WriteLine("发送邮件" + msg);
            return true;
        }
    }
}