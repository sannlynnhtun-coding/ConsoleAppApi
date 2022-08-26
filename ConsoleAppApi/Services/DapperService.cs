using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppApi.Services
{
    public class DapperService
    {
        public async Task<List<BRANCH>> GetList()
        {
            List<BRANCH> lst = new List<BRANCH>();
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "MFTB",
                UserID = "sa",
                Password = "sa@123"
            };
            using (IDbConnection connection = new SqlConnection(sb.ConnectionString))
            {
                connection.Open();

                string query = @"SELECT t.*
      FROM MFTB.dbo.TBL_BRANCH t with (nolock) where City_Code = @CityCode";
                var result = await connection.QueryAsync<BRANCH>(query, new { CityCode = "C-001" });
                lst = result.ToList();

                connection.Close();
            }
            return lst;
        }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class BRANCH
    {
        public int BRANCH_ID { get; set; }
        public string BRANCH_CODE { get; set; }
        public string NAME { get; set; }
        public string CITY_CODE { get; set; }
        public string TOWNSHIP_CODE { get; set; }
        public double LATITUDE { get; set; }
        public double LONGITUDE { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string TRANSFER_RATECODE { get; set; }
        public string REMITTANCE_RATECODE { get; set; }
        public string RATE_DESCRIPTION { get; set; }
        public bool DEL_FLAG { get; set; }
        public string CREATED_USER_ID { get; set; }
        public string CREATED_DATETIME { get; set; }
        public string UPDATED_USER_ID { get; set; }
        public string UPDATED_DATETIME { get; set; }
    }


}
