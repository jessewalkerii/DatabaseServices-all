using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseServicesAPI.Models
{
    public class SqlInstance
    {
        public int Id { get; set; }
        public string SQLInstance { get; set; }
        public string ActiveNode { get; set; }
        public string PublicIP { get; set; }
        public string ManagementIP { get; set; }
        public string LPort { get; set; }
        public int ResourceGovernor { get; set; }
        public int SupportTypeID { get; set; }
        public string Desc { get; set; }
    }
}