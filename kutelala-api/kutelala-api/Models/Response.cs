using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kutelala_api.Models
{
    public class Response
    {
        public int Code { get;  set; }
        public bool Status { get;  set; }
        public string Message { get;  set; }
        public dynamic Data { get;  set; }



    }
}
