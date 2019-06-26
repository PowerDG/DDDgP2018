using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace smsservice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        [Route("Send")]
        public bool Send(string msg)
        {
            Console.WriteLine("发送短信" + msg);
            return true;
        }
    }
}