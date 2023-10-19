using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kutelala_api.Models
{
    public class Product
    {
        [Identity]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
