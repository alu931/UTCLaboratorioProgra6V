using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class DataAccess
    {
        private readonly IConfiguration config;

        public DataAccess(IConfiguration _config)
        {
            config = _config;
        }

        public SqlConnection DbConnection => new SqlConnection(
            new SqlConnectionStringBuilder(config.GetConnectionString("Conn")).ConnectionString
            
            );


        public async Task<IEnumerable<T>> QueryAsync<T>(string sp, object Param= null, int? Timeout=null)
        {
            try
            {
               
            }
            catch (Exception)
            {

                throw;
            }
               
        
        }

    }
}
