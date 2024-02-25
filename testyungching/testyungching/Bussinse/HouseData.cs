using testyungching.Bussinse.Models;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using testyungching.Models;
namespace testyungching.Bussinse
{


    public class HouseData: Base
    {

      
        public List<HouseDataModel> GetHouseData(HouseSearchViewModel search)
        {
 
            var connString = config["ConnectionStrings:yungchingDatabase"];
      
            var results = new List<HouseDataModel>();

            using (var conn = new SqlConnection(connString))
            {
               var result = conn.Query<HouseDataModel>("SELECT * FROM HouseData");
                if (!string.IsNullOrEmpty(search.HouseId))
                {
                    result = result.Where(x => x.HouseId.Contains(search.HouseId));
                }
                if (!string.IsNullOrEmpty(search.HouseName))
                {
                    result = result.Where(x => x.HouseName.Contains(search.HouseName));
                }

                return result.ToList();
            }


            return results;
        }


    }
}
