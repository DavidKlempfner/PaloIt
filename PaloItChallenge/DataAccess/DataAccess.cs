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
                //Set up an Exception FilterAttribute in case this fails:
                db.Execute("INSERT INTO UniHockey.dbo.FullName (FirstName, LastName) VALUES  (@firstName, @lastName)", new { fullName.FirstName, fullName.LastName });
            }
        }
    }
}