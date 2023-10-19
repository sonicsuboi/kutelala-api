using kutelala_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kutelala_api.Interfaces
{
   public interface IResponse
    {
        public Response Success(dynamic data);
        public Response Error(string Message);
        public Response Empty();
    }
}
