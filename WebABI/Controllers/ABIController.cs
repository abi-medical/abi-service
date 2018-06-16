using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebABI.Controllers
{
    public class AbiController : ApiController
    {
        // GET: ABI


        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public void Post(int id,[FromBody]string value)
        {
            Console.WriteLine("ID:" + id);
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = "C:\\Users\\CamiloAndrés\\source\\repos\\software analizador de movimiento\\Human-Lab.exe";
                process.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          

        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}