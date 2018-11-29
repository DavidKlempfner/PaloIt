using PaloItChallenge.DataAccess;
using PaloItChallenge.Models;

namespace PaloItChallenge.Services
{
    public class BusinessService : IBusinessService
    {
        private IDataAccess _dataAccess;
        public BusinessService(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void SaveFullName(FullName fullName)
        {
            _dataAccess.SaveFullName(fullName);
        }
    }
}