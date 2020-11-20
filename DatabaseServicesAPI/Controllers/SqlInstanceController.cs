using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DatabaseServicesAPI.Models;
using DatabaseServicesAPI.Classes;

namespace DatabaseServicesAPI.Controllers
{
    [Authorize]
    public class SqlInstanceController : ApiController
    {
        public IEnumerable<SqlInstance> Get()
        {

            List<SqlInstance> instanceList = new List<SqlInstance>();
            using(SqlConnection dbConnection = DBUtils.GetSqlConnection("ESRDBL5E0.qcorpaa.aa.com","SQLMONITOR"))
            {
                String tQuery = "SELECT [SQLInstanceID],[SQLInstance],[ActiveNode],[PublicIP],[ManagementIP],[LPort],[ResourceGovernor],[SupportTypeID],[Desc] FROM [inventory].[tbl_SQLInstance]";
                SqlCommand sqlCommand = dbConnection.CreateCommand();
                sqlCommand.CommandText = tQuery;
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                instanceList = (from DataRow dr in dt.Rows
                                select new SqlInstance()
                                {
                                    Id = Convert.ToInt32(dr["SQLInstanceID"]),
                                    SQLInstance = dr["SQLInstance"].ToString(),
                                    ActiveNode = dr["ActiveNode"].ToString(),
                                    PublicIP = dr["PublicIP"].ToString(),
                                    ManagementIP = dr["ManagementIP"].ToString(),
                                    LPort = dr["LPort"].ToString(),
                                    ResourceGovernor = Convert.ToInt32(dr["ResourceGovernor"]),
                                    SupportTypeID = Convert.ToInt32(dr["SupportTypeID"]),
                                    Desc = dr["Desc"].ToString(),
                                }

                                ).ToList();
            }
            
            return instanceList;
        }
    }
}
