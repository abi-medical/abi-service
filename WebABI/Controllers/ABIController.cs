using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebABI.Controllers
{
    public class MyModel
    {
        public int procedure { get; set; }
        public int machine_instance { get; set; }
        public string text { get; set; }
    }
    public class AbiController : ApiController
    {
        // GET: ABI


        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public MyModel Post([FromBody]MyModel myModel)
        {
            //Console.WriteLine("ID:" + id);
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = "C:\\Users\\CamiloAndrés\\source\\Human-Lab.exe";
                process.Start();
                return myModel;
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return  myModel;

            }


        }

        public void Put(int id, [FromBody]string value)
        {
        }
    }
}