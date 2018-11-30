using System.Data;
using System.Data.SqlClient;
using PaloItChallenge.Models;
using Dapper;

namespace PaloItChallenge.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private string _connectionString;
        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SaveFullName(FullName fullName)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                //TODO: Confirm SQL injection can't happen. 
                //Write a unit test to make sure SqlException is thrown when fullName.FirstName is a','b');Delete from UniHockey.dbo.FullName where id = 2--
                db.Execute("INSERT INTO UniHockey.dbo.FullName (FirstName, LastName) VALUES  (@firstName, @lastName)", new { fullName.FirstName, fullName.LastName });                
            }
        }
    }
}