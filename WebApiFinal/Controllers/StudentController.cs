using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPii.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        public int GetData1()
        {
            return 10;
        }

        [HttpGet]
        public int GetData2(int a, int b) //Get data from query string
        {
            return a + b;
        }

        [HttpPost]
        public String Save(StudentDTO dto) //Get data from body
        {
            return dto.name + "-testing";
        }

    }

    public class StudentDTO
    {
        public int id { get; set; }
        public String name { get; set; }
    }
}