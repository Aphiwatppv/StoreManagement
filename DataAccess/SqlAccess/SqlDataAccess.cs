using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccess.SqlAccess
{

    /// <summary>
    /// Provides asynchronous data access functionality to SQL Server databases using Dapper.
    /// </summary>
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;


        // <summary>
        /// Initializes a new instance of the <see cref="SqlDataAccess"/> class.
        /// </summary>
        /// <param name="configuration">The application configuration where connection strings are stored.</param>
        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Asynchronously loads data from the database using a stored procedure.
        /// </summary>
        /// <typeparam name="T">The type of data to return.</typeparam>
        /// <typeparam name="U">The type of the parameters object.</typeparam>
        /// <param name="storedProcedure">The name of the stored procedure.</param>
        /// <param name="parameters">The parameters for the stored procedure.</param>
        /// <returns>A collection of data of the specified type.</returns>
        public async Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters)
        {
            var connectionstring = _configuration.GetConnectionString("Default");
            using IDbConnection connection = new SqlConnection(connectionstring);
            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

        /// <summary>
        /// Asynchronously saves data to the database using a stored procedure.
        /// </summary>
        /// <typeparam name="T">The type of the parameters object.</typeparam>
        /// <param name="storedProcedure">The name of the stored procedure.</param>
        /// <param name="parameters">The parameters for the stored procedure.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task SaveDataAsync<T>(string storedProcedure, T parameters)
        {
            var connectionstring = _configuration.GetConnectionString("Default");
            using IDbConnection connection = new SqlConnection(connectionstring);
            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
