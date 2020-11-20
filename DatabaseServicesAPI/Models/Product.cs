using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseServicesAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Environment { get; set; }
        public string Domain { get; set; }
    }
}